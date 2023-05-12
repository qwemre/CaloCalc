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
            llblKaloriInternet.BackColor = Color.Transparent;
            llblKaloriInternet.Font = new Font("Palatino Linotype", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            llblKaloriInternet.ForeColor = Color.DarkOrange;
            llblKaloriInternet.LinkColor = Color.Red;
            llblKaloriInternet.Location = new Point(202, 201);
            llblKaloriInternet.Name = "llblKaloriInternet";
            llblKaloriInternet.Size = new Size(194, 18);
            llblKaloriInternet.TabIndex = 47;
            llblKaloriInternet.TabStop = true;
            llblKaloriInternet.Text = "Kalorisini Bilmiyor Musunuz ?";
            llblKaloriInternet.LinkClicked += llblKaloriInternet_LinkClicked;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.Transparent;
            btnKaydet.BackgroundImageLayout = ImageLayout.None;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnKaydet.Location = new Point(280, 248);
            btnKaydet.Margin = new Padding(3, 4, 3, 4);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(225, 64);
            btnKaydet.TabIndex = 46;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // mtxtKalori
            // 
            mtxtKalori.Location = new Point(202, 149);
            mtxtKalori.Margin = new Padding(3, 4, 3, 4);
            mtxtKalori.Mask = "0000";
            mtxtKalori.Name = "mtxtKalori";
            mtxtKalori.Size = new Size(189, 25);
            mtxtKalori.TabIndex = 45;
            mtxtKalori.Text = "0";
            // 
            // pbxYiyecek
            // 
            pbxYiyecek.BackColor = Color.WhiteSmoke;
            pbxYiyecek.Location = new Point(474, 27);
            pbxYiyecek.Margin = new Padding(3, 4, 3, 4);
            pbxYiyecek.Name = "pbxYiyecek";
            pbxYiyecek.Size = new Size(201, 90);
            pbxYiyecek.TabIndex = 44;
            pbxYiyecek.TabStop = false;
            // 
            // txtYemekAdi
            // 
            txtYemekAdi.Location = new Point(202, 27);
            txtYemekAdi.Margin = new Padding(3, 4, 3, 4);
            txtYemekAdi.Name = "txtYemekAdi";
            txtYemekAdi.Size = new Size(189, 25);
            txtYemekAdi.TabIndex = 43;
            // 
            // cbxKategori
            // 
            cbxKategori.FormattingEnabled = true;
            cbxKategori.Location = new Point(202, 91);
            cbxKategori.Margin = new Padding(3, 4, 3, 4);
            cbxKategori.Name = "cbxKategori";
            cbxKategori.Size = new Size(189, 26);
            cbxKategori.TabIndex = 41;
            // 
            // btnResimEkle
            // 
            btnResimEkle.BackColor = Color.Transparent;
            btnResimEkle.FlatStyle = FlatStyle.Flat;
            btnResimEkle.Font = new Font("Palatino Linotype", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnResimEkle.Location = new Point(519, 141);
            btnResimEkle.Margin = new Padding(3, 4, 3, 4);
            btnResimEkle.Name = "btnResimEkle";
            btnResimEkle.Size = new Size(115, 33);
            btnResimEkle.TabIndex = 40;
            btnResimEkle.Text = "Resim Ekle";
            btnResimEkle.UseVisualStyleBackColor = false;
            btnResimEkle.Click += btnResimEkle_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(126, 150);
            label4.Name = "label4";
            label4.Size = new Size(68, 24);
            label4.TabIndex = 36;
            label4.Text = "Kalori:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(106, 92);
            label2.Name = "label2";
            label2.Size = new Size(88, 24);
            label2.TabIndex = 38;
            label2.Text = "Kategori:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(95, 28);
            label1.Name = "label1";
            label1.Size = new Size(106, 24);
            label1.TabIndex = 39;
            label1.Text = "Yemek Adı:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // BesinOlusturma
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.besin2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(737, 500);
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
            Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
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