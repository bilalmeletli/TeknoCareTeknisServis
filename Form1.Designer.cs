namespace MusteriIliskileriVeHizmetTalepYonetimi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.taleplerButon = new System.Windows.Forms.Button();
            this.anaSayfaButon = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.personelButon = new System.Windows.Forms.Button();
            this.musterilerButon = new System.Windows.Forms.Button();
            this.panelAnaIcerik = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.hizmetlerButon = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // taleplerButon
            // 
            this.taleplerButon.BackColor = System.Drawing.Color.MidnightBlue;
            this.taleplerButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taleplerButon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.taleplerButon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.taleplerButon.ImageKey = "talep.png";
            this.taleplerButon.ImageList = this.ımageList1;
            this.taleplerButon.Location = new System.Drawing.Point(-10, 283);
            this.taleplerButon.Name = "taleplerButon";
            this.taleplerButon.Size = new System.Drawing.Size(313, 47);
            this.taleplerButon.TabIndex = 0;
            this.taleplerButon.Text = "TALEPLER";
            this.taleplerButon.UseVisualStyleBackColor = false;
            this.taleplerButon.Click += new System.EventHandler(this.taleplerButon_Click);
            // 
            // anaSayfaButon
            // 
            this.anaSayfaButon.BackColor = System.Drawing.Color.MidnightBlue;
            this.anaSayfaButon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.anaSayfaButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anaSayfaButon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.anaSayfaButon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.anaSayfaButon.ImageIndex = 1;
            this.anaSayfaButon.ImageList = this.ımageList1;
            this.anaSayfaButon.Location = new System.Drawing.Point(0, 69);
            this.anaSayfaButon.Name = "anaSayfaButon";
            this.anaSayfaButon.Size = new System.Drawing.Size(297, 49);
            this.anaSayfaButon.TabIndex = 1;
            this.anaSayfaButon.Text = "ANA SAYFA";
            this.anaSayfaButon.UseVisualStyleBackColor = false;
            this.anaSayfaButon.Click += new System.EventHandler(this.anaSayfaButon_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "ChatGPT Image 22 Ara 2025 20_28_39.png");
            this.ımageList1.Images.SetKeyName(1, "ChatGPT Image 10 Oca 2026 22_42_31.png");
            this.ımageList1.Images.SetKeyName(2, "ChatGPT Image 10 Oca 2026 22_45_57.png");
            this.ımageList1.Images.SetKeyName(3, "Tekno Care Teknik Servis logosu.ico");
            this.ımageList1.Images.SetKeyName(4, "çıkış buton.png");
            this.ımageList1.Images.SetKeyName(5, "hizmet foto.png");
            this.ımageList1.Images.SetKeyName(6, "ChatGPT Image 15 Oca 2026 17_26_28.png");
            this.ımageList1.Images.SetKeyName(7, "talep.png");
            // 
            // personelButon
            // 
            this.personelButon.BackColor = System.Drawing.Color.MidnightBlue;
            this.personelButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personelButon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.personelButon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.personelButon.ImageKey = "ChatGPT Image 15 Oca 2026 17_26_28.png";
            this.personelButon.ImageList = this.ımageList1;
            this.personelButon.Location = new System.Drawing.Point(-3, 177);
            this.personelButon.Name = "personelButon";
            this.personelButon.Size = new System.Drawing.Size(300, 47);
            this.personelButon.TabIndex = 2;
            this.personelButon.Text = "PERSONEL";
            this.personelButon.UseVisualStyleBackColor = false;
            this.personelButon.Click += new System.EventHandler(this.personelButon_Click);
            // 
            // musterilerButon
            // 
            this.musterilerButon.BackColor = System.Drawing.Color.MidnightBlue;
            this.musterilerButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musterilerButon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.musterilerButon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.musterilerButon.ImageIndex = 2;
            this.musterilerButon.ImageList = this.ımageList1;
            this.musterilerButon.Location = new System.Drawing.Point(0, 230);
            this.musterilerButon.Name = "musterilerButon";
            this.musterilerButon.Size = new System.Drawing.Size(297, 47);
            this.musterilerButon.TabIndex = 4;
            this.musterilerButon.Text = "MÜŞTERİLER";
            this.musterilerButon.UseVisualStyleBackColor = false;
            this.musterilerButon.Click += new System.EventHandler(this.musterilerButon_Click);
            // 
            // panelAnaIcerik
            // 
            this.panelAnaIcerik.Location = new System.Drawing.Point(292, 0);
            this.panelAnaIcerik.Name = "panelAnaIcerik";
            this.panelAnaIcerik.Size = new System.Drawing.Size(1114, 708);
            this.panelAnaIcerik.TabIndex = 5;
            this.panelAnaIcerik.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAnaIcerik_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.anaSayfaButon);
            this.panel2.Controls.Add(this.musterilerButon);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.hizmetlerButon);
            this.panel2.Controls.Add(this.taleplerButon);
            this.panel2.Controls.Add(this.personelButon);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 708);
            this.panel2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(13, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "TeknoCare TEKNİK SERVİS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 32);
            this.label1.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(292, 63);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(3, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(292, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hizmetlerButon
            // 
            this.hizmetlerButon.BackColor = System.Drawing.Color.MidnightBlue;
            this.hizmetlerButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hizmetlerButon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.hizmetlerButon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hizmetlerButon.ImageIndex = 5;
            this.hizmetlerButon.ImageList = this.ımageList1;
            this.hizmetlerButon.Location = new System.Drawing.Point(0, 124);
            this.hizmetlerButon.Name = "hizmetlerButon";
            this.hizmetlerButon.Size = new System.Drawing.Size(293, 47);
            this.hizmetlerButon.TabIndex = 5;
            this.hizmetlerButon.Text = "HİZMETLER";
            this.hizmetlerButon.UseVisualStyleBackColor = false;
            this.hizmetlerButon.Click += new System.EventHandler(this.hizmetlerButon_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MidnightBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageKey = "çıkış buton.png";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(0, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(297, 47);
            this.button2.TabIndex = 11;
            this.button2.Text = "ÇIKIŞ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 706);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelAnaIcerik);
            this.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeknoCare TEKNİK SERVİS";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button taleplerButon;
        private System.Windows.Forms.Button anaSayfaButon;
        private System.Windows.Forms.Button personelButon;
        private System.Windows.Forms.Button musterilerButon;
        private System.Windows.Forms.Panel panelAnaIcerik;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button hizmetlerButon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}

