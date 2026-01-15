namespace MusteriIliskileriVeHizmetTalepYonetimi
{
    partial class YeniTalepOlusturForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YeniTalepOlusturForm));
            this.label3 = new System.Windows.Forms.Label();
            this.talepOlusturButon = new System.Windows.Forms.Button();
            this.musteriAdiComboBox = new System.Windows.Forms.ComboBox();
            this.hizmetAdiComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.aciklamaTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 2;
            // 
            // talepOlusturButon
            // 
            this.talepOlusturButon.BackColor = System.Drawing.Color.MidnightBlue;
            this.talepOlusturButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.talepOlusturButon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.talepOlusturButon.Location = new System.Drawing.Point(232, 257);
            this.talepOlusturButon.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.talepOlusturButon.Name = "talepOlusturButon";
            this.talepOlusturButon.Size = new System.Drawing.Size(109, 49);
            this.talepOlusturButon.TabIndex = 3;
            this.talepOlusturButon.Text = "Oluştur";
            this.talepOlusturButon.UseVisualStyleBackColor = false;
            this.talepOlusturButon.Click += new System.EventHandler(this.talepOlusturButon_Click);
            // 
            // musteriAdiComboBox
            // 
            this.musteriAdiComboBox.FormattingEnabled = true;
            this.musteriAdiComboBox.Location = new System.Drawing.Point(167, 29);
            this.musteriAdiComboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.musteriAdiComboBox.Name = "musteriAdiComboBox";
            this.musteriAdiComboBox.Size = new System.Drawing.Size(174, 25);
            this.musteriAdiComboBox.TabIndex = 4;
            // 
            // hizmetAdiComboBox
            // 
            this.hizmetAdiComboBox.FormattingEnabled = true;
            this.hizmetAdiComboBox.Location = new System.Drawing.Point(167, 83);
            this.hizmetAdiComboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.hizmetAdiComboBox.Name = "hizmetAdiComboBox";
            this.hizmetAdiComboBox.Size = new System.Drawing.Size(174, 25);
            this.hizmetAdiComboBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(38, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Müşteri Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(38, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hizmet Adı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(38, 144);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Açıklama:";
            // 
            // aciklamaTxt
            // 
            this.aciklamaTxt.Location = new System.Drawing.Point(167, 140);
            this.aciklamaTxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.aciklamaTxt.Name = "aciklamaTxt";
            this.aciklamaTxt.Size = new System.Drawing.Size(174, 23);
            this.aciklamaTxt.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.musteriAdiComboBox);
            this.groupBox1.Controls.Add(this.aciklamaTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.talepOlusturButon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.hizmetAdiComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(9, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(362, 328);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Talep Oluştur";
            // 
            // YeniTalepOlusturForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "YeniTalepOlusturForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeknoCare TEKNİK SERVİS";
            this.Load += new System.EventHandler(this.YeniTalepOlusturForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button talepOlusturButon;
        private System.Windows.Forms.ComboBox musteriAdiComboBox;
        private System.Windows.Forms.ComboBox hizmetAdiComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox aciklamaTxt;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}