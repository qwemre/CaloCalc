using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
                if (txtSifre.Text != txtSifreTekrar.Text)
                {
                    MessageBox.Show("Şifreler farklı");
                }
                else
                {
                    kullanici.Sifre = txtSifreTekrar.Text;
                    kullanici.Adi = txtAd.Text;
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
