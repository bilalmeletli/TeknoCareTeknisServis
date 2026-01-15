namespace MusteriIliskileriVeHizmetTalepYonetimi
{
    partial class AnasayfaForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnasayfaForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ozetPanel = new System.Windows.Forms.Panel();
            this.chartDurum = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.anasayfaDgv = new System.Windows.Forms.DataGridView();
            this.label18 = new System.Windows.Forms.Label();
            this.hizmetlerDgv = new System.Windows.Forms.DataGridView();
            this.personelDgv = new System.Windows.Forms.DataGridView();
            this.personelChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.raporButon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.ozetPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDurum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anasayfaDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hizmetlerDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelChart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1235, 65);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(30, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "ANA SAYFA";
            // 
            // ozetPanel
            // 
            this.ozetPanel.Controls.Add(this.chartDurum);
            this.ozetPanel.Location = new System.Drawing.Point(38, 71);
            this.ozetPanel.Name = "ozetPanel";
            this.ozetPanel.Size = new System.Drawing.Size(413, 249);
            this.ozetPanel.TabIndex = 1;
            // 
            // chartDurum
            // 
            this.chartDurum.BorderlineColor = System.Drawing.Color.DimGray;
            chartArea1.Name = "ChartArea1";
            this.chartDurum.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDurum.Legends.Add(legend1);
            this.chartDurum.Location = new System.Drawing.Point(26, 12);
            this.chartDurum.Name = "chartDurum";
            this.chartDurum.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDurum.Series.Add(series1);
            this.chartDurum.Size = new System.Drawing.Size(368, 234);
            this.chartDurum.TabIndex = 3;
            this.chartDurum.Text = "chart1";
            // 
            // anasayfaDgv
            // 
            this.anasayfaDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.anasayfaDgv.Location = new System.Drawing.Point(488, 91);
            this.anasayfaDgv.Name = "anasayfaDgv";
            this.anasayfaDgv.ReadOnly = true;
            this.anasayfaDgv.RowHeadersVisible = false;
            this.anasayfaDgv.RowHeadersWidth = 51;
            this.anasayfaDgv.RowTemplate.Height = 24;
            this.anasayfaDgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.anasayfaDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.anasayfaDgv.Size = new System.Drawing.Size(735, 154);
            this.anasayfaDgv.TabIndex = 2;
            this.anasayfaDgv.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.anasayfaDgv_CellFormatting);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label18.Location = new System.Drawing.Point(485, 71);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 17);
            this.label18.TabIndex = 4;
            this.label18.Text = "Son 5 Talep";
            // 
            // hizmetlerDgv
            // 
            this.hizmetlerDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hizmetlerDgv.Location = new System.Drawing.Point(488, 280);
            this.hizmetlerDgv.Name = "hizmetlerDgv";
            this.hizmetlerDgv.RowHeadersWidth = 51;
            this.hizmetlerDgv.RowTemplate.Height = 24;
            this.hizmetlerDgv.Size = new System.Drawing.Size(736, 136);
            this.hizmetlerDgv.TabIndex = 5;
            // 
            // personelDgv
            // 
            this.personelDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personelDgv.Location = new System.Drawing.Point(487, 439);
            this.personelDgv.Name = "personelDgv";
            this.personelDgv.RowHeadersWidth = 51;
            this.personelDgv.RowTemplate.Height = 24;
            this.personelDgv.Size = new System.Drawing.Size(736, 136);
            this.personelDgv.TabIndex = 6;
            // 
            // personelChart
            // 
            this.personelChart.BorderlineColor = System.Drawing.Color.DimGray;
            chartArea2.Name = "ChartArea1";
            this.personelChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.personelChart.Legends.Add(legend2);
            this.personelChart.Location = new System.Drawing.Point(64, 341);
            this.personelChart.Name = "personelChart";
            this.personelChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.personelChart.Series.Add(series2);
            this.personelChart.Size = new System.Drawing.Size(368, 234);
            this.personelChart.TabIndex = 7;
            this.personelChart.Text = "chart1";
            // 
            // raporButon
            // 
            this.raporButon.BackColor = System.Drawing.Color.MidnightBlue;
            this.raporButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raporButon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.raporButon.Location = new System.Drawing.Point(1129, 581);
            this.raporButon.Name = "raporButon";
            this.raporButon.Size = new System.Drawing.Size(94, 43);
            this.raporButon.TabIndex = 8;
            this.raporButon.Text = "Raporla";
            this.raporButon.UseVisualStyleBackColor = false;
            this.raporButon.Click += new System.EventHandler(this.raporButon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(485, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "En Çok Talep Edilen Hizmetler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(485, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Personel Performans Tablosu";
            // 
            // AnasayfaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1235, 728);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.raporButon);
            this.Controls.Add(this.personelChart);
            this.Controls.Add(this.personelDgv);
            this.Controls.Add(this.hizmetlerDgv);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.anasayfaDgv);
            this.Controls.Add(this.ozetPanel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnasayfaForm";
            this.Text = "TeknoCare TEKNİK SERVİS";
            this.Load += new System.EventHandler(this.AnasayfaForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ozetPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDurum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anasayfaDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hizmetlerDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel ozetPanel;
        private System.Windows.Forms.DataGridView anasayfaDgv;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDurum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView hizmetlerDgv;
        private System.Windows.Forms.DataGridView personelDgv;
        private System.Windows.Forms.DataVisualization.Charting.Chart personelChart;
        private System.Windows.Forms.Button raporButon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}