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
        Yiyecek yiyecek;
        //Ogun ogun;
        //Ogun ogun1;
        //Ogun ogun2;
        //Ogun ogun3;
        //Ogun ogun4;
        //Ogun ogun5;
        DateTime lastUpdate = DateTime.Parse("2023-05-10"); // örnek bir tarih
        CaloCalc.Helper.Methods helper = new();
        public AnaEkran(int ıd)
        {
            InitializeComponent();
            this.id = ıd;

            //ogun = new Ogun();

            if (DateTime.Now.Subtract(lastUpdate).TotalDays >= 1)
            {
                
            }


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

            helper.ListViewYazdirma(id, Ogunler.Kahvaltı, lvSabahKahvaltiListe);
            helper.ListViewYazdirma(id, Ogunler.Kahvaltı, lvSabahKahvaltiListe);
            helper.ListViewYazdirma(id, Ogunler.Kahvaltı, lvSabahKahvaltiListe);
            helper.ListViewYazdirma(id, Ogunler.Kahvaltı, lvSabahKahvaltiListe);
            helper.ListViewYazdirma(id, Ogunler.Kahvaltı, lvSabahKahvaltiListe);
            helper.ListViewYazdirma(id, Ogunler.Kahvaltı, lvSabahKahvaltiListe);


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

        Ogun ogun;
        private void btnKahvaltıEkle_Click(object sender, EventArgs e)
        {
            ogun=new();
            yiyecek = bll.Yiyecekler.Ara((int)cbxSabahKahvaltısı.SelectedValue);
            ogun.KullaniciID = id;
            ogun.YiyecekID = yiyecek.YiyecekID;
            ogun.OgunAdi = Ogunler.Kahvaltı;
            ogun.PorsiyonAdet = (double)nudKahvaltiPorsiyon.Value;
            ogun.YemekYemeZamani = DateTime.Now;
            ogun.OgunAdi = Ogunler.Kahvaltı;
            ogun.ToplamKalori = (yiyecek.Kalori * ogun.PorsiyonAdet);
            bool kontrol = bll.Ogunler.Ekle(ogun);
            if (kontrol)
            {
                helper.ListViewYazdirma(id, Ogunler.Kahvaltı, lvSabahKahvaltiListe);
                MessageBox.Show("Eklendi");
                bll = new CaloCalcBussinessLogic();

            }

        }

        private void btnKahvaltiOgunSil_Click(object sender, EventArgs e)
        {

        }



    }




}
