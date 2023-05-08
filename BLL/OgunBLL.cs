using DAL.Context;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public void Ekle(Ogun entity)
        {
            Db.Ogunler.Add(entity);
            Db.SaveChanges();
        }

        public void Guncelle(Ogun entity)
        {
            Db.Ogunler.Update(entity);
            Db.SaveChanges();
        }

        public List<Ogun> Liste()
        {
            return Db.Ogunler.ToList();
        }

        public void Sil(int id)
        {
            Db.Ogunler.Remove(Ara(id));
            Db.SaveChanges();
        }
    }
}
