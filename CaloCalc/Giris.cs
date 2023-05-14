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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        CaloCalcBussinessLogic bussinessLogic;

        private void btnGiris_Click(object sender, EventArgs e)
        {

            bussinessLogic = new CaloCalcBussinessLogic();
            if (string.IsNullOrEmpty(txtMail.Text) || string.IsNullOrWhiteSpace(txtMail.Text))
            {
                MessageBox.Show("Lütfen geçerli bir E-mail adresi girin!", "Uyarı");
            }
            else if (string.IsNullOrEmpty(txtSifre.Text) || string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Lütfen şifrenizi girin!", "Uyarı");
            }
            else
            {
                Kullanici kullanici = bussinessLogic.Kullanicilar.MaileGoreAra(txtMail.Text);
                if (kullanici is not null)
                {
                    string sifre = txtSifre.Text;
                    string hashSifre = HelperBLL.sha256_hash(sifre);
                    if (kullanici.Sifre == hashSifre)
                    {
                        int ıd = kullanici.KullaniciID;
                        this.Hide();
                        AnaEkran anaEkran = new AnaEkran(ıd);
                        anaEkran.ShowDialog();
                        this.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("E-mail adresiniz ya da şifreniz yanlış!");
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı Bulunumadı");
                }
            }
        }

        private void cbxSifreGozuksunMu_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSifreGozuksunMu.Checked == true)
            {
                txtSifre.PasswordChar = '\0';
            }
            else if (cbxSifreGozuksunMu.Checked == false)
            {
                txtSifre.PasswordChar = '*';
            }
        }
    }
}
