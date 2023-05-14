using BLL;
using Entities;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CaloCalc.Helper
{
    public class Methods
    {
        public Methods()
        {
            bll = new CaloCalcBussinessLogic();
        }
        Yiyecek yiyecek;
        Ogun ogun;
        CaloCalcBussinessLogic bll;
        Kullanici kullanici;


        public void BoyKiloDoldurma(int id, MaskedTextBox boy, MaskedTextBox kilo)
        {
            var kullanici = bll.Kullanicilar.Ara(id);
            boy.Text = kullanici.Boy.ToString();
            kilo.Text = kullanici.Kilo.ToString();

        }

        public void index(int id, Label indexhesap, Label lblBilgi)
        {
            bll = new CaloCalcBussinessLogic();
            kullanici = bll.Kullanicilar.Ara(id);
            double boy = kullanici.Boy / 100.0;
            double kilo = kullanici.Kilo;
            double hesap = kilo / (boy * boy);
            indexhesap.Text = (hesap.ToString("f1"));

            if (hesap < 18.5)
            {
                lblBilgi.Text = "Zayıfsınız";
            }
            else if (hesap >= 18.5 && hesap <= 24.9)
            {
                lblBilgi.Text = "Normal kilolusunuz";
            }
            else if (hesap >= 25 && hesap <= 29.9)
            {
                lblBilgi.Text = "Fazla kilolusunuz";
            }
            else if (hesap >= 30)
            {
                lblBilgi.Text = "Şişmanlık (Obezite Sınıfı)";
            }
        }
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
        public void SorguListViewYazdirma(ListView listView, List<Yiyecek> liste)
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
            cmb.DisplayMember = "YiyeceKalori";
            cmb.ValueMember = "YiyecekID";
        }
        public bool BtnEkleGorevi(int id, int YiyecekID, Ogunler ogunad, double porsiyon)
        {
            ogun = new();
            yiyecek = bll.Yiyecekler.Ara(YiyecekID);
            ogun.KullaniciID = id;
            ogun.YiyecekID = yiyecek.YiyecekID;
            ogun.OgunAdi = ogunad;
            ogun.PorsiyonAdet = porsiyon;
            ogun.YemekYemeZamani = DateTime.Now;
            ogun.ToplamKalori = (yiyecek.Kalori * ogun.PorsiyonAdet);
            return bll.Ogunler.Ekle(ogun);
        }
        public bool BtnGuncelleGorevi(int ogunID, int yiyecekID, double porsiyon)
        {
            Ogun guncellenecekOgun = bll.Ogunler.Ara(ogunID);
            yiyecek = bll.Yiyecekler.Ara(yiyecekID);
            guncellenecekOgun.YiyecekID = yiyecek.YiyecekID;
            guncellenecekOgun.PorsiyonAdet = porsiyon;
            guncellenecekOgun.YemekYemeZamani = DateTime.Now;
            guncellenecekOgun.ToplamKalori = (yiyecek.Kalori * guncellenecekOgun.PorsiyonAdet);
            return bll.Ogunler.Guncelle(guncellenecekOgun);
        }
        public void EkleAktif(Button ekle,Button sil,Button güncelle)
        {
            ekle.Enabled=true;
            sil.Enabled = false;
            güncelle.Enabled = false;
        }
        public void EklePasif(Button ekle, Button sil, Button güncelle)
        {
            ekle.Enabled = false;
            sil.Enabled = true;
            güncelle .Enabled = true;
        }
    }
}
