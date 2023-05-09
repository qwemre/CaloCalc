using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CaloCalcBussinessLogic
    {
        public CaloCalcBussinessLogic()
        {
            Kategoriler=new KategoriBLL();
            Yiyecekler = new YiyecekBLL();
            Kullanicilar = new KullaniciBLL();
            Ogunler = new OgunBLL();
        }
        public KategoriBLL Kategoriler { get; set; }
        public YiyecekBLL Yiyecekler { get; set; }
        public KullaniciBLL Kullanicilar { get; set; }
        public OgunBLL Ogunler { get; set; }
    }
}
