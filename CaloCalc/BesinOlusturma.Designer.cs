namespace CaloCalc
{
    partial class BesinOlusturma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            llblKaloriInternet = new LinkLabel();
            btnKaydet = new Button();
            mtxtKalori = new MaskedTextBox();
            pbxYiyecek = new PictureBox();
            txtYemekAdi = new TextBox();
            cbxKategori = new ComboBox();
            btnResimEkle = new Button();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbxYiyecek).BeginInit();
            SuspendLayout();
            // 
            // llblKaloriInternet
            // 
            llblKaloriInternet.AutoSize = true;
            llblKaloriInternet.Location = new Point(343, 216);
            llblKaloriInternet.Name = "llblKaloriInternet";
            llblKaloriInternet.Size = new Size(162, 15);
            llblKaloriInternet.TabIndex = 47;
            llblKaloriInternet.TabStop = true;
            llblKaloriInternet.Text = "Kalorisini Bilmiyor Musunuz ?";
            llblKaloriInternet.LinkClicked += llblKaloriInternet_LinkClicked;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(405, 309);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(75, 23);
            btnKaydet.TabIndex = 46;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // mtxtKalori
            // 
            mtxtKalori.Location = new Point(395, 174);
            mtxtKalori.Mask = "0000";
            mtxtKalori.Name = "mtxtKalori";
            mtxtKalori.Size = new Size(100, 23);
            mtxtKalori.TabIndex = 45;
            // 
            // pbxYiyecek
            // 
            pbxYiyecek.Location = new Point(395, 234);
            pbxYiyecek.Name = "pbxYiyecek";
            pbxYiyecek.Size = new Size(100, 50);
            pbxYiyecek.TabIndex = 44;
            pbxYiyecek.TabStop = false;
            // 
            // txtYemekAdi
            // 
            txtYemekAdi.Location = new Point(395, 72);
            txtYemekAdi.Name = "txtYemekAdi";
            txtYemekAdi.Size = new Size(100, 23);
            txtYemekAdi.TabIndex = 43;
            // 
            // cbxKategori
            // 
            cbxKategori.FormattingEnabled = true;
            cbxKategori.Location = new Point(395, 125);
            cbxKategori.Name = "cbxKategori";
            cbxKategori.Size = new Size(100, 23);
            cbxKategori.TabIndex = 41;
            // 
            // btnResimEkle
            // 
            btnResimEkle.Location = new Point(297, 261);
            btnResimEkle.Name = "btnResimEkle";
            btnResimEkle.Size = new Size(75, 23);
            btnResimEkle.TabIndex = 40;
            btnResimEkle.Text = "Resim Ekle";
            btnResimEkle.UseVisualStyleBackColor = true;
            btnResimEkle.Click += btnResimEkle_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(306, 182);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 36;
            label4.Text = "Kalori";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(297, 128);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 38;
            label2.Text = "Kategori";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(297, 80);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 39;
            label1.Text = "Yemek Adı";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // BesinOlusturma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(llblKaloriInternet);
            Controls.Add(btnKaydet);
            Controls.Add(mtxtKalori);
            Controls.Add(pbxYiyecek);
            Controls.Add(txtYemekAdi);
            Controls.Add(cbxKategori);
            Controls.Add(btnResimEkle);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BesinOlusturma";
            Text = "BesinOlusturma";
            FormClosed += BesinOlusturma_FormClosed;
            Load += BesinOlusturma_Load;
            ((System.ComponentModel.ISupportInitialize)pbxYiyecek).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel llblKaloriInternet;
        private Button btnKaydet;
        private MaskedTextBox mtxtKalori;
        private PictureBox pbxYiyecek;
        private TextBox txtYemekAdi;
        private ComboBox cbxKategori;
        private Button btnResimEkle;
        private Label label4;
        private Label label2;
        private Label label1;
        private OpenFileDialog openFileDialog1;
    }
}