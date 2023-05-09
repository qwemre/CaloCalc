﻿using System;
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
        public BesinOlusturma()
        {
            InitializeComponent();
            bll = new CaloCalcBussinessLogic();
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
            Yiyecek yiyecek = new Yiyecek();
            yiyecek.YiyecekAdi = txtYemekAdi.Text;
            yiyecek.Kalori = double.Parse(mtxtKalori.Text);
            yiyecek.Porsiyon = 1;
            yiyecek.Kategori = (Kategori)cbxKategori.SelectedItem;
            yiyecek.FotografYolu = yol;
            yiyecek.Fotograf = File.ReadAllBytes(yol);
        }
        
    }
}
