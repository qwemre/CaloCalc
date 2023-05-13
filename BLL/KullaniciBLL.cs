using DAL.Context;
using Entities;
using Entities.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            return Db.Kullanicilar.Find(id);
        }
        public bool MailAra(string mail)
        {
            var kullanici = Db.Kullanicilar.FirstOrDefault(x => x.KullaniciMail == mail);
            if (kullanici == null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public bool Ekle(Kullanici entity)
        {

            Db.Kullanicilar.Add(entity);
            return Db.SaveChanges() > 0;

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
        public double GunSonuRaporu(int kullaniciId)
        {
            var tarih = DateTime.Now.Date;
            var ogunler = Db.Ogunler
                .Where(o => o.KullaniciID == kullaniciId && o.YemekYemeZamani.Date == tarih)
                .Include(o => o.Yiyecekler)
                .ToList();
            var toplamKalori = ogunler.Sum(o => o.ToplamKalori);
            return toplamKalori;
        }
        public double OguneGoreKaloriRaporu(int kullaniciId, Ogunler ogunAdi)
        {
            var tarih = DateTime.Now.Date;
            var ogunler = Db.Ogunler
                .Where(o => o.KullaniciID == kullaniciId && o.YemekYemeZamani.Date == tarih && o.OgunAdi == ogunAdi)
                .Include(o => o.Yiyecekler)
                .ToList();
            var toplamKalori = ogunler.Sum(o => o.ToplamKalori);
            return toplamKalori;
        }
        public List<Kullanici> BoyKilo(int kullaniciId) 
        {
            var kisi=Db.Kullanicilar.Where(x=>x.KullaniciID==kullaniciId).ToList();
            return kisi;
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
        public Kullanici MaileGoreAra(string Mail)
        {
            return Db.Kullanicilar.FirstOrDefault(x => x.KullaniciMail == Mail);
        }

       
    }
}

