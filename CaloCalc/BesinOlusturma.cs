using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace CaloCalc
{
    public partial class BesinOlusturma : Form
    {
        int id;
        public BesinOlusturma(int id)
        {
            InitializeComponent();
            bll = new CaloCalcBussinessLogic();
            this.id = id;
        }
        CaloCalcBussinessLogic bll;
        private void BesinOlusturma_Load(object sender, EventArgs e)
        {
            cbxKategori.DataSource = bll.Kategoriler.Liste();
            cbxKategori.DisplayMember = "KategoriAdi";
            cbxKategori.ValueMember = "KategoriID";
        }
        string yol;
        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            yol = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.gif)|*.jpg; *.jpeg; *.png; *.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbxYiyecek.Image = new Bitmap(openFileDialog.FileName);
                pbxYiyecek.SizeMode = PictureBoxSizeMode.StretchImage;
                yol = openFileDialog.FileName;
            }
        }
        private void llblKaloriInternet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "https://turkomp.gov.tr/main");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var yiyecekKontrol = bll.Yiyecekler.AdaGoreAra(txtYemekAdi.Text);
            if (string.IsNullOrEmpty(txtYemekAdi.Text) || string.IsNullOrWhiteSpace(cbxKategori.Text) || string.IsNullOrWhiteSpace(mtxtKalori.Text)||yol==null)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Uyarı");
            }
            else if (int.Parse(mtxtKalori.Text)<50)
            {
                MessageBox.Show("Kalori değeri en az 50 olabilir");
            }
            else if (yiyecekKontrol is not null)
            {
                MessageBox.Show("Eklemeye çalıştığınız yiyecek zaten mevcut", "Uyarı");
            }
            else
            {
                Yiyecek yiyecek = new Yiyecek();
                yiyecek.YiyecekAdi = txtYemekAdi.Text;
                yiyecek.Kalori = double.Parse(mtxtKalori.Text);
                yiyecek.KategoriID = (int)cbxKategori.SelectedValue;
                yiyecek.FotografYolu = yol;
                yiyecek.Fotograf = File.ReadAllBytes(yol);
                bool eklendiMi = bll.Yiyecekler.Ekle(yiyecek);
                if (eklendiMi)
                {
                    this.Hide();
                    this.Close();
                    MessageBox.Show("Başarılı bir şekilde ekleme yaptınız.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AnaEkran anaEkran = new AnaEkran(id);
                    anaEkran.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Yiyecek eklerken bir hata meydana geldi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BesinOlusturma_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            this.Close();
            AnaEkran anaEkran = new AnaEkran(id);
            anaEkran.ShowDialog();
        }


    }
}
