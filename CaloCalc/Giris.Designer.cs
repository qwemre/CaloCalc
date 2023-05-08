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
            txtSifreGİris = new TextBox();
            txtMailGiris = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnGiriş = new Button();
            SuspendLayout();
            // 
            // txtSifreGİris
            // 
            txtSifreGİris.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSifreGİris.Location = new Point(164, 82);
            txtSifreGİris.Name = "txtSifreGİris";
            txtSifreGİris.Size = new Size(372, 29);
            txtSifreGİris.TabIndex = 10;
            // 
            // txtMailGiris
            // 
            txtMailGiris.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMailGiris.Location = new Point(164, 32);
            txtMailGiris.Name = "txtMailGiris";
            txtMailGiris.Size = new Size(372, 29);
            txtMailGiris.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(32, 87);
            label2.Name = "label2";
            label2.Size = new Size(37, 19);
            label2.TabIndex = 8;
            label2.Text = "Şifre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(32, 37);
            label1.Name = "label1";
            label1.Size = new Size(36, 19);
            label1.TabIndex = 7;
            label1.Text = "Mail";
            // 
            // btnGiriş
            // 
            btnGiriş.Location = new Point(164, 136);
            btnGiriş.Name = "btnGiriş";
            btnGiriş.Size = new Size(372, 35);
            btnGiriş.TabIndex = 11;
            btnGiriş.Text = "Giriş";
            btnGiriş.UseVisualStyleBackColor = true;
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(561, 199);
            Controls.Add(btnGiriş);
            Controls.Add(txtSifreGİris);
            Controls.Add(txtMailGiris);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Giris";
            Text = "Giris";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSifreGİris;
        private TextBox txtMailGiris;
        private Label label2;
        private Label label1;
        private Button btnGiriş;
    }
}