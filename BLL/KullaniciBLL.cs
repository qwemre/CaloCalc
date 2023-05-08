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
        public Kullanici Ara(int id)
        {
            throw new NotImplementedException();
        }

        public void Ekle(Kullanici entity)
        {
            throw new NotImplementedException();
        }

        public void Guncelle(Kullanici entity)
        {
            throw new NotImplementedException();
        }

        public List<Kullanici> Liste()
        {
            throw new NotImplementedException();
        }

        public void Sil(int id)
        {
            throw new NotImplementedException();
        }
    }
}
