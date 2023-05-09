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
            btnGiris = new Button();
            txtEMail = new TextBox();
            txtSifre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.ForestGreen;
            btnGiris.FlatStyle = FlatStyle.Flat;
            btnGiris.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGiris.ForeColor = SystemColors.ButtonHighlight;
            btnGiris.Location = new Point(350, 277);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(160, 42);
            btnGiris.TabIndex = 9;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = false;
            // 
            // txtEMail
            // 
            txtEMail.Location = new Point(334, 202);
            txtEMail.Multiline = true;
            txtEMail.Name = "txtEMail";
            txtEMail.PlaceholderText = "E-Mail Adresiniz";
            txtEMail.Size = new Size(203, 26);
            txtEMail.TabIndex = 7;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(334, 235);
            txtSifre.Multiline = true;
            txtSifre.Name = "txtSifre";
            txtSifre.PlaceholderText = "Şifreniz";
            txtSifre.Size = new Size(203, 26);
            txtSifre.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(272, 235);
            label3.Name = "label3";
            label3.Size = new Size(56, 18);
            label3.TabIndex = 5;
            label3.Text = "Şifre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(264, 203);
            label2.Name = "label2";
            label2.Size = new Size(64, 18);
            label2.TabIndex = 6;
            label2.Text = "E-Mail:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Consolas", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(349, 131);
            label1.Name = "label1";
            label1.Size = new Size(179, 37);
            label1.TabIndex = 4;
            label1.Text = "Giriş Yap";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(459, 436);
            panel1.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(140, 236);
            button1.Name = "button1";
            button1.Size = new Size(160, 42);
            button1.TabIndex = 3;
            button1.Text = "Giriş";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(124, 161);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "E-Mail Adresiniz";
            textBox1.Size = new Size(203, 26);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(124, 194);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Şifreniz";
            textBox2.Size = new Size(203, 26);
            textBox2.TabIndex = 2;
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
            ClientSize = new Size(459, 436);
            Controls.Add(panel1);
            Controls.Add(btnGiris);
            Controls.Add(txtEMail);
            Controls.Add(txtSifre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Giris";
            Text = "Giris";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGiris;
        private TextBox txtEMail;
        private TextBox txtSifre;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}