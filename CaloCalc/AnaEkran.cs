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

namespace CaloCalc
{
    public partial class AnaEkran : Form
    {
        int id;
        Yiyecek yiyecek;
        Ogun ogun;
        Ogun ogun1;
        Ogun ogun2;
        Ogun ogun3;
        Ogun ogun4;
        Ogun ogun5;
        DateTime lastUpdate = DateTime.Parse("2023-05-10"); // örnek bir tarih

        public AnaEkran(int ıd)
        {
            InitializeComponent();
            this.id = ıd;


            if (DateTime.Now.Subtract(lastUpdate).TotalDays >= 1)
            {
                ogun = new Ogun() { OgunAdi = Ogunler.Kahvaltı };
                ogun1 = new Ogun() { OgunAdi = Ogunler.SabahAtistirmasi };
                ogun2 = new Ogun() { OgunAdi = Ogunler.OglenYemegi };
                ogun3 = new Ogun() { OgunAdi = Ogunler.OglenAtistirmasi };
                ogun4 = new Ogun() { OgunAdi = Ogunler.AksamYemegi };
                ogun5 = new Ogun() { OgunAdi = Ogunler.AksamAtistirmasi };
                lastUpdate = DateTime.Now;
            }
            yiyecek = new Yiyecek();

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

            cbxSabahKahvaltısı.DataSource = bll.Yiyecekler.Liste();
            cbxSabahKahvaltısı.DisplayMember = "YiyecekAdi";
            cbxSabahKahvaltısı.ValueMember = "YiyecekID";

            cbxSabahAtistirmasi.DataSource = bll.Yiyecekler.Liste();
            cbxSabahAtistirmasi.DisplayMember = "YiyecekAdi";
            cbxSabahAtistirmasi.ValueMember = "YiyecekID";

            cbxOglenYemegi.DataSource = bll.Yiyecekler.Liste();
            cbxOglenYemegi.DisplayMember = "YiyecekAdi";
            cbxOglenYemegi.ValueMember = "YiyecekID";

            cbxOglenAtistirmasi.DataSource = bll.Yiyecekler.Liste();
            cbxOglenAtistirmasi.DisplayMember = "YiyecekAdi";
            cbxOglenAtistirmasi.ValueMember = "YiyecekID";

            cbxAksamYemegi.DataSource = bll.Yiyecekler.Liste();
            cbxAksamYemegi.DisplayMember = "YiyecekAdi";
            cbxAksamYemegi.ValueMember = "YiyecekID";

            cbxAksamAtistirmasi.DataSource = bll.Yiyecekler.Liste();
            cbxAksamAtistirmasi.DisplayMember = "YiyecekAdi";
            cbxAksamAtistirmasi.ValueMember = "YiyecekID";

            //dgvKahvaltiListe.DataSource = bll.Kullanicilar.OguneGoreYenenYemekRaporu(id, Ogunler.Kahvaltı);
            //dgvSabahAtistirmaListe.DataSource = bll.Kullanicilar.OguneGoreYenenYemekRaporu(id, Ogunler.SabahAtistirmasi);
            //dgvOglenYemegiListe.DataSource = bll.Kullanicilar.OguneGoreYenenYemekRaporu(id, Ogunler.OglenYemegi);
            //dgvOglenAtistirmasiListe.DataSource = bll.Kullanicilar.OguneGoreYenenYemekRaporu(id, Ogunler.OglenAtistirmasi);
            //dgvAksamYemegiListe.DataSource = bll.Kullanicilar.OguneGoreYenenYemekRaporu(id, Ogunler.AksamYemegi);
            //dgvAksamAtistirmasiListe.DataSource = bll.Kullanicilar.OguneGoreYenenYemekRaporu(id, Ogunler.AksamAtistirmasi);

        }
        private void btnBesinEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            BesinOlusturma frm = new BesinOlusturma();
            frm.ShowDialog();
            this.Visible = true;
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }


        private void btnKahvaltıEkle_Click(object sender, EventArgs e)
        {

            yiyecek = bll.Yiyecekler.Ara((int)cbxSabahKahvaltısı.SelectedValue);
            ogun.KullaniciID = id;
            ogun.Yiyecekler.Add(yiyecek);
            ogun.PorsiyonAdet = (double)nudKahvaltiPorsiyon.Value;
            ogun.YemekYemeZamani = DateTime.Now;
            ogun.OgunAdi = Ogunler.Kahvaltı;
            ogun.ToplamKalori = (yiyecek.Kalori * ogun.PorsiyonAdet);
            bool kontrol = bll.Ogunler.Ekle(ogun);
            if (kontrol)
            {
                MessageBox.Show("eklendi");
                var ogun1 = bll.Ogunler.Fıfo(id, Ogunler.Kahvaltı);
                if (ogun1 != null)
                {
                    foreach (var yemek in ogun1)
                    {
                        ListViewItem lvi = new ListViewItem();
                        foreach (var item in yemek.Yiyecekler)
                        {
                            lvi.Text = item.YiyecekAdi.ToString();
                            lvi.SubItems.Add(item.Kalori.ToString());
                            lvi.SubItems.Add(item.Ogun.PorsiyonAdet.ToString());
                            lvi.SubItems.Add((item.Ogun.PorsiyonAdet * item.Kalori).ToString());
                        }
                    }
                }

            }

        }
        private void btnKahvaltiOgunSil_Click(object sender, EventArgs e)
        {

        }
    }




}
