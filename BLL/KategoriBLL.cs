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

        public void Ekle(Kategori entity)
        {

            Db.Kategoriler.Add(entity);

        }

        public void Guncelle(Kategori entity)
        {

            Db.Kategoriler.Update(entity);


        }

        public List<Kategori> Liste()
        {

            return Db.Kategoriler.ToList();
            

        }

        public void Sil(int id)
        {

            var kategori= Db.Kategoriler.Find(id);
            Db.Kategoriler.Remove(kategori);

        }
    }
}
