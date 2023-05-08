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
            throw new NotImplementedException();
        }

        public void Ekle(Yiyecek entity)
        {
            throw new NotImplementedException();
        }

        public void Guncelle(Yiyecek entity)
        {
            throw new NotImplementedException();
        }

        public List<Yiyecek> Liste()
        {
            throw new NotImplementedException();
        }

        public void Sil(int id)
        {
            throw new NotImplementedException();
        }
    }
}
