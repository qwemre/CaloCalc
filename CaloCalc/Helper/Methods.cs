using BLL;
using Entities;
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
        Yiyecek yiyecek;
        Ogun ogun;
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
                    lvi.Tag = yemek.OgunID;
                    listView.Items.Add(lvi);
                }
            }
        }
        public void SorguListViewYazdirma(ListView listView,List<Yiyecek>liste)
        {
            listView.Items.Clear();
            foreach (var yemek in liste)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = yemek.YiyecekAdi.ToString();
                lvi.SubItems.Add(yemek.Kalori.ToString());
                lvi.SubItems.Add(yemek.Toplam.ToString());
                lvi.SubItems.Add(yemek.Ogun.OgunAdi.ToString());
                listView.Items.Add(lvi);
            }
        }
         public void comboboxDoldurma(ComboBox cmb)
        {
            cmb.DataSource = bll.Yiyecekler.Liste();
            cmb.DisplayMember = "YiyecekAdi";
            cmb.ValueMember = "YiyecekID";
        }
        public bool BtnEkleGorevi(int id, int YiyecekID,Ogunler ogunad,double porsiyon)
        {
            ogun = new();
            yiyecek = bll.Yiyecekler.Ara(YiyecekID);
            ogun.KullaniciID = id;
            ogun.YiyecekID = yiyecek.YiyecekID;
            ogun.OgunAdi = ogunad;
            ogun.PorsiyonAdet = porsiyon;
            ogun.YemekYemeZamani = DateTime.Now;
            ogun.ToplamKalori = (yiyecek.Kalori * ogun.PorsiyonAdet);
           return   bll.Ogunler.Ekle(ogun);
        }
        public bool BtnGuncelleGorevi(int ogunID,int yiyecekID,double porsiyon)
        {
            Ogun guncellenecekOgun = bll.Ogunler.Ara(ogunID);
            yiyecek = bll.Yiyecekler.Ara(yiyecekID);
            guncellenecekOgun.YiyecekID = yiyecek.YiyecekID;
            guncellenecekOgun.PorsiyonAdet = porsiyon;
            guncellenecekOgun.YemekYemeZamani = DateTime.Now;
            guncellenecekOgun.ToplamKalori = (yiyecek.Kalori * guncellenecekOgun.PorsiyonAdet);
           return bll.Ogunler.Guncelle(guncellenecekOgun);
        }
    }
}
