namespace CaloCalc
{
    partial class Hello
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
            label1 = new Label();
            linklblGiris = new LinkLabel();
            btnKaydol = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(56, 396);
            label1.Name = "label1";
            label1.Size = new Size(146, 25);
            label1.TabIndex = 5;
            label1.Text = "Hesabın var mı?";
            // 
            // linklblGiris
            // 
            linklblGiris.AccessibleRole = AccessibleRole.TitleBar;
            linklblGiris.ActiveLinkColor = Color.DarkGray;
            linklblGiris.AutoSize = true;
            linklblGiris.BackColor = Color.Transparent;
            linklblGiris.BorderStyle = BorderStyle.FixedSingle;
            linklblGiris.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            linklblGiris.LinkColor = Color.Red;
            linklblGiris.Location = new Point(208, 396);
            linklblGiris.Name = "linklblGiris";
            linklblGiris.Size = new Size(52, 27);
            linklblGiris.TabIndex = 4;
            linklblGiris.TabStop = true;
            linklblGiris.Text = "Giriş";
            linklblGiris.LinkClicked += linklblGiris_LinkClicked;
            // 
            // btnKaydol
            // 
            btnKaydol.BackColor = Color.Transparent;
            btnKaydol.BackgroundImage = Properties.Resources.arka_plan;
            btnKaydol.BackgroundImageLayout = ImageLayout.Center;
            btnKaydol.FlatStyle = FlatStyle.Flat;
            btnKaydol.Font = new Font("Ink Free", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnKaydol.ForeColor = Color.Transparent;
            btnKaydol.Location = new Point(60, 320);
            btnKaydol.Name = "btnKaydol";
            btnKaydol.Size = new Size(200, 73);
            btnKaydol.TabIndex = 3;
            btnKaydol.Text = "Kaydol ve Başla";
            btnKaydol.UseVisualStyleBackColor = false;
            btnKaydol.Click += btnKaydol_Click;
            // 
            // Hello
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backround;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(584, 761);
            Controls.Add(label1);
            Controls.Add(linklblGiris);
            Controls.Add(btnKaydol);
            Name = "Hello";
            Text = "Hello";
            Load += Hello_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private LinkLabel linklblGiris;
        private Button btnKaydol;
    }
}