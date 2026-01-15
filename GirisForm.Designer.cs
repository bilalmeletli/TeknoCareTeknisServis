namespace MusteriIliskileriVeHizmetTalepYonetimi
{
    partial class GirisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisForm));
            this.kullaniciAdiTxt = new System.Windows.Forms.TextBox();
            this.sifreTxt = new System.Windows.Forms.TextBox();
            this.girisButon = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kullaniciAdiTxt
            // 
            this.kullaniciAdiTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciAdiTxt.Location = new System.Drawing.Point(169, 218);
            this.kullaniciAdiTxt.Name = "kullaniciAdiTxt";
            this.kullaniciAdiTxt.Size = new System.Drawing.Size(219, 22);
            this.kullaniciAdiTxt.TabIndex = 1;
            this.kullaniciAdiTxt.Enter += new System.EventHandler(this.kullaniciAdiTxt_Enter);
            this.kullaniciAdiTxt.Leave += new System.EventHandler(this.kullaniciAdiTxt_Leave);
            // 
            // sifreTxt
            // 
            this.sifreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreTxt.Location = new System.Drawing.Point(169, 287);
            this.sifreTxt.Name = "sifreTxt";
            this.sifreTxt.PasswordChar = '*';
            this.sifreTxt.Size = new System.Drawing.Size(219, 22);
            this.sifreTxt.TabIndex = 3;
            this.sifreTxt.Leave += new System.EventHandler(this.sifreTxt_Leave);
            this.sifreTxt.MouseEnter += new System.EventHandler(this.sifreTxt_MouseEnter);
            // 
            // girisButon
            // 
            this.girisButon.BackColor = System.Drawing.Color.MidnightBlue;
            this.girisButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.girisButon.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisButon.Location = new System.Drawing.Point(141, 375);
            this.girisButon.Name = "girisButon";
            this.girisButon.Size = new System.Drawing.Size(270, 46);
            this.girisButon.TabIndex = 4;
            this.girisButon.Text = "Giriş Yap";
            this.girisButon.UseVisualStyleBackColor = false;
            this.girisButon.Click += new System.EventHandler(this.girisButon_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(169, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Şifre";
            // 
            // GirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(532, 503);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.girisButon);
            this.Controls.Add(this.sifreTxt);
            this.Controls.Add(this.kullaniciAdiTxt);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeknoCare TEKNİK SERVİS";
            this.Load += new System.EventHandler(this.GirisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox kullaniciAdiTxt;
        private System.Windows.Forms.TextBox sifreTxt;
        private System.Windows.Forms.Button girisButon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}