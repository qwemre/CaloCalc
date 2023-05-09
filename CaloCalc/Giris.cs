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
                if (bussinessLogic.Kullanicilar.KullaniciGiris(txtMail.Text, txtSifre.Text) > 0)
                {
                    this.Hide();
                    AnaEkran anaEkran = new AnaEkran();
                    anaEkran.ShowDialog();
                    this.Visible = true;
                }
                else
                {
                    MessageBox.Show("E-mail adresiniz ya da şifreniz yanlış!");
                }
            }
        }
    }
}
