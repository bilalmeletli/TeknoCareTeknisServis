namespace MusteriIliskileriVeHizmetTalepYonetimi
{
    partial class TaleplerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaleplerForm));
            this.talepOluşturForm = new System.Windows.Forms.Button();
            this.taleplerDgv = new System.Windows.Forms.DataGridView();
            this.guncelleButon = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.taleplerDgv)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // talepOluşturForm
            // 
            this.talepOluşturForm.BackColor = System.Drawing.Color.MidnightBlue;
            this.talepOluşturForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.talepOluşturForm.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.talepOluşturForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.talepOluşturForm.Location = new System.Drawing.Point(839, 542);
            this.talepOluşturForm.Name = "talepOluşturForm";
            this.talepOluşturForm.Size = new System.Drawing.Size(155, 52);
            this.talepOluşturForm.TabIndex = 3;
            this.talepOluşturForm.Text = "Yeni Talep Oluştur";
            this.talepOluşturForm.UseVisualStyleBackColor = false;
            this.talepOluşturForm.Click += new System.EventHandler(this.talepOluşturForm_Click);
            // 
            // taleplerDgv
            // 
            this.taleplerDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taleplerDgv.Location = new System.Drawing.Point(16, 99);
            this.taleplerDgv.Name = "taleplerDgv";
            this.taleplerDgv.RowHeadersWidth = 51;
            this.taleplerDgv.RowTemplate.Height = 24;
            this.taleplerDgv.Size = new System.Drawing.Size(1156, 423);
            this.taleplerDgv.TabIndex = 4;
            this.taleplerDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.taleplerDgv.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.taleplerDgv_CellFormatting);
            // 
            // guncelleButon
            // 
            this.guncelleButon.BackColor = System.Drawing.Color.MidnightBlue;
            this.guncelleButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guncelleButon.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncelleButon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.guncelleButon.Location = new System.Drawing.Point(1017, 542);
            this.guncelleButon.Name = "guncelleButon";
            this.guncelleButon.Size = new System.Drawing.Size(155, 52);
            this.guncelleButon.TabIndex = 5;
            this.guncelleButon.Text = "Güncelle";
            this.guncelleButon.UseVisualStyleBackColor = false;
            this.guncelleButon.Click += new System.EventHandler(this.guncelleButon_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1235, 65);
            this.panel3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "TALEPLER";
            // 
            // TaleplerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1235, 728);
            this.Controls.Add(this.talepOluşturForm);
            this.Controls.Add(this.guncelleButon);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.taleplerDgv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TaleplerForm";
            this.Text = "TeknoCare TEKNİK SERVİS";
            this.Load += new System.EventHandler(this.TaleplerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taleplerDgv)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button talepOluşturForm;
        private System.Windows.Forms.DataGridView taleplerDgv;
        private System.Windows.Forms.Button guncelleButon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
    }
}