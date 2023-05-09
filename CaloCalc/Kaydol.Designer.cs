namespace CaloCalc
{
    partial class Kaydol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kaydol));
            panel1 = new Panel();
            label9 = new Label();
            mtxtKilo = new MaskedTextBox();
            mtxtBoy = new MaskedTextBox();
            mtxtYas = new MaskedTextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            txtSifreTekrar = new TextBox();
            txtSifre = new TextBox();
            txtMail = new TextBox();
            btnKaydol = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(mtxtKilo);
            panel1.Controls.Add(mtxtBoy);
            panel1.Controls.Add(mtxtYas);
            panel1.Controls.Add(txtSoyad);
            panel1.Controls.Add(txtAd);
            panel1.Controls.Add(txtSifreTekrar);
            panel1.Controls.Add(txtSifre);
            panel1.Controls.Add(txtMail);
            panel1.Controls.Add(btnKaydol);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(459, 546);
            panel1.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Location = new Point(75, 433);
            label9.Name = "label9";
            label9.Size = new Size(33, 15);
            label9.TabIndex = 20;
            label9.Text = "Kilo :";
            // 
            // mtxtKilo
            // 
            mtxtKilo.Location = new Point(175, 430);
            mtxtKilo.Mask = "000";
            mtxtKilo.Name = "mtxtKilo";
            mtxtKilo.Size = new Size(209, 23);
            mtxtKilo.TabIndex = 19;
            mtxtKilo.ValidatingType = typeof(int);
            // 
            // mtxtBoy
            // 
            mtxtBoy.Location = new Point(175, 380);
            mtxtBoy.Mask = "000";
            mtxtBoy.Name = "mtxtBoy";
            mtxtBoy.Size = new Size(209, 23);
            mtxtBoy.TabIndex = 18;
            mtxtBoy.ValidatingType = typeof(int);
            // 
            // mtxtYas
            // 
            mtxtYas.Location = new Point(175, 330);
            mtxtYas.Mask = "000";
            mtxtYas.Name = "mtxtYas";
            mtxtYas.Size = new Size(209, 23);
            mtxtYas.TabIndex = 17;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(175, 280);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.PlaceholderText = "Soyadınız";
            txtSoyad.Size = new Size(209, 23);
            txtSoyad.TabIndex = 13;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(175, 230);
            txtAd.Name = "txtAd";
            txtAd.PlaceholderText = "Adınız";
            txtAd.Size = new Size(209, 23);
            txtAd.TabIndex = 12;
            // 
            // txtSifreTekrar
            // 
            txtSifreTekrar.Location = new Point(175, 130);
            txtSifreTekrar.Name = "txtSifreTekrar";
            txtSifreTekrar.PlaceholderText = "Şifrenizi Tekrar Giriniz";
            txtSifreTekrar.Size = new Size(209, 23);
            txtSifreTekrar.TabIndex = 11;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(175, 80);
            txtSifre.Name = "txtSifre";
            txtSifre.PlaceholderText = "Şifrenizi Giriniz";
            txtSifre.Size = new Size(209, 23);
            txtSifre.TabIndex = 10;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(175, 30);
            txtMail.Name = "txtMail";
            txtMail.PlaceholderText = "E-Mail Adresini Giriniz";
            txtMail.Size = new Size(209, 23);
            txtMail.TabIndex = 9;
            // 
            // btnKaydol
            // 
            btnKaydol.BackColor = Color.FromArgb(0, 192, 0);
            btnKaydol.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnKaydol.ForeColor = SystemColors.ButtonFace;
            btnKaydol.Location = new Point(175, 480);
            btnKaydol.Name = "btnKaydol";
            btnKaydol.Size = new Size(209, 39);
            btnKaydol.TabIndex = 8;
            btnKaydol.Text = "KAYDOL";
            btnKaydol.UseVisualStyleBackColor = false;
            btnKaydol.Click += btnKaydol_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Location = new Point(75, 383);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 7;
            label8.Text = "Boy :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(75, 333);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 6;
            label7.Text = "Yaş :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(75, 283);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 5;
            label6.Text = "Soyad :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(75, 233);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 4;
            label5.Text = "Ad :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(75, 182);
            label4.Name = "label4";
            label4.Size = new Size(330, 25);
            label4.TabIndex = 3;
            label4.Text = "Lütfen Kişisel Bilgilerinizi Doldurunuz";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(75, 133);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 2;
            label3.Text = "Şifre Tekrar :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(75, 83);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Şifre :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(75, 33);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "E-Mail :";
            // 
            // Kaydol
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 546);
            Controls.Add(panel1);
            Name = "Kaydol";
            Text = "Kaydol";
            Load += Kaydol_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label9;
        private MaskedTextBox mtxtKilo;
        private MaskedTextBox mtxtBoy;
        private MaskedTextBox mtxtYas;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private TextBox txtSifreTekrar;
        private TextBox txtSifre;
        private TextBox txtMail;
        private Button btnKaydol;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}