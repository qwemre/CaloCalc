using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaloCalc
{
    public partial class Kaydol : Form
    {
        public Kaydol()
        {
            InitializeComponent();
        }
        private void Kaydol_Load(object sender, EventArgs e)
        {
            kullanici = new();
        }
        Kullanici kullanici;
        CaloCalcBussinessLogic db;
        private void btnKaydol_Click(object sender, EventArgs e)
        {
            db = new CaloCalcBussinessLogic();
            bool kontrol = db.Kullanicilar.MailAra(txtMail.Text);
            if (kontrol)
            {
                MessageBox.Show("Mail Adresi Kayıtlı...\nLütfen farklı bir mail adresi giriniz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                kullanici.KullaniciMail = txtMail.Text;
                if (string.IsNullOrEmpty(txtMail.Text) || string.IsNullOrWhiteSpace(txtMail.Text) || string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text) || string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSifreTekrar.Text) || string.IsNullOrWhiteSpace(mtxtYas.Text) || string.IsNullOrWhiteSpace(mtxtBoy.Text) || string.IsNullOrWhiteSpace(mtxtKilo.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun", "Uyarı");

                }
                else if (!txtMail.Text.EndsWith("@gmail.com") && !txtMail.Text.EndsWith("@hotmail.com"))
                {
                    MessageBox.Show("Lütfen geçerli bir e-posta adresi girin!", "Uyarı");
                }
                else if (!Regex.IsMatch(txtSifre.Text, @"^(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{6,}$"))
                {
                    MessageBox.Show("Şifre en az 6 karakter uzunluğunda, bir büyük harf, bir özel karakter ve bir rakam içermelidir.", "Uyarı");
                }
                else if (txtSifre.Text != txtSifreTekrar.Text)
                {
                    MessageBox.Show("Şifreler farklı", "Uyarı");
                }
                else
                {
                    kullanici.Adi = txtAd.Text;
                    string sifre=txtSifre.Text;
                    kullanici.Sifre =HelperBLL.sha256_hash(sifre);
                    kullanici.Soyad = txtSoyad.Text;
                    kullanici.Yasi = int.Parse(mtxtYas.Text);
                    kullanici.Boy = int.Parse(mtxtBoy.Text);
                    kullanici.Kilo = int.Parse(mtxtKilo.Text);
                    bool eklendiMi = db.Kullanicilar.Ekle(kullanici);
                    if (eklendiMi)
                    {
                        MessageBox.Show("Başarılı bir şekilde kayıt oldunuz ", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Kaydolurken bir hata meydana geldi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        
    }
}
