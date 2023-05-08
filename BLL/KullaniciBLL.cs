using DAL.Context;
using Entities;
using System;
using System.Collections.Generic;
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
            List<Kullanici> kullanicilar=Db.Kullanicilar.ToList();
            return kullanicilar;
        }
        public Kullanici Ara(int id)
        {
            var kullanici=Db.Kullanicilar.Find(id);
            return kullanici;
        }      

        public void Ekle(Kullanici entity)
        {

            Db.Kullanicilar.Add(entity);

        }

        public void Guncelle(Kullanici entity)
        {

            Db.Kullanicilar.Update(entity);
            Db.SaveChanges();
        }


        public void Sil(int id)
        {
            var kullanici=Db.Kullanicilar.Find(id);
            Db.Kullanicilar.Remove(kullanici);

        }
    }
}
