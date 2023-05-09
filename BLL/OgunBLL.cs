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

        public bool Ekle(Ogun entity)
        {
            Db.Ogunler.Add(entity);
            return Db.SaveChanges() > 0;
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
    }
}
