using DAL.Context;
using Entities;
using Entities.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OgunBLL : ICRUD<Ogun>
    {
        CaloCalcDbContext Db;
        public OgunBLL()
        {
            Db = new CaloCalcDbContext();
        }
        public Ogun Ara(int id)
        {
            return Db.Ogunler.Find(id);
        }

        public bool Ekle(Ogun entity)
        {
            Db.Ogunler.Add(entity);
            if (Db.SaveChanges() > 0)
            { 
                return true;
            }
            else { return false; }
            
        }

        public bool Guncelle(Ogun entity)
        {
            Db.Ogunler.Update(entity);
            return Db.SaveChanges() > 0;
        }

        public List<Ogun> Liste()
        {
            return Db.Ogunler.ToList();
        }

        public bool Sil(int id)
        {
            Db.Ogunler.Remove(Ara(id));
            return Db.SaveChanges() > 0;
        }
        public List<Ogun> OguneGoreYenenYemekRaporu(int kullaniciId, Ogunler ogunAdi)
        {
            var tarih = DateTime.Now.Date;
            var ogunler = Db.Ogunler
                .Where(o => o.KullaniciID == kullaniciId && o.YemekYemeZamani.Date == tarih && o.OgunAdi == ogunAdi)
                .ToList();
            return ogunler;
        }

        public List<Ogun> Fıfo(int kullaniciId,Ogunler ogunler)
        {
            var ogun = Db.Ogunler
           .Include(o => o.Yiyecekler)
           .Where(o => o.OgunAdi==ogunler && o.KullaniciID == kullaniciId&&o.YemekYemeZamani.Day==DateTime.Now.Day).ToList();
            return ogun;
        }
        public List<Ogun> Fıfo2(int kullaniciId, Ogunler ogunler)
        {
            var ogun = Db.Ogunler
           .Include(o => o.Yiyecekler)
           .Where(o => o.OgunAdi == ogunler && o.KullaniciID == kullaniciId).ToList();
            
            return ogun;
        }
        public int KisiOgunIDBul(int kullaniciID, Ogunler ogunler)
        {
            var SonOgun = Db.Ogunler
                                .Where(x => x.KullaniciID == kullaniciID && x.OgunAdi == ogunler)
                                .LastOrDefault();
            int OgunID = SonOgun.OgunID;
            return OgunID;
            
        }
        public List<Ogun> OgunAra(int ogunID,int kullaniciID)
        {
            var ogun=Db.Ogunler.Where(x=>x.KullaniciID==kullaniciID&&x.OgunID==ogunID).ToList();
            return ogun;
        }


        //public List<Entities.Yiyecek> listeleme(int kullaniciID,int ogunID)
        //{
        //    using (var context = new CaloCalcDbContext())
        //    {
        //        var yiyecekler = context.Yiyecekler
        //            .Join(context.Ogunler,
        //                  y => y.YiyecekID,
        //                  o => o.OgunID,
        //                  (y, o) => new
        //                  {
        //                      o.OgunID,
        //                      o.KullaniciID,
        //                      y.YiyecekAdi,
        //                      y.Kalori,                              
        //                      o.OgunAdi,
        //                      o.YemekYemeZamani,
        //                      o.PorsiyonAdet,
        //                      o.ToplamKalori
        //                  }).Where(x=>x.KullaniciID==kullaniciID&&x.OgunID==ogunID)
        //            .ToList();
        //        return yiyecekler;
        //    }

        //}
        //public List<Yiyecek> listeleme(int kullaniciID, Ogunler ogunler)
        //{
        //    using (var context = new CaloCalcDbContext())
        //    {
        //        var yiyecekler = context.Yiyecekler
        //            .Join(context.Ogunler,
        //                  y => y.OgunID,
        //                  o => o.OgunID,
        //                  (y, o) => new { Yiyecek = y, Ogun = o })
        //            .Where(x => x.Ogun.KullaniciID == kullaniciID && x.Ogun.OgunAdi==ogunler && x.Ogun.YemekYemeZamani.Day == DateTime.Now.Day)
        //            .Select(x => x.Yiyecek)
        //            .ToList();
        //        return yiyecekler;
        //    }
        //}
        //public List<Yiyecek> listeleme(int kullaniciID)
        //{
        //    using (var context = new CaloCalcDbContext())
        //    {
        //        var yiyecekler = context.Yiyecekler
        //            .Join(context.Ogunler,
        //                  y => y.YiyecekID,
        //                  o => o.YiyecekID,
        //                  (y, o) => new { Yiyecek = y, Ogun = o })
        //            .Where(x => x.Ogun.OgunAdi == Ogunler.Kahvaltı&&x.Ogun.Kullanici.KullaniciID==kullaniciID)
        //            .Select(x => x.Yiyecek)
        //            .ToList();
        //        return yiyecekler;
        //    }
        //}
        public List<Ogun> listeleme(int kullaniciID)
        {
            using (var context = new CaloCalcDbContext())
            {
                var yiyecekler = context.Ogunler
                    .Include(y => y.Yiyecekler)
                    .Where(y => y.OgunAdi == Ogunler.Kahvaltı&&y.KullaniciID==kullaniciID)
                    .ToList();

                return yiyecekler;
            }
        }





        //public List<object> GetYemekRaporu(int kullaniciId, Ogunler ogunAdi)
        //{

        //        var rapor = Db.Ogunler
        //            .Include(o => o.Yiyecekler)
        //            .Where(o => o.OgunAdi == ogunAdi && o.KullaniciID == kullaniciId)
        //            .Select(o => new
        //            {
        //                YemekAdi = o.Yiyecekler
        //                KullaniciAdi = o.Kullanici.Adi,
        //                OgunAdi = o.OgunAdi.ToString()
        //            })
        //            .ToList();

        //        return rapor.Cast<object>().ToList();

        //}
    }

}
