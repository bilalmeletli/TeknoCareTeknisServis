namespace MusteriIliskileriVeHizmetTalepYonetimi
{
    partial class HizmetlerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HizmetlerForm));
            this.hizmetlerDgv = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hizmetGuncelleButon = new System.Windows.Forms.Button();
            this.yeniHizmetEkleButon = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hizmetlerDgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // hizmetlerDgv
            // 
            this.hizmetlerDgv.AllowUserToOrderColumns = true;
            this.hizmetlerDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hizmetlerDgv.Location = new System.Drawing.Point(19, 100);
            this.hizmetlerDgv.MultiSelect = false;
            this.hizmetlerDgv.Name = "hizmetlerDgv";
            this.hizmetlerDgv.RowHeadersWidth = 51;
            this.hizmetlerDgv.RowTemplate.Height = 24;
            this.hizmetlerDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.hizmetlerDgv.Size = new System.Drawing.Size(1170, 454);
            this.hizmetlerDgv.TabIndex = 0;
            this.hizmetlerDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.hizmetlerDgv_CellClick);
            this.hizmetlerDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.hizmetlerDgv_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.hizmetGuncelleButon);
            this.panel1.Controls.Add(this.yeniHizmetEkleButon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 658);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1235, 70);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // hizmetGuncelleButon
            // 
            this.hizmetGuncelleButon.BackColor = System.Drawing.Color.MidnightBlue;
            this.hizmetGuncelleButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hizmetGuncelleButon.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hizmetGuncelleButon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.hizmetGuncelleButon.Location = new System.Drawing.Point(1083, 3);
            this.hizmetGuncelleButon.Name = "hizmetGuncelleButon";
            this.hizmetGuncelleButon.Size = new System.Drawing.Size(105, 51);
            this.hizmetGuncelleButon.TabIndex = 0;
            this.hizmetGuncelleButon.Text = "Düzenle";
            this.hizmetGuncelleButon.UseVisualStyleBackColor = false;
            this.hizmetGuncelleButon.Click += new System.EventHandler(this.hizmetGuncelleButon_Click);
            // 
            // yeniHizmetEkleButon
            // 
            this.yeniHizmetEkleButon.BackColor = System.Drawing.Color.MidnightBlue;
            this.yeniHizmetEkleButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yeniHizmetEkleButon.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yeniHizmetEkleButon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.yeniHizmetEkleButon.Location = new System.Drawing.Point(932, 3);
            this.yeniHizmetEkleButon.Name = "yeniHizmetEkleButon";
            this.yeniHizmetEkleButon.Size = new System.Drawing.Size(106, 51);
            this.yeniHizmetEkleButon.TabIndex = 4;
            this.yeniHizmetEkleButon.Text = "Yeni Ekle";
            this.yeniHizmetEkleButon.UseVisualStyleBackColor = false;
            this.yeniHizmetEkleButon.Click += new System.EventHandler(this.yeniHizmetEkleButon_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1235, 65);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "HİZMETLER";
            // 
            // HizmetlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1235, 728);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.hizmetlerDgv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HizmetlerForm";
            this.Text = "TeknoCare TEKNİK SERVİS";
            this.Load += new System.EventHandler(this.HizmetlerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hizmetlerDgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView hizmetlerDgv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button hizmetGuncelleButon;
        private System.Windows.Forms.Button yeniHizmetEkleButon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}