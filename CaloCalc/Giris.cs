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
        private void button1_Click(object sender, EventArgs e)
        {
            bussinessLogic = new CaloCalcBussinessLogic();

            if (string.IsNullOrWhiteSpace(txtEMail.Text) || string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Lütfen E-mail adresinizi ve şifrenizi giriniz!", "Uyarı");
            }
            else
            {
                if (bussinessLogic.Kullanicilar.KullaniciGiris(txtEMail.Text, txtSifre.Text) > 0)
                {
                    this.Hide();
                    AnaEkran anaEkran = new AnaEkran();
                    anaEkran.ShowDialog();
                    this.Visible=true;
                }

                else
                {
                    MessageBox.Show("E-mail adresiniz ya da şifreniz yanlış!");
                }

            }
        }
    }
}
