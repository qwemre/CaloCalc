using DAL.Context;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KategoriBLL : ICRUD<Kategori>
    {
        CaloCalcDbContext Db;
        public KategoriBLL()
        {
            Db=new CaloCalcDbContext();
        }
        public Kategori Ara(int id)
        {

            var kategori=Db.Kategoriler.Find(id);
            return kategori;


        }

        public bool Ekle(Kategori entity)
        {

            Db.Kategoriler.Add(entity);
            return Db.SaveChanges() > 0;

        }

        public bool Guncelle(Kategori entity)
        {

            Db.Kategoriler.Update(entity);
            return Db.SaveChanges() > 0;


        }

        public List<Kategori> Liste()
        {

            return Db.Kategoriler.ToList();
            

        }

        public bool Sil(int id)
        {

            var kategori= Db.Kategoriler.Find(id);
            return Db.SaveChanges() > 0;

        }
    }
}
