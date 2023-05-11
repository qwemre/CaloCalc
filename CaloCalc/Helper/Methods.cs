using BLL;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloCalc.Helper
{
    public class Methods
    {
        public Methods()
        {
            bll=new CaloCalcBussinessLogic();
        }

        CaloCalcBussinessLogic bll;
        public void ListViewYazdirma(int id, Ogunler ogun, ListView listView)
        {
            listView.Items.Clear();
            var liste = bll.Ogunler.listeleme(id, ogun);
            if (liste != null)
            {
                foreach (var yemek in liste)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = bll.Yiyecekler.Ara(yemek.YiyecekID).YiyecekAdi.ToString();
                    lvi.SubItems.Add(bll.Yiyecekler.Ara(yemek.YiyecekID).Kalori.ToString());
                    lvi.SubItems.Add(yemek.PorsiyonAdet.ToString());
                    lvi.SubItems.Add((yemek.PorsiyonAdet * bll.Yiyecekler.Ara(yemek.YiyecekID).Kalori).ToString());
                    listView.Items.Add(lvi);
                }
            }
        }
    }
}
