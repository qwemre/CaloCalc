using DAL.Context;
using Entities;
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

        public void Ekle(Yiyecek entity)
        {
            Db.Yiyecekler.Add(entity);
        }

        public void Guncelle(Yiyecek entity)
        {
           Db.Yiyecekler.Update(entity);
        }

        public List<Yiyecek> Liste()
        {
            return Db.Yiyecekler.ToList();
        }

        public void Sil(int id)
        {
            Db.Yiyecekler.Remove(Ara(id));
        }
    }
}
