namespace MusteriIliskileriVeHizmetTalepYonetimi
{
    partial class PersonelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelForm));
            this.drawerustPanel = new System.Windows.Forms.Panel();
            this.kapatButon = new System.Windows.Forms.Button();
            this.adSoyadLabel = new System.Windows.Forms.Label();
            this.anaPanel = new System.Windows.Forms.Panel();
            this.personelGuncelleButon = new System.Windows.Forms.Button();
            this.personelEkleButon = new System.Windows.Forms.Button();
            this.personellerDgv = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.drawerustPanel.SuspendLayout();
            this.anaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personellerDgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawerustPanel
            // 
            this.drawerustPanel.Controls.Add(this.kapatButon);
            this.drawerustPanel.Controls.Add(this.adSoyadLabel);
            this.drawerustPanel.Location = new System.Drawing.Point(400, 167);
            this.drawerustPanel.Name = "drawerustPanel";
            this.drawerustPanel.Size = new System.Drawing.Size(300, 60);
            this.drawerustPanel.TabIndex = 0;
            // 
            // kapatButon
            // 
            this.kapatButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kapatButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kapatButon.Location = new System.Drawing.Point(209, 0);
            this.kapatButon.Name = "kapatButon";
            this.kapatButon.Size = new System.Drawing.Size(48, 25);
            this.kapatButon.TabIndex = 1;
            this.kapatButon.Text = "X";
            this.kapatButon.UseVisualStyleBackColor = false;
            // 
            // adSoyadLabel
            // 
            this.adSoyadLabel.AutoSize = true;
            this.adSoyadLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.adSoyadLabel.Location = new System.Drawing.Point(39, 23);
            this.adSoyadLabel.Name = "adSoyadLabel";
            this.adSoyadLabel.Size = new System.Drawing.Size(70, 16);
            this.adSoyadLabel.TabIndex = 0;
            this.adSoyadLabel.Text = "Ad Soyad:";
            // 
            // anaPanel
            // 
            this.anaPanel.BackColor = System.Drawing.Color.Navy;
            this.anaPanel.Controls.Add(this.personelGuncelleButon);
            this.anaPanel.Controls.Add(this.personelEkleButon);
            this.anaPanel.Controls.Add(this.personellerDgv);
            this.anaPanel.Controls.Add(this.drawerustPanel);
            this.anaPanel.Controls.Add(this.panel1);
            this.anaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.anaPanel.Location = new System.Drawing.Point(0, 0);
            this.anaPanel.Name = "anaPanel";
            this.anaPanel.Size = new System.Drawing.Size(1235, 728);
            this.anaPanel.TabIndex = 1;
            this.anaPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.anaPanel_Paint);
            // 
            // personelGuncelleButon
            // 
            this.personelGuncelleButon.BackColor = System.Drawing.Color.MidnightBlue;
            this.personelGuncelleButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personelGuncelleButon.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelGuncelleButon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.personelGuncelleButon.Location = new System.Drawing.Point(1018, 514);
            this.personelGuncelleButon.Name = "personelGuncelleButon";
            this.personelGuncelleButon.Size = new System.Drawing.Size(157, 47);
            this.personelGuncelleButon.TabIndex = 4;
            this.personelGuncelleButon.Text = "Düzenle";
            this.personelGuncelleButon.UseVisualStyleBackColor = false;
            this.personelGuncelleButon.Click += new System.EventHandler(this.personelGuncelleButon_Click);
            // 
            // personelEkleButon
            // 
            this.personelEkleButon.BackColor = System.Drawing.Color.MidnightBlue;
            this.personelEkleButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personelEkleButon.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelEkleButon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.personelEkleButon.Location = new System.Drawing.Point(842, 514);
            this.personelEkleButon.Name = "personelEkleButon";
            this.personelEkleButon.Size = new System.Drawing.Size(157, 47);
            this.personelEkleButon.TabIndex = 2;
            this.personelEkleButon.Text = "Personel Ekle";
            this.personelEkleButon.UseVisualStyleBackColor = false;
            this.personelEkleButon.Click += new System.EventHandler(this.personelEkleButon_Click);
            // 
            // personellerDgv
            // 
            this.personellerDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.personellerDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personellerDgv.Location = new System.Drawing.Point(12, 88);
            this.personellerDgv.Name = "personellerDgv";
            this.personellerDgv.RowHeadersWidth = 51;
            this.personellerDgv.RowTemplate.Height = 24;
            this.personellerDgv.Size = new System.Drawing.Size(1163, 420);
            this.personellerDgv.TabIndex = 3;
            this.personellerDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.personllerDgv_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1235, 65);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "PERSONELLER";
            // 
            // PersonelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1235, 728);
            this.Controls.Add(this.anaPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PersonelForm";
            this.Text = "TeknoCare TEKNİK SERVİS";
            this.Load += new System.EventHandler(this.PersonelForm_Load);
            this.drawerustPanel.ResumeLayout(false);
            this.drawerustPanel.PerformLayout();
            this.anaPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personellerDgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel anaPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button personelEkleButon;
        private System.Windows.Forms.Panel drawerustPanel;
        private System.Windows.Forms.Button kapatButon;
        private System.Windows.Forms.Label adSoyadLabel;
        private System.Windows.Forms.DataGridView personellerDgv;
        private System.Windows.Forms.Button personelGuncelleButon;
        private System.Windows.Forms.Label label1;
    }
}