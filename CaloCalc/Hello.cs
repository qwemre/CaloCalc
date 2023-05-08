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
    public partial class Hello : Form
    {
        public Hello()
        {
            InitializeComponent();
        }

        private void Hello_Load(object sender, EventArgs e)
        {

        }
        private void linklblGiris_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Giris frm= new Giris();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kaydol frm = new Kaydol();
            frm.ShowDialog();
            this.Visible = true;
        }

    }
}
