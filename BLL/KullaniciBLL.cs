using DAL.Context;
using Entities;
using Entities.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KullaniciBLL : ICRUD<Kullanici>
    {
        CaloCalcDbContext Db;
        public KullaniciBLL()
        {
            Db = new CaloCalcDbContext();
        }

        public List<Kullanici> Liste()
        {
            List<Kullanici> kullanicilar = Db.Kullanicilar.ToList();
            return kullanicilar;
        }
        public Kullanici Ara(int id)
        {
            var kullanici = Db.Kullanicilar.Find(id);
            return kullanici;
        }

        public bool Ekle(Kullanici entity)
        {

            Db.Kullanicilar.Add(entity);
            return Db.SaveChanges()>0;

        }

        public bool Guncelle(Kullanici entity)
        {

            Db.Kullanicilar.Update(entity);
            return Db.SaveChanges() > 0;
        }


        public bool Sil(int id)
        {
            var kullanici = Db.Kullanicilar.Find(id);
            Db.Kullanicilar.Remove(kullanici);
            return Db.SaveChanges() > 0;

        }

        public void HaftalikOgunKiyasRaporu(int kullaniciId)
        {
            var oneWeekAgo = DateTime.Today.AddDays(-7);
            var userMeals = Db.Ogunler
                .Include(o => o.Yiyecekler)
                .Where(o => o.KullaniciID == kullaniciId && o.YemekYemeZamani >= oneWeekAgo)
                .ToList();

            var weeklyComparison = Db.Ogunler
                .Include(o => o.Yiyecekler)
                .Where(o => o.KullaniciID != kullaniciId && o.YemekYemeZamani >= oneWeekAgo)
                .GroupBy(o => o.YemekYemeZamani.Date.AddDays(-(int)o.YemekYemeZamani.DayOfWeek))
                .Select(g => new
                {
                    Week = g.Key,
                    UserCalories = userMeals.Where(um => um.YemekYemeZamani.Date.AddDays(-(int)um.YemekYemeZamani.DayOfWeek) == g.Key).Sum(um => um.ToplamKalori),
                    OtherUsersCalories = g.Sum(o => o.ToplamKalori)
                })
                .OrderByDescending(c => c.Week)
                .ToList();
        }

        public void HaftalikKategoriKiyasRaporu(int kullaniciId)
        {
            var oneWeekAgo = DateTime.Today.AddDays(-7);
            var userMeals = Db.Ogunler
                .Include(o => o.Yiyecekler)
                .Where(o => o.KullaniciID == kullaniciId && o.YemekYemeZamani >= oneWeekAgo)
                .ToList();

            var weeklyComparison = Db.Ogunler
                .Include(o => o.Yiyecekler)
                .Where(o => o.KullaniciID != kullaniciId && o.YemekYemeZamani >= oneWeekAgo)
                .GroupBy(o => new { WeekStart = o.YemekYemeZamani.Date.AddDays(-(int)o.YemekYemeZamani.DayOfWeek), o.Yiyecekler.FirstOrDefault().Kategori })
                .Select(g => new
                {
                    WeekStart = g.Key.WeekStart,
                    Category = g.Key.Kategori,
                    UserCalories = userMeals.Where(um => um.YemekYemeZamani.Date.AddDays(-(int)um.YemekYemeZamani.DayOfWeek) == g.Key.WeekStart && um.Yiyecekler.FirstOrDefault().Kategori == g.Key.Kategori).Sum(um => um.ToplamKalori),
                    OtherUsersCalories = g.Sum(o => o.ToplamKalori)
                })
                .OrderByDescending(c => c.WeekStart)
                .ThenBy(c => c.Category)
                .ToList();
        }
        public double GunSonuRaporu(int kullaniciId)
        {
            var tarih = DateTime.Now.Date;
            var ogunler = Db.Ogunler
                .Where(o => o.KullaniciID == kullaniciId && o.YemekYemeZamani.Date == tarih )
                .Include(o => o.Yiyecekler)
                .ToList();
            var toplamKalori = ogunler.Sum(o => o.ToplamKalori);
            return toplamKalori;
        }

        public double OguneGoreKaloriRaporu(int kullaniciId,Ogunler ogunAdi)
        {
            var tarih = DateTime.Now.Date;
            var ogunler = Db.Ogunler
                .Where(o => o.KullaniciID == kullaniciId && o.YemekYemeZamani.Date == tarih && o.OgunAdi == ogunAdi)
                .Include(o => o.Yiyecekler)
                .ToList();
            var toplamKalori = ogunler.Sum(o => o.ToplamKalori);
            return toplamKalori;
        }
   
        public int KullaniciGiris(string kullaniciMail, string sifre)
        {
            Kullanici kullanici = Db.Kullanicilar.Where(x => x.KullaniciMail == kullaniciMail && x.Sifre == sifre).SingleOrDefault();

            if (kullanici.KullaniciID == 0)
            {
                return -1;
            }
            else
            {
                return kullanici.KullaniciID;
            }
        }

    }
}
