using BLL;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using DAL.Context;
using CaloCalc.Helper;



namespace CaloCalc
{
    public partial class AnaEkran : Form
    {
       // Ogun ogun;
        //Yiyecek yiyecek;
        int id;
        Methods helper = new();
        public AnaEkran(int ıd)
        {
            InitializeComponent();
            this.id = ıd;
            bll = new CaloCalcBussinessLogic();
        }
        CaloCalcBussinessLogic bll;
        private void AnaEkran_Load(object sender, EventArgs e)
        {
            lblSabah.Text = bll.Kullanicilar.OguneGoreKaloriRaporu(id, Ogunler.Kahvaltı).ToString();
            lblSabahAtistirma.Text = bll.Kullanicilar.OguneGoreKaloriRaporu(id, Ogunler.SabahAtistirmasi).ToString();
            lblOglen.Text = bll.Kullanicilar.OguneGoreKaloriRaporu(id, Ogunler.OglenYemegi).ToString();
            lblOglenAtistirma.Text = bll.Kullanicilar.OguneGoreKaloriRaporu(id, Ogunler.OglenAtistirmasi).ToString();
            lblAksam.Text = bll.Kullanicilar.OguneGoreKaloriRaporu(id, Ogunler.AksamYemegi).ToString();
            lblAksamAtistirma.Text = bll.Kullanicilar.OguneGoreKaloriRaporu(id, Ogunler.AksamAtistirmasi).ToString();
            lblToplam.Text = bll.Kullanicilar.GunSonuRaporu(id).ToString();

            //cbxSabahKahvaltısı.DataSource = bll.Yiyecekler.Liste();
            //cbxSabahKahvaltısı.DisplayMember = "YiyecekAdi";
            //cbxSabahKahvaltısı.ValueMember = "YiyecekID";
            helper.comboboxDoldurma(cbxSabahKahvaltısı);
            helper.comboboxDoldurma(cbxSabahAtistirmasi);
            helper.comboboxDoldurma(cbxOglenYemegi);
            helper.comboboxDoldurma(cbxOglenAtistirmasi);
            helper.comboboxDoldurma(cbxAksamAtistirmasi);
            helper.comboboxDoldurma(cbxAksamAtistirmasi);


            //cbxSabahAtistirmasi.DataSource = bll.Yiyecekler.Liste();
            //cbxSabahAtistirmasi.DisplayMember = "YiyecekAdi";
            //cbxSabahAtistirmasi.ValueMember = "YiyecekID";

            //cbxOglenYemegi.DataSource = bll.Yiyecekler.Liste();
            //cbxOglenYemegi.DisplayMember = "YiyecekAdi";
            //cbxOglenYemegi.ValueMember = "YiyecekID";

            //cbxOglenAtistirmasi.DataSource = bll.Yiyecekler.Liste();
            //cbxOglenAtistirmasi.DisplayMember = "YiyecekAdi";
            //cbxOglenAtistirmasi.ValueMember = "YiyecekID";

            //cbxAksamYemegi.DataSource = bll.Yiyecekler.Liste();
            //cbxAksamYemegi.DisplayMember = "YiyecekAdi";
            //cbxAksamYemegi.ValueMember = "YiyecekID";

            //cbxAksamAtistirmasi.DataSource = bll.Yiyecekler.Liste();
            //cbxAksamAtistirmasi.DisplayMember = "YiyecekAdi";
            //cbxAksamAtistirmasi.ValueMember = "YiyecekID";

            helper.ListViewYazdirma(id, Ogunler.Kahvaltı, lvSabahKahvaltiListe);
            helper.ListViewYazdirma(id, Ogunler.SabahAtistirmasi, lviSabahAtistirmasiList);
            helper.ListViewYazdirma(id, Ogunler.OglenYemegi, lviOglenYemegiList);
            helper.ListViewYazdirma(id, Ogunler.OglenAtistirmasi, lviOglenAtistirmasiList);
            helper.ListViewYazdirma(id, Ogunler.AksamYemegi, lviAksamYemegiList);
            helper.ListViewYazdirma(id, Ogunler.AksamAtistirmasi, lviSabahAtistirmasiList);


        }
        private void btnBesinEkle_Click(object sender, EventArgs e)
        {
            this.Close();
            BesinOlusturma frm = new BesinOlusturma(id);
            frm.ShowDialog();

        }
        private void btnKahvaltıEkle_Click(object sender, EventArgs e)
        {
            bool kontrol = helper.BtnEkleGorevi(id, (int)cbxSabahKahvaltısı.SelectedValue, Ogunler.Kahvaltı, (double)nudKahvaltiPorsiyon.Value);
            //ogun = new();
            //yiyecek = bll.Yiyecekler.Ara((int)cbxSabahKahvaltısı.SelectedValue);
            //ogun.KullaniciID = id;
            //ogun.YiyecekID = yiyecek.YiyecekID;
            //ogun.OgunAdi = Ogunler.Kahvaltı;
            //ogun.PorsiyonAdet = (double)nudKahvaltiPorsiyon.Value;
            //ogun.YemekYemeZamani = DateTime.Now;
            //ogun.ToplamKalori = (yiyecek.Kalori * ogun.PorsiyonAdet);
            //bool kontrol = bll.Ogunler.Ekle(ogun);
            if (kontrol)
            {
                helper.ListViewYazdirma(id, Ogunler.Kahvaltı, lvSabahKahvaltiListe);
                bll = new CaloCalcBussinessLogic();
                MessageBox.Show("Eklendi");
            }
        }
        private void btnSabahAtistirmasiEkle_Click(object sender, EventArgs e)
        {
            bool kontrol = helper.BtnEkleGorevi(id, (int)cbxSabahAtistirmasi.SelectedValue, Ogunler.SabahAtistirmasi, (double)nudSabahAtistirmasiPorsiyon.Value);

            //ogun = new();
            //yiyecek = bll.Yiyecekler.Ara((int)cbxSabahAtistirmasi.SelectedValue);
            //ogun.KullaniciID = id;
            //ogun.YiyecekID = yiyecek.YiyecekID;
            //ogun.OgunAdi = Ogunler.SabahAtistirmasi;
            //ogun.PorsiyonAdet = (double)nudSabahAtistirmasiPorsiyon.Value;
            //ogun.YemekYemeZamani = DateTime.Now;
            //ogun.ToplamKalori = (yiyecek.Kalori * ogun.PorsiyonAdet);
            //bool kontrol = bll.Ogunler.Ekle(ogun);
            if (kontrol)
            {
                helper.ListViewYazdirma(id, Ogunler.SabahAtistirmasi, lviSabahAtistirmasiList);
                bll = new CaloCalcBussinessLogic();
                MessageBox.Show("Eklendi");
            }
        }

        private void btnOglenYemegiEkle_Click(object sender, EventArgs e)
        {
            bool kontrol = helper.BtnEkleGorevi(id, (int)cbxOglenYemegi.SelectedValue, Ogunler.OglenYemegi, (double)nudOglenYemegiPorsiyon.Value);

            //ogun = new();
            //yiyecek = bll.Yiyecekler.Ara((int)cbxOglenYemegi.SelectedValue);
            //ogun.KullaniciID = id;
            //ogun.YiyecekID = yiyecek.YiyecekID;
            //ogun.OgunAdi = Ogunler.OglenYemegi;
            //ogun.PorsiyonAdet = (double)nudOglenYemegiPorsiyon.Value;
            //ogun.YemekYemeZamani = DateTime.Now;
            //ogun.ToplamKalori = (yiyecek.Kalori * ogun.PorsiyonAdet);
            //bool kontrol = bll.Ogunler.Ekle(ogun);
            if (kontrol)
            {
                helper.ListViewYazdirma(id, Ogunler.OglenYemegi, lviOglenYemegiList);
                bll = new CaloCalcBussinessLogic();
                MessageBox.Show("Eklendi");
            }
        }

        private void btnOglenAtistirmasiEkle_Click(object sender, EventArgs e)
        {
            bool kontrol = helper.BtnEkleGorevi(id, (int)cbxOglenAtistirmasi.SelectedValue, Ogunler.OglenAtistirmasi, (double)nudOglenAtistirmasiPorsiyon.Value);

            //ogun = new();
            //yiyecek = bll.Yiyecekler.Ara((int)cbxOglenAtistirmasi.SelectedValue);
            //ogun.KullaniciID = id;
            //ogun.YiyecekID = yiyecek.YiyecekID;
            //ogun.OgunAdi = Ogunler.OglenAtistirmasi;
            //ogun.PorsiyonAdet = (double)nudOglenAtistirmasiPorsiyon.Value;
            //ogun.YemekYemeZamani = DateTime.Now;
            //ogun.ToplamKalori = (yiyecek.Kalori * ogun.PorsiyonAdet);
            //bool kontrol = bll.Ogunler.Ekle(ogun);
            if (kontrol)
            {
                helper.ListViewYazdirma(id, Ogunler.OglenAtistirmasi, lviOglenAtistirmasiList);
                bll = new CaloCalcBussinessLogic();
                MessageBox.Show("Eklendi");
            }
        }

        private void btnAksamYemegiEkle_Click(object sender, EventArgs e)
        {
            bool kontrol = helper.BtnEkleGorevi(id, (int)cbxAksamYemegi.SelectedValue, Ogunler.AksamYemegi, (double)nudAksamYemegiPorsiyon.Value);

            //ogun = new();
            //yiyecek = bll.Yiyecekler.Ara((int)cbxAksamYemegi.SelectedValue);
            //ogun.KullaniciID = id;
            //ogun.YiyecekID = yiyecek.YiyecekID;
            //ogun.OgunAdi = Ogunler.AksamYemegi;
            //ogun.PorsiyonAdet = (double)nudAksamYemegiPorsiyon.Value;
            //ogun.YemekYemeZamani = DateTime.Now;
            //ogun.ToplamKalori = (yiyecek.Kalori * ogun.PorsiyonAdet);
            //bool kontrol = bll.Ogunler.Ekle(ogun);
            if (kontrol)
            {
                helper.ListViewYazdirma(id, Ogunler.AksamYemegi, lviAksamYemegiList);
                bll = new CaloCalcBussinessLogic();
                MessageBox.Show("Eklendi");
            }
        }

        private void btnAksamAtistirmasiEkle_Click(object sender, EventArgs e)
        {
            bool kontrol = helper.BtnEkleGorevi(id, (int)cbxOglenAtistirmasi.SelectedValue, Ogunler.AksamAtistirmasi, (double)nudAksamAtistirmasiPorsiyon.Value);

            //ogun = new();
            //yiyecek = bll.Yiyecekler.Ara((int)cbxAksamAtistirmasi.SelectedValue);
            //ogun.KullaniciID = id;
            //ogun.YiyecekID = yiyecek.YiyecekID;
            //ogun.OgunAdi = Ogunler.AksamAtistirmasi;
            //ogun.PorsiyonAdet = (double)nudAksamAtistirmasiPorsiyon.Value;
            //ogun.YemekYemeZamani = DateTime.Now;
            //ogun.ToplamKalori = (yiyecek.Kalori * ogun.PorsiyonAdet);
            //bool kontrol = bll.Ogunler.Ekle(ogun);
            if (kontrol)
            {
                helper.ListViewYazdirma(id, Ogunler.AksamAtistirmasi, lviAksamAtistirmasiList);
                bll = new CaloCalcBussinessLogic();
                MessageBox.Show("Eklendi");
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                bll = new CaloCalcBussinessLogic();
                lblSabah.Text = bll.Kullanicilar.OguneGoreKaloriRaporu(id, Ogunler.Kahvaltı).ToString();
                lblSabahAtistirma.Text = bll.Kullanicilar.OguneGoreKaloriRaporu(id, Ogunler.SabahAtistirmasi).ToString();
                lblOglen.Text = bll.Kullanicilar.OguneGoreKaloriRaporu(id, Ogunler.OglenYemegi).ToString();
                lblOglenAtistirma.Text = bll.Kullanicilar.OguneGoreKaloriRaporu(id, Ogunler.OglenAtistirmasi).ToString();
                lblAksam.Text = bll.Kullanicilar.OguneGoreKaloriRaporu(id, Ogunler.AksamYemegi).ToString();
                lblAksamAtistirma.Text = bll.Kullanicilar.OguneGoreKaloriRaporu(id, Ogunler.AksamAtistirmasi).ToString();
                lblToplam.Text = bll.Kullanicilar.GunSonuRaporu(id).ToString();
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                bll = new CaloCalcBussinessLogic();
                var liste = bll.Yiyecekler.EnCokYenenler();
                if (liste != null)
                {
                    helper.SorguListViewYazdirma(lviEnCokYenenler, liste);
                    //lviEnCokYenenler.Items.Clear();
                    //foreach (var yemek in liste)
                    //{
                    //    ListViewItem lvi = new ListViewItem();
                    //    lvi.Text = yemek.YiyecekAdi.ToString();
                    //    lvi.SubItems.Add(yemek.Kalori.ToString());
                    //    lvi.SubItems.Add(yemek.Toplam.ToString());
                    //    lvi.SubItems.Add(yemek.Ogun.OgunAdi.ToString());
                    //    lviEnCokYenenler.Items.Add(lvi);
                    //}
                }
            }
            else if (tabControl1.SelectedIndex == 3)
            {
                bll = new CaloCalcBussinessLogic();
                var liste = bll.Yiyecekler.EnCokYediklerim(id, 7);
                if (liste != null)
                {
                    helper.SorguListViewYazdirma(lviEnCokYediklerimHaftalik, liste);
                    //lviEnCokYediklerimHaftalik.Items.Clear();
                    //foreach (var yemek in liste)
                    //{
                    //    ListViewItem lvi = new ListViewItem();
                    //    lvi.Text = yemek.YiyecekAdi.ToString();
                    //    lvi.SubItems.Add(yemek.Kalori.ToString());
                    //    lvi.SubItems.Add(yemek.Toplam.ToString());
                    //    lvi.SubItems.Add(yemek.Ogun.OgunAdi.ToString());
                    //    lviEnCokYediklerimHaftalik.Items.Add(lvi);
                    //}
                }

                bll = new CaloCalcBussinessLogic();
                var liste1 = bll.Yiyecekler.EnCokYediklerim(id, 30);
                if (liste1 != null)
                {
                    helper.SorguListViewYazdirma(lviEnCokYediklerimAylik, liste1);
                    //lviEnCokYediklerimAylik.Items.Clear();
                    //foreach (var yemek in liste1)
                    //{
                    //    ListViewItem lvi = new ListViewItem();
                    //    lvi.Text = yemek.YiyecekAdi.ToString();
                    //    lvi.SubItems.Add(yemek.Kalori.ToString());
                    //    lvi.SubItems.Add(yemek.Toplam.ToString());
                    //    lvi.SubItems.Add(yemek.Ogun.OgunAdi.ToString());
                    //    lviEnCokYediklerimAylik.Items.Add(lvi);
                    //}
                }
            }
            else if (tabControl1.SelectedIndex == 4)
            {
                bll = new CaloCalcBussinessLogic();
                var liste = bll.Yiyecekler.EnCokYedikleri(id, 7);
                if (liste != null)
                {
                    helper.SorguListViewYazdirma(lviDigerleriEnCokNeYemisHaftalik, liste);
                    //lviDigerleriEnCokNeYemisHaftalik.Items.Clear();
                    //foreach (var yemek in liste)
                    //{
                    //    ListViewItem lvi = new ListViewItem();
                    //    lvi.Text = yemek.YiyecekAdi.ToString();
                    //    lvi.SubItems.Add(yemek.Kalori.ToString());
                    //    lvi.SubItems.Add(yemek.Toplam.ToString());
                    //    lvi.SubItems.Add(yemek.Ogun.OgunAdi.ToString());
                    //    lviDigerleriEnCokNeYemisHaftalik.Items.Add(lvi);
                    //}
                }
                bll = new CaloCalcBussinessLogic();
                var liste1 = bll.Yiyecekler.EnCokYedikleri(id, 30);
                if (liste1 != null)
                {
                    helper.SorguListViewYazdirma(lviDigerleriEnCokNeYemisAylik, liste1);
                    //lviDigerleriEnCokNeYemisAylik.Items.Clear();
                    //foreach (var yemek in liste1)
                    //{
                    //    ListViewItem lvi = new ListViewItem();
                    //    lvi.Text = yemek.YiyecekAdi.ToString();
                    //    lvi.SubItems.Add(yemek.Kalori.ToString());
                    //    lvi.SubItems.Add(yemek.Toplam.ToString());
                    //    lvi.SubItems.Add(yemek.Ogun.OgunAdi.ToString());
                    //    lviDigerleriEnCokNeYemisAylik.Items.Add(lvi);
                    //}
                }
            }
        }

        private void btnKahvaltiSil_Click(object sender, EventArgs e)
        {
            if (lvSabahKahvaltiListe.SelectedItems.Count > 0)
            {
               
                if (bll.Ogunler.Sil((int)lvSabahKahvaltiListe.SelectedItems[0].Tag))
                {
                    MessageBox.Show("Silindi");
                    helper.ListViewYazdirma(id, Ogunler.Kahvaltı, lvSabahKahvaltiListe);
                }
                else
                    MessageBox.Show("Bir hata olustu silemedik.");
            }
        }

        private void btnKahvaltiGuncelle_Click(object sender, EventArgs e)
        {
            if (lvSabahKahvaltiListe.SelectedItems.Count > 0)
            {
                bool güncellediMi = helper.BtnGuncelleGorevi((int)lvSabahKahvaltiListe.SelectedItems[0].Tag, (int)cbxSabahKahvaltısı.SelectedValue, (double)nudKahvaltiPorsiyon.Value);
                //int ogunID = (int)lvSabahKahvaltiListe.SelectedItems[0].Tag;
                //Ogun guncellenecekOgun = bll.Ogunler.Ara(ogunID);
                //yiyecek = bll.Yiyecekler.Ara((int)cbxSabahKahvaltısı.SelectedValue);
                //guncellenecekOgun.YiyecekID = yiyecek.YiyecekID;
                //guncellenecekOgun.PorsiyonAdet = (double)nudKahvaltiPorsiyon.Value;
                //guncellenecekOgun.YemekYemeZamani = DateTime.Now;
                //guncellenecekOgun.ToplamKalori = (yiyecek.Kalori * guncellenecekOgun.PorsiyonAdet);
                //bool güncellediMi = bll.Ogunler.Guncelle(guncellenecekOgun);
                if (güncellediMi)
                {
                    MessageBox.Show("Güncellendi");
                    helper.ListViewYazdirma(id, Ogunler.Kahvaltı, lvSabahKahvaltiListe);
                }
                else
                    MessageBox.Show("Bir hata olustu güncellenemdi.");
            }

        }

        private void btnSabahAtistirmasiSil_Click(object sender, EventArgs e)
        {
            if (lviSabahAtistirmasiList.SelectedItems.Count > 0)
            {
                if (bll.Ogunler.Sil((int)lviSabahAtistirmasiList.SelectedItems[0].Tag))
                {
                    MessageBox.Show("Silindi");
                    helper.ListViewYazdirma(id, Ogunler.SabahAtistirmasi, lviSabahAtistirmasiList);
                }
                else
                {
                    MessageBox.Show("Bir hata olustu silemedik.");
                }

            }
        }

        private void btnSabahAtistirmasiGuncelle_Click(object sender, EventArgs e)
        {
            if (lviSabahAtistirmasiList.SelectedItems.Count > 0)
            {
                bool güncellediMi = helper.BtnGuncelleGorevi((int)lviSabahAtistirmasiList.SelectedItems[0].Tag, (int)cbxSabahAtistirmasi.SelectedValue, (double)nudSabahAtistirmasiPorsiyon.Value);

                //int ogunID = (int)lviSabahAtistirmasiList.SelectedItems[0].Tag;
                //Ogun guncellenecekOgun = bll.Ogunler.Ara(ogunID);
                //yiyecek = bll.Yiyecekler.Ara((int)cbxSabahAtistirmasi.SelectedValue);
                //guncellenecekOgun.YiyecekID = yiyecek.YiyecekID;
                //guncellenecekOgun.PorsiyonAdet = (double)nudSabahAtistirmasiPorsiyon.Value;
                //guncellenecekOgun.YemekYemeZamani = DateTime.Now;
                //guncellenecekOgun.ToplamKalori = (yiyecek.Kalori * guncellenecekOgun.PorsiyonAdet);
                //bool güncellediMi = bll.Ogunler.Guncelle(guncellenecekOgun);
                if (güncellediMi)
                {
                    MessageBox.Show("Güncellendi");
                    helper.ListViewYazdirma(id, Ogunler.SabahAtistirmasi, lviSabahAtistirmasiList);
                }
                else
                    MessageBox.Show("Bir hata olustu güncellenemdi.");
            }
        }

        private void btnOglenYemegiGuncelle_Click(object sender, EventArgs e)
        {
            if (lviOglenYemegiList.SelectedItems.Count > 0)
            {
               bool güncellediMi= helper.BtnGuncelleGorevi((int)lviOglenYemegiList.SelectedItems[0].Tag, (int)cbxOglenYemegi.SelectedValue, (double)nudOglenYemegiPorsiyon.Value);
                //int ogunID = (int)lviOglenYemegiList.SelectedItems[0].Tag;
                //Ogun guncellenecekOgun = bll.Ogunler.Ara(ogunID);
                //yiyecek = bll.Yiyecekler.Ara((int)cbxOglenYemegi.SelectedValue);
                //guncellenecekOgun.YiyecekID = yiyecek.YiyecekID;
                //guncellenecekOgun.PorsiyonAdet = (double)nudOglenYemegiPorsiyon.Value;
                //guncellenecekOgun.YemekYemeZamani = DateTime.Now;
                //guncellenecekOgun.ToplamKalori = (yiyecek.Kalori * guncellenecekOgun.PorsiyonAdet);
                //bool güncellediMi = bll.Ogunler.Guncelle(guncellenecekOgun);
                if (güncellediMi)
                {
                    MessageBox.Show("Güncellendi");
                    helper.ListViewYazdirma(id, Ogunler.OglenYemegi, lviOglenYemegiList);
                }
                else
                    MessageBox.Show("Bir hata olustu güncellenemdi.");
            }
        }

        private void btnOglenYemegiSil_Click(object sender, EventArgs e)
        {
            if (lviOglenYemegiList.SelectedItems.Count > 0)
            {
                bool sildiMi = bll.Ogunler.Sil((int)lviOglenYemegiList.SelectedItems[0].Tag);
                if (sildiMi)
                {
                    MessageBox.Show("Silindi");
                    helper.ListViewYazdirma(id, Ogunler.OglenYemegi, lviOglenYemegiList);
                }
                else
                    MessageBox.Show("Bir hata olustu silemedik.");
            }
        }
        private void btnOglenAtistirmasiSil_Click(object sender, EventArgs e)
        {
            if (lviOglenAtistirmasiList.SelectedItems.Count > 0)
            {
                bool sildiMi = bll.Ogunler.Sil((int)lviOglenAtistirmasiList.SelectedItems[0].Tag);
                if (sildiMi)
                {
                    MessageBox.Show("Silindi");
                    helper.ListViewYazdirma(id, Ogunler.OglenAtistirmasi, lviOglenAtistirmasiList);
                }
                else
                    MessageBox.Show("Bir hata olustu silemedik.");
            }

        }
        private void btnOglenAtistirmasiGuncelle_Click(object sender, EventArgs e)
        {
            if (lviOglenAtistirmasiList.SelectedItems.Count > 0)
            {
                bool güncellediMi = helper.BtnGuncelleGorevi((int)lviOglenAtistirmasiList.SelectedItems[0].Tag, (int)cbxOglenAtistirmasi.SelectedValue, (double)nudOglenAtistirmasiPorsiyon.Value);

                //int ogunID = (int)lviOglenAtistirmasiList.SelectedItems[0].Tag;
                //Ogun guncellenecekOgun = bll.Ogunler.Ara(ogunID);
                //yiyecek = bll.Yiyecekler.Ara((int)cbxOglenAtistirmasi.SelectedValue);
                //guncellenecekOgun.YiyecekID = yiyecek.YiyecekID;
                //guncellenecekOgun.PorsiyonAdet = (double)nudOglenAtistirmasiPorsiyon.Value;
                //guncellenecekOgun.YemekYemeZamani = DateTime.Now;
                //guncellenecekOgun.ToplamKalori = (yiyecek.Kalori * guncellenecekOgun.PorsiyonAdet);
                //bool güncellediMi = bll.Ogunler.Guncelle(guncellenecekOgun);
                if (güncellediMi)
                {
                    MessageBox.Show("Güncellendi");
                    helper.ListViewYazdirma(id, Ogunler.OglenAtistirmasi, lviOglenAtistirmasiList);
                }
                else
                    MessageBox.Show("Bir hata olustu güncellenemdi.");
            }
        }
        private void btnAksamYemegiSil_Click(object sender, EventArgs e)
        {
            if (lviAksamYemegiList.SelectedItems.Count > 0)
            {
                if (bll.Ogunler.Sil((int)lviAksamYemegiList.SelectedItems[0].Tag))
                {
                    MessageBox.Show("Silindi");
                    helper.ListViewYazdirma(id, Ogunler.AksamYemegi, lviAksamYemegiList);
                }
                else
                    MessageBox.Show("Bir hata olustu silemedik.");
            }
        }
        private void btnAksamYemegiGuncelle_Click(object sender, EventArgs e)
        {
            if (lviAksamYemegiList.SelectedItems.Count > 0)
            {
                bool güncellediMi = helper.BtnGuncelleGorevi((int)lviAksamYemegiList.SelectedItems[0].Tag, (int)cbxAksamYemegi.SelectedValue, (double)nudAksamYemegiPorsiyon.Value);
                //int ogunID = (int)lviAksamYemegiList.SelectedItems[0].Tag;
                //Ogun guncellenecekOgun = bll.Ogunler.Ara(ogunID);
                //yiyecek = bll.Yiyecekler.Ara((int)cbxAksamYemegi.SelectedValue);
                //guncellenecekOgun.YiyecekID = yiyecek.YiyecekID;
                //guncellenecekOgun.PorsiyonAdet = (double)nudAksamYemegiPorsiyon.Value;
                //guncellenecekOgun.YemekYemeZamani = DateTime.Now;
                //guncellenecekOgun.ToplamKalori = (yiyecek.Kalori * guncellenecekOgun.PorsiyonAdet);
                //bool güncellediMi = bll.Ogunler.Guncelle(guncellenecekOgun);
                if (güncellediMi)
                {
                    MessageBox.Show("Güncellendi");
                    helper.ListViewYazdirma(id, Ogunler.AksamYemegi, lviAksamYemegiList);
                }
                else
                    MessageBox.Show("Bir hata olustu güncellenemdi.");
            }
        }
        private void btnAksamAtistirmasiSil_Click(object sender, EventArgs e)
        {
            if (lviAksamAtistirmasiList.SelectedItems.Count > 0)
            {
                if (bll.Ogunler.Sil((int)lviAksamAtistirmasiList.SelectedItems[0].Tag))
                {
                    MessageBox.Show("Silindi");
                    helper.ListViewYazdirma(id, Ogunler.AksamAtistirmasi, lviAksamAtistirmasiList);
                }
                else
                    MessageBox.Show("Bir hata olustu silemedik.");
            }
        }
        private void btnAksamAtistirmasiGuncelle_Click(object sender, EventArgs e)
        {
            if (lviAksamAtistirmasiList.SelectedItems.Count > 0)
            {
                bool güncellediMi = helper.BtnGuncelleGorevi((int)lviAksamAtistirmasiList.SelectedItems[0].Tag, (int)cbxAksamAtistirmasi.SelectedValue, (double)nudAksamAtistirmasiPorsiyon.Value);

                //int ogunID = (int)lviAksamAtistirmasiList.SelectedItems[0].Tag;
                //Ogun guncellenecekOgun = bll.Ogunler.Ara(ogunID);
                //yiyecek = bll.Yiyecekler.Ara((int)cbxSabahAtistirmasi.SelectedValue);
                //guncellenecekOgun.YiyecekID = yiyecek.YiyecekID;
                //guncellenecekOgun.PorsiyonAdet = (double)nudAksamAtistirmasiPorsiyon.Value;
                //guncellenecekOgun.YemekYemeZamani = DateTime.Now;
                //guncellenecekOgun.ToplamKalori = (yiyecek.Kalori * guncellenecekOgun.PorsiyonAdet);
                //bool güncellediMi = bll.Ogunler.Guncelle(guncellenecekOgun);
                if (güncellediMi)
                {
                    MessageBox.Show("Güncellendi");
                    helper.ListViewYazdirma(id, Ogunler.AksamAtistirmasi, lviAksamAtistirmasiList);
                }
                else
                    MessageBox.Show("Bir hata olustu güncellenemdi.");
            }
        }
    }
}
