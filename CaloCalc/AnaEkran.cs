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
        public AnaEkran(int ıd)
        {
            InitializeComponent();
            this.id = ıd;
            ogun = new Ogun();
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
        Ogun ogun;
        Yiyecek yiyecek;

        private void btnKahvaltıEkle_Click(object sender, EventArgs e)
        {
            //Yiyecek yiyecek = bll.Yiyecekler.Ara((int)cbxSabahKahvaltısı.SelectedValue);
            //ogun.KullaniciID = id;
            //ogun.YiyecekID = (int)cbxSabahKahvaltısı.SelectedValue;
            //ogun.PorsiyonAdet = (double)nudKahvaltiPorsiyon.Value;
            //ogun.YemekYemeZamani = DateTime.Now;

            //ogun.ToplamKalori = ogun.PorsiyonAdet * yiyecek.Kalori;
            //ogun.Yiyecekler.Add(yiyecek);
            //bool kontrol= bll.Ogunler.Ekle(ogun);

            //if (kontrol)
            //{
            //    MessageBox.Show("Test");
            //}
            //using (var context = new CaloCalcDbContext())
            //{
            //    var yiyecekler = context.Yiyecekler
            //        .Where(y => y.Ogunler.Any(o => o.KullaniciID == id))
            //        .Select(y => new
            //        {
            //            YiyecekAdi = y.YiyecekAdi,
            //            Kalori = y.Kalori,
            //            Porsiyon = y.Porsiyon
            //        })
            //        .ToList();

            //    foreach (var item in yiyecekler)
            //    {
            //        ListViewItem lvi = new ListViewItem();
            //        lvi.Text = item.YiyecekAdi;
            //        lvi.SubItems.Add(item.Kalori.ToString());
            //        lvi.SubItems.Add(item.Porsiyon.ToString());
            //        lvi.SubItems.Add((item.Porsiyon * item.Kalori).ToString());
            //        listView1.Items.Add(lvi);
            //    }
            //}

            //using (var context = new CaloCalcDbContext())
            //{

            //    var yiyecekler = context.Yiyecekler
            //        .Join(context.Ogunler,
            //              y => y.YiyecekID,
            //              o => o.OgunID,
            //              (y, o) => new
            //              {
            //                  y.YiyecekAdi,
            //                  y.Kalori,
            //                  y.Porsiyon,
            //                  o.OgunAdi,
            //                  o.YemekYemeZamani,
            //                  o.PorsiyonAdet,
            //                  o.ToplamKalori,
            //                  o.KullaniciID

            //              }).Where(x => x.KullaniciID == id)
            //        .ToList();
            //    foreach (var item in yiyecekler)
            //    {
            //        ListViewItem lvi = new ListViewItem();
            //        lvi.Text = item.YiyecekAdi;
            //        lvi.SubItems.Add(item.Kalori.ToString());
            //        lvi.SubItems.Add(item.Porsiyon.ToString());
            //        lvi.SubItems.Add((item.PorsiyonAdet * item.Kalori).ToString());

            //        listView1.Items.Add(lvi);
            //    }
            //}
            
            ogun.KullaniciID = id;
           // ogun.Kullanici = (int)cbxSabahKahvaltısı.SelectedValue;
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
                       //lvi.Text = yemek
                        //lvi.SubItems.Add(yemek.Yiyecekler.Kalori.ToString());
                        lvi.SubItems.Add(yemek.PorsiyonAdet.ToString());
                        //lvi.SubItems.Add((yemek.PorsiyonAdet * yemek.Yiyecekler.Kalori).ToString());
                        listView1.Items.Add(lvi);
                    }

                }
            }
            else
            {
                MessageBox.Show("eklenemedi");
            }
            //var ogun1 = bll.Ogunler.Fıfo(id, Ogunler.Kahvaltı);
            //if (ogun1 != null)
            //{
              
            //    foreach (var yemek in ogun1)
            //    {
            //        ListViewItem lvi = new ListViewItem();
            //        lvi.Text = yemek.Yiyecekler.YiyecekAdi;
            //        lvi.SubItems.Add(yemek.Yiyecekler.Kalori.ToString());  
            //        lvi.SubItems.Add(yemek.PorsiyonAdet.ToString());
            //        lvi.SubItems.Add((yemek.PorsiyonAdet * yemek.Yiyecekler.Kalori).ToString());
            //        listView1.Items.Add(lvi);
            //    }
              
            //}
        }

    private void btnKahvaltiOgunSil_Click(object sender, EventArgs e)
    {

    }
    }




}
