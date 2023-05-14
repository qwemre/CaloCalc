namespace CaloCalc
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            panel1 = new Panel();
            cbxSifreGozuksunMu = new CheckBox();
            txtSifre = new TextBox();
            txtMail = new TextBox();
            btnGiris = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(cbxSifreGozuksunMu);
            panel1.Controls.Add(txtSifre);
            panel1.Controls.Add(txtMail);
            panel1.Controls.Add(btnGiris);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(449, 414);
            panel1.TabIndex = 10;
            // 
            // cbxSifreGozuksunMu
            // 
            cbxSifreGozuksunMu.AutoSize = true;
            cbxSifreGozuksunMu.Location = new Point(140, 224);
            cbxSifreGozuksunMu.Name = "cbxSifreGozuksunMu";
            cbxSifreGozuksunMu.Size = new Size(95, 19);
            cbxSifreGozuksunMu.TabIndex = 4;
            cbxSifreGozuksunMu.Text = "Şifreyi Göster";
            cbxSifreGozuksunMu.UseVisualStyleBackColor = true;
            cbxSifreGozuksunMu.CheckedChanged += cbxSifreGozuksunMu_CheckedChanged;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(139, 189);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.PlaceholderText = "Şifre Giriniz";
            txtSifre.Size = new Size(179, 23);
            txtSifre.TabIndex = 1;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(140, 157);
            txtMail.Name = "txtMail";
            txtMail.PlaceholderText = "E-Mail Giriniz";
            txtMail.Size = new Size(178, 23);
            txtMail.TabIndex = 0;
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.ForestGreen;
            btnGiris.FlatStyle = FlatStyle.Flat;
            btnGiris.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGiris.ForeColor = SystemColors.ButtonHighlight;
            btnGiris.Location = new Point(140, 249);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(178, 42);
            btnGiris.TabIndex = 2;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(62, 194);
            label4.Name = "label4";
            label4.Size = new Size(56, 18);
            label4.TabIndex = 1;
            label4.Text = "Şifre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(54, 162);
            label5.Name = "label5";
            label5.Size = new Size(64, 18);
            label5.TabIndex = 1;
            label5.Text = "E-Mail:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Consolas", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(139, 90);
            label6.Name = "label6";
            label6.Size = new Size(179, 37);
            label6.TabIndex = 0;
            label6.Text = "Giriş Yap";
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 414);
            Controls.Add(panel1);
            Name = "Giris";
            Text = "Giris";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGiris;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Button button1;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtSifre;
        private TextBox txtMail;
        private CheckBox cbxSifreGozuksunMu;
    }
}