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

namespace CaloCalc
{
    public partial class AnaEkran : Form
    {
        int id;
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


        }

        private void btnKahvaltiOgunSil_Click(object sender, EventArgs e)
        {

        }
    }
}
