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
            nudPorsiyon = new NumericUpDown();
            cbxKategori = new ComboBox();
            btnResimEkle = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbxYiyecek).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPorsiyon).BeginInit();
            SuspendLayout();
            // 
            // llblKaloriInternet
            // 
            llblKaloriInternet.AutoSize = true;
            llblKaloriInternet.Location = new Point(343, 249);
            llblKaloriInternet.Name = "llblKaloriInternet";
            llblKaloriInternet.Size = new Size(162, 15);
            llblKaloriInternet.TabIndex = 47;
            llblKaloriInternet.TabStop = true;
            llblKaloriInternet.Text = "Kalorisini Bilmiyor Musunuz ?";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(395, 355);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(75, 23);
            btnKaydet.TabIndex = 46;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            // 
            // mtxtKalori
            // 
            mtxtKalori.Location = new Point(395, 219);
            mtxtKalori.Mask = "0000";
            mtxtKalori.Name = "mtxtKalori";
            mtxtKalori.Size = new Size(100, 23);
            mtxtKalori.TabIndex = 45;
            // 
            // pbxYiyecek
            // 
            pbxYiyecek.Location = new Point(395, 267);
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
            // nudPorsiyon
            // 
            nudPorsiyon.DecimalPlaces = 1;
            nudPorsiyon.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nudPorsiyon.Location = new Point(395, 167);
            nudPorsiyon.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudPorsiyon.Minimum = new decimal(new int[] { 5, 0, 0, 65536 });
            nudPorsiyon.Name = "nudPorsiyon";
            nudPorsiyon.Size = new Size(100, 23);
            nudPorsiyon.TabIndex = 42;
            nudPorsiyon.Value = new decimal(new int[] { 1, 0, 0, 0 });
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
            btnResimEkle.Location = new Point(297, 294);
            btnResimEkle.Name = "btnResimEkle";
            btnResimEkle.Size = new Size(75, 23);
            btnResimEkle.TabIndex = 40;
            btnResimEkle.Text = "Resim Ekle";
            btnResimEkle.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(296, 227);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 36;
            label4.Text = "Kalori";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(296, 174);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 37;
            label3.Text = "Porsiyon Miktarı";
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
            Controls.Add(nudPorsiyon);
            Controls.Add(cbxKategori);
            Controls.Add(btnResimEkle);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BesinOlusturma";
            Text = "BesinOlusturma";
            ((System.ComponentModel.ISupportInitialize)pbxYiyecek).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPorsiyon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel llblKaloriInternet;
        private Button btnKaydet;
        private MaskedTextBox mtxtKalori;
        private PictureBox pbxYiyecek;
        private TextBox txtYemekAdi;
        private NumericUpDown nudPorsiyon;
        private ComboBox cbxKategori;
        private Button btnResimEkle;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}