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

            helper.comboboxDoldurma(cbxSabahKahvaltısı);
            helper.comboboxDoldurma(cbxSabahAtistirmasi);
            helper.comboboxDoldurma(cbxOglenYemegi);
            helper.comboboxDoldurma(cbxOglenAtistirmasi);
            helper.comboboxDoldurma(cbxAksamYemegi);
            helper.comboboxDoldurma(cbxAksamAtistirmasi);

            helper.ListViewYazdirma(id, Ogunler.Kahvaltı, lvSabahKahvaltiListe);
            helper.ListViewYazdirma(id, Ogunler.SabahAtistirmasi, lviSabahAtistirmasiList);
            helper.ListViewYazdirma(id, Ogunler.OglenYemegi, lviOglenYemegiList);
            helper.ListViewYazdirma(id, Ogunler.OglenAtistirmasi, lviOglenAtistirmasiList);
            helper.ListViewYazdirma(id, Ogunler.AksamYemegi, lviAksamYemegiList);
            helper.ListViewYazdirma(id, Ogunler.AksamAtistirmasi, lviSabahAtistirmasiList);
            helper.BoyKiloDoldurma(id, mtxtBoyDegis, mtxtKiloDegis);

            helper.index(id, lblBoyKiloİndex, lblBilgi);

            helper.EkleAktif(btnKahvaltıEkle, btnKahvaltiGuncelle, btnKahvaltiSil);
            helper.EkleAktif(btnSabahAtistirmasiEkle, btnSabahAtistirmasiGuncelle, btnSabahAtistirmasiSil);
            helper.EkleAktif(btnOglenYemegiEkle, btnOglenYemegiGuncelle, btnOglenYemegiSil);
            helper.EkleAktif(btnOglenAtistirmasiEkle, btnOglenAtistirmasiGuncelle, btnOglenAtistirmasiSil);
            helper.EkleAktif(btnAksamYemegiEkle, btnAksamYemegiGuncelle, btnAksamYemegiSil);
            helper.EkleAktif(btnAksamAtistirmasiEkle, btnAksamAtistirmasiGuncelle, btnAksamAtistirmasiSil);

        }
        private void btnBesinEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            BesinOlusturma frm = new BesinOlusturma(id);
            frm.ShowDialog();

        }
        private void btnKahvaltıEkle_Click(object sender, EventArgs e)
        {
            bool kontrol = helper.BtnEkleGorevi(id, (int)cbxSabahKahvaltısı.SelectedValue, Ogunler.Kahvaltı, (double)nudKahvaltiPorsiyon.Value);
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
            if (kontrol)
            {
                helper.ListViewYazdirma(id, Ogunler.AksamYemegi, lviAksamYemegiList);
                bll = new CaloCalcBussinessLogic();
                MessageBox.Show("Eklendi");
            }
        }

        private void btnAksamAtistirmasiEkle_Click(object sender, EventArgs e)
        {
            bool kontrol = helper.BtnEkleGorevi(id, (int)cbxAksamAtistirmasi.SelectedValue, Ogunler.AksamAtistirmasi, (double)nudAksamAtistirmasiPorsiyon.Value);
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
                helper.index(id, lblBoyKiloİndex, lblBilgi);

            }
            else if (tabControl1.SelectedIndex == 2)
            {
                bll = new CaloCalcBussinessLogic();
                var liste = bll.Yiyecekler.EnCokYenenler();
                if (liste != null)
                {
                    helper.SorguListViewYazdirma(lviEnCokYenenler, liste);
                }
            }
            else if (tabControl1.SelectedIndex == 3)
            {
                bll = new CaloCalcBussinessLogic();
                var liste = bll.Yiyecekler.EnCokYediklerim(id, 7);
                if (liste != null)
                {
                    helper.SorguListViewYazdirma(lviEnCokYediklerimHaftalik, liste);
                }
                bll = new CaloCalcBussinessLogic();
                var liste1 = bll.Yiyecekler.EnCokYediklerim(id, 30);
                if (liste1 != null)
                {
                    helper.SorguListViewYazdirma(lviEnCokYediklerimAylik, liste1);
                }
            }
            else if (tabControl1.SelectedIndex == 4)
            {
                bll = new CaloCalcBussinessLogic();
                var liste = bll.Yiyecekler.EnCokYedikleri(id, 7);
                if (liste != null)
                {
                    helper.SorguListViewYazdirma(lviDigerleriEnCokNeYemisHaftalik, liste);
                }
                bll = new CaloCalcBussinessLogic();
                var liste1 = bll.Yiyecekler.EnCokYedikleri(id, 30);
                if (liste1 != null)
                {
                    helper.SorguListViewYazdirma(lviDigerleriEnCokNeYemisAylik, liste1);
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
                    helper.EkleAktif(btnKahvaltıEkle, btnKahvaltiGuncelle, btnKahvaltiSil);
                }
                else MessageBox.Show("Bir hata olustu silemedik.");
            }
        }

        private void btnKahvaltiGuncelle_Click(object sender, EventArgs e)
        {
            if (lvSabahKahvaltiListe.SelectedItems.Count > 0)
            {
                bool güncellediMi = helper.BtnGuncelleGorevi((int)lvSabahKahvaltiListe.SelectedItems[0].Tag, (int)cbxSabahKahvaltısı.SelectedValue, (double)nudKahvaltiPorsiyon.Value);
                if (güncellediMi)
                {
                    MessageBox.Show("Güncellendi");
                    helper.ListViewYazdirma(id, Ogunler.Kahvaltı, lvSabahKahvaltiListe);
                    helper.EkleAktif(btnKahvaltıEkle, btnKahvaltiGuncelle, btnKahvaltiSil);
                }
                else MessageBox.Show("Bir hata olustu güncellenemdi.");
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
                    helper.EkleAktif(btnSabahAtistirmasiEkle, btnSabahAtistirmasiGuncelle, btnSabahAtistirmasiSil);

                }

                else MessageBox.Show("Bir hata olustu silemedik.");
            }
        }
        private void btnSabahAtistirmasiGuncelle_Click(object sender, EventArgs e)
        {
            if (lviSabahAtistirmasiList.SelectedItems.Count > 0)
            {
                bool güncellediMi = helper.BtnGuncelleGorevi((int)lviSabahAtistirmasiList.SelectedItems[0].Tag, (int)cbxSabahAtistirmasi.SelectedValue, (double)nudSabahAtistirmasiPorsiyon.Value);
                if (güncellediMi)
                {
                    MessageBox.Show("Güncellendi");
                    helper.ListViewYazdirma(id, Ogunler.SabahAtistirmasi, lviSabahAtistirmasiList);
                    helper.EkleAktif(btnSabahAtistirmasiEkle, btnSabahAtistirmasiGuncelle, btnSabahAtistirmasiSil);
                }
                else MessageBox.Show("Bir hata olustu güncellenemdi.");
            }
        }
        private void btnOglenYemegiGuncelle_Click(object sender, EventArgs e)
        {
            if (lviOglenYemegiList.SelectedItems.Count > 0)
            {
                bool güncellediMi = helper.BtnGuncelleGorevi((int)lviOglenYemegiList.SelectedItems[0].Tag, (int)cbxOglenYemegi.SelectedValue, (double)nudOglenYemegiPorsiyon.Value);
                if (güncellediMi)
                {
                    MessageBox.Show("Güncellendi");
                    helper.ListViewYazdirma(id, Ogunler.OglenYemegi, lviOglenYemegiList);
                    helper.EkleAktif(btnOglenYemegiEkle, btnOglenYemegiGuncelle, btnOglenYemegiSil);
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
                    helper.EkleAktif(btnOglenYemegiEkle, btnOglenYemegiGuncelle, btnOglenYemegiSil);
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
                    helper.EkleAktif(btnOglenAtistirmasiEkle, btnOglenAtistirmasiGuncelle, btnOglenAtistirmasiSil);
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
                if (güncellediMi)
                {
                    MessageBox.Show("Güncellendi");
                    helper.ListViewYazdirma(id, Ogunler.OglenAtistirmasi, lviOglenAtistirmasiList);
                    helper.EkleAktif(btnOglenAtistirmasiEkle, btnOglenAtistirmasiGuncelle, btnOglenAtistirmasiSil);
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
                    helper.EkleAktif(btnAksamYemegiEkle, btnAksamYemegiGuncelle, btnAksamYemegiSil);
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
                if (güncellediMi)
                {
                    MessageBox.Show("Güncellendi");
                    helper.ListViewYazdirma(id, Ogunler.AksamYemegi, lviAksamYemegiList);
                    helper.EkleAktif(btnAksamYemegiEkle, btnAksamYemegiGuncelle, btnAksamYemegiSil);
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
                    helper.EkleAktif(btnAksamAtistirmasiEkle, btnAksamAtistirmasiGuncelle, btnAksamAtistirmasiSil);
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
                if (güncellediMi)
                {
                    MessageBox.Show("Güncellendi");
                    helper.ListViewYazdirma(id, Ogunler.AksamAtistirmasi, lviAksamAtistirmasiList);
                    helper.EkleAktif(btnAksamAtistirmasiEkle, btnAksamAtistirmasiGuncelle, btnAksamAtistirmasiSil);
                }
                else
                    MessageBox.Show("Bir hata olustu güncellenemdi.");
            }
        }
        private void BtnBoyKiloGüncelle_Click(object sender, EventArgs e)
        {
            var kullanici = bll.Kullanicilar.Ara(id);
            if (int.Parse(mtxtBoyDegis.Text) < 50 || int.Parse(mtxtBoyDegis.Text) > 290)
            {
                MessageBox.Show("Boy değeri geçerli aralıkta olmalıdır (50cm - 290cm)");
            }
            else if (int.Parse(mtxtKiloDegis.Text) < 30 || int.Parse(mtxtKiloDegis.Text) > 597)
            {
                MessageBox.Show("Kilo değeri geçerli aralıkta olmalıdır (30kg - 597kg)");
            }
            else
            {
                kullanici.Boy = int.Parse(mtxtBoyDegis.Text);
                kullanici.Kilo = int.Parse(mtxtKiloDegis.Text);
                bool kontrol = bll.Kullanicilar.Guncelle(kullanici);
                if (kontrol)
                {
                    MessageBox.Show("bilgileriniz güncellendi");


                }
                else
                {
                    MessageBox.Show("bilgileriniz güncellenirken hata oluştu");
                }
            }
        }

        private void lvSabahKahvaltiListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSabahKahvaltiListe.SelectedItems.Count == 0)
            {
                helper.EkleAktif(btnKahvaltıEkle, btnKahvaltiGuncelle, btnKahvaltiSil);
            }
            else
            {
                helper.EklePasif(btnKahvaltıEkle, btnKahvaltiGuncelle, btnKahvaltiSil);
            }
        }

        private void lviSabahAtistirmasiList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lviSabahAtistirmasiList.SelectedItems.Count == 0)
            {
                helper.EkleAktif(btnSabahAtistirmasiEkle, btnSabahAtistirmasiGuncelle, btnSabahAtistirmasiSil);
            }
            else
            {
                helper.EklePasif(btnSabahAtistirmasiEkle, btnSabahAtistirmasiGuncelle, btnSabahAtistirmasiSil);
            }
        }

        private void lviOglenYemegiList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lviOglenYemegiList.SelectedItems.Count == 0)
            {
                helper.EkleAktif(btnOglenYemegiEkle, btnOglenYemegiGuncelle, btnOglenYemegiSil);
            }
            else
            {
                helper.EklePasif(btnOglenYemegiEkle, btnOglenYemegiGuncelle, btnOglenYemegiSil);
            }
        }

        private void lviOglenAtistirmasiList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lviOglenAtistirmasiList.SelectedItems.Count == 0)
            {
                helper.EkleAktif(btnOglenAtistirmasiEkle, btnOglenAtistirmasiGuncelle, btnOglenAtistirmasiSil);
            }
            else
            {
                helper.EklePasif(btnOglenAtistirmasiEkle, btnOglenAtistirmasiGuncelle, btnOglenAtistirmasiSil);
            }
        }

        private void lviAksamYemegiList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lviAksamYemegiList.SelectedItems.Count == 0)
            {
                helper.EkleAktif(btnAksamYemegiEkle, btnAksamYemegiGuncelle, btnAksamYemegiSil);
            }
            else
            {
                helper.EklePasif(btnAksamYemegiEkle, btnAksamYemegiGuncelle, btnAksamYemegiSil);
            }
        }

        private void lviAksamAtistirmasiList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lviAksamAtistirmasiList.SelectedItems.Count == 0)
            {
                helper.EkleAktif(btnAksamAtistirmasiEkle, btnAksamAtistirmasiGuncelle, btnAksamAtistirmasiSil);
            }
            else
            {
                helper.EklePasif(btnAksamAtistirmasiEkle, btnAksamAtistirmasiGuncelle, btnAksamAtistirmasiSil);
            }
        }

    }
}
