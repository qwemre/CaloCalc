using DAL.Context;
using Entities;
using Entities.Enums;
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
            if (Db.SaveChanges() > 0)
                return true;
            else
                return false;
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


        public Yiyecek AdaGoreAra(string yiyecekAdi)
        {
            return Db.Yiyecekler.FirstOrDefault(x => x.YiyecekAdi == yiyecekAdi);
        }



    }
}
