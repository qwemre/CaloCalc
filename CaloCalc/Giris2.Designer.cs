namespace CaloCalc
{
    partial class Giris2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris2));
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtSifre = new TextBox();
            txtEMail = new TextBox();
            btnGiris = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnGiris);
            panel1.Controls.Add(txtEMail);
            panel1.Controls.Add(txtSifre);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(423, 415);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Consolas", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(139, 90);
            label1.Name = "label1";
            label1.Size = new Size(179, 37);
            label1.TabIndex = 0;
            label1.Text = "Giriş Yap";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(54, 162);
            label2.Name = "label2";
            label2.Size = new Size(64, 18);
            label2.TabIndex = 1;
            label2.Text = "E-Mail:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(62, 194);
            label3.Name = "label3";
            label3.Size = new Size(56, 18);
            label3.TabIndex = 1;
            label3.Text = "Şifre:";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(124, 194);
            txtSifre.Multiline = true;
            txtSifre.Name = "txtSifre";
            txtSifre.PlaceholderText = "Şifreniz";
            txtSifre.Size = new Size(203, 26);
            txtSifre.TabIndex = 2;
            // 
            // txtEMail
            // 
            txtEMail.Location = new Point(124, 161);
            txtEMail.Multiline = true;
            txtEMail.Name = "txtEMail";
            txtEMail.PlaceholderText = "E-Mail Adresiniz";
            txtEMail.Size = new Size(203, 26);
            txtEMail.TabIndex = 2;
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.ForestGreen;
            btnGiris.FlatStyle = FlatStyle.Flat;
            btnGiris.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGiris.ForeColor = SystemColors.ButtonHighlight;
            btnGiris.Location = new Point(140, 236);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(160, 42);
            btnGiris.TabIndex = 3;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = false;
            // 
            // Giris2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 415);
            Controls.Add(panel1);
            Name = "Giris2";
            Text = "Giris2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnGiris;
        private TextBox txtEMail;
        private TextBox txtSifre;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}