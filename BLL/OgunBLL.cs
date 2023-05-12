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

        
        public List<Ogun> listeleme(int kullaniciID,Ogunler ogun)
        {
            using (var context = new CaloCalcDbContext())
            {
                var yiyecekler = context.Ogunler
                    .Include(y => y.Yiyecekler)
                    .Where(y => y.OgunAdi == ogun&&y.KullaniciID==kullaniciID&&y.YemekYemeZamani.Day==DateTime.Now.Day)
                    .ToList();

                return yiyecekler;
            }
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
       



    }

}
