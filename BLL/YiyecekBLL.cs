using DAL.Context;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class YiyecekBLL : ICRUD<Yiyecek>
    {
        CaloCalcDbContext Db;
        public YiyecekBLL()
        {
            Db = new CaloCalcDbContext();
        }
        public Yiyecek Ara(int id)
        {
            return Db.Yiyecekler.Find(id);
        }

        public bool Ekle(Yiyecek entity)
        {
            Db.Yiyecekler.Add(entity);
            return Db.SaveChanges() > 0;
        }

        public bool Guncelle(Yiyecek entity)
        {
            Db.Yiyecekler.Update(entity);
            return Db.SaveChanges() > 0;

        }

        public List<Yiyecek> Liste()
        {
            return Db.Yiyecekler.ToList();
        }

        public bool Sil(int id)
        {
            Db.Yiyecekler.Remove(Ara(id));
            return Db.SaveChanges() > 0;
        }

        public void EnCokYenenYemekOguneGore(int kullaniciId)
        {
            var userMeals = Db.Ogunler
            .Where(o => o.KullaniciID == kullaniciId)
            .Include(o => o.Yiyecekler)
            .ToList();

            var mealDetails = userMeals
                .SelectMany(o => o.Yiyecekler.Select(y => new
                {
                    MealType = o.OgunAdi,
                    FoodName = y.YiyecekAdi,
                    Calories = y.Porsiyon * y.Kalori
                }))
                .GroupBy(d => new { d.MealType, d.FoodName })
                .Select(g => new
                {
                    MealType = g.Key.MealType,
                    FoodName = g.Key.FoodName,
                    TotalCalories = g.Sum(d => d.Calories)
                })
                .OrderBy(d => d.MealType)
                .ThenBy(d => d.FoodName)
                .ToList();
        }

        public void EnCokYenenYemekler()
        {
            var mostEatenFoods = Db.Ogunler
                .SelectMany(o => o.Yiyecekler)
                .GroupBy(y => y)
                .OrderByDescending(g => g.Count())
                .Take(10) 
                .Select(g => new { Yemek = g.Key, Toplam = g.Count() })
                .ToList();
            
        }



    }
}
