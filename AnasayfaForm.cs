using nypDönemSonuProje.DAL;
using nypDönemSonuProje.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MusteriIliskileriVeHizmetTalepYonetimi
{
    public partial class AnasayfaForm : Form
    {
        RaporlarService rs= new RaporlarService();
        public AnasayfaForm()
        {
            InitializeComponent();
        }
        private void AnasayfaForm_Load(object sender, EventArgs e)
        {
            
            GrafikleriDoldur();
            TaleplerDAO DAO = new TaleplerDAO();
            DataTable dt = DAO.TariheGoreSonBesTalep();
            if (dt != null && dt.Rows.Count > 0)
            {
                anasayfaDgv.DataSource = dt;
                if (anasayfaDgv.Columns.Contains("TalepId"))
                {
                    anasayfaDgv.Columns["TalepId"].Visible = false;
                }
                if (anasayfaDgv.Columns.Contains("Musteri"))
                {
                    anasayfaDgv.Columns["Musteri"].HeaderText = "Müşteri Adı";
                }
                if (anasayfaDgv.Columns.Contains("Hizmet"))
                {
                    anasayfaDgv.Columns["Hizmet"].HeaderText = "Talep Edilen Hizmet";
                }
                if (anasayfaDgv.Columns.Contains("OlusturmaTarihi"))
                {
                    anasayfaDgv.Columns["OlusturmaTarihi"].HeaderText = "Tarih";
                }
                anasayfaDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            { 
                MessageBox.Show("Listelenecek son talep bulunamadı veya veritabanı bağlantısında sorun var.");
            }
        }
        private void DurumGrafigiCiz(DataTable dt)
        {
            
            if (chartDurum == null) return;

            chartDurum.Series.Clear();
            chartDurum.Legends.Clear();
            chartDurum.BackColor = Color.MidnightBlue;
            chartDurum.ChartAreas[0].BackColor = Color.MidnightBlue;
            Legend l = chartDurum.Legends.Add("Durumlar");
            l.ForeColor = Color.White;
            l.BackColor = Color.MidnightBlue;
            l.Docking = Docking.Top;
            Series s = chartDurum.Series.Add("Durum");
            s.ChartType = SeriesChartType.Column;
            s.IsValueShownAsLabel = true;
            s.LabelForeColor = Color.White;
            s["PixelPointWidth"] = "30";

            foreach (DataRow row in dt.Rows)
            {
                string durumAdi = row["durum"].ToString();
                int sayi = Convert.ToInt32(row["Sayi"]);
                int i = s.Points.AddXY(durumAdi, sayi);
                if (durumAdi == "Bekliyor") s.Points[i].Color = Color.IndianRed;
                else if (durumAdi == "İşlemde") s.Points[i].Color = Color.Gold;
                else if (durumAdi == "Tamamlandı") s.Points[i].Color = Color.SeaGreen;
                else s.Points[i].Color = Color.White;
            }
        }
        private void VerileriDoldur()
        {
            DataTable dtPersonel = rs.PersonelListesi();
            if (dtPersonel.Rows.Count > 0)
            {
                 MessageBox.Show("Personel verisi geldi! Satır sayısı: " + dtPersonel.Rows.Count);
            }

            if (personelDgv != null)
            {
                personelDgv.DataSource = null; 
                personelDgv.Columns.Clear();
                personelDgv.AutoGenerateColumns = true; 

                personelDgv.DataSource = dtPersonel; 
                GridTasariminiYap(personelDgv);
            }
            DataTable dtHizmet = rs.HizmetListesi();

            if (hizmetlerDgv != null)
            {
                hizmetlerDgv.DataSource = null;
                hizmetlerDgv.Columns.Clear();
                hizmetlerDgv.AutoGenerateColumns = true;

                hizmetlerDgv.DataSource = dtHizmet;
                GridTasariminiYap(hizmetlerDgv);
            }
            if (personelChart != null && dtPersonel.Rows.Count > 0)
            {
                GrafigiCiz(dtPersonel);
            }
        }

        private void GridTasariminiYap(DataGridView dgv)
        {
          
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.FromArgb(60, 60, 60);
            dgv.DefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);
            dgv.DefaultCellStyle.ForeColor = Color.White;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Orange;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            dgv.RowHeadersVisible = false;
        }


        private void GrafigiCiz(DataTable dt)
        {

            personelChart.Series.Clear();
            personelChart.Legends.Clear();
            personelChart.BackColor = Color.Transparent;
            personelChart.ChartAreas[0].BackColor = Color.Transparent;
            Legend legend = personelChart.Legends.Add("Personel");
            legend.BackColor = Color.Transparent;
            legend.ForeColor = Color.White; 
            legend.Docking = Docking.Bottom; 
            Series seri = personelChart.Series.Add("PersonelIs");
            seri.ChartType = SeriesChartType.Doughnut; 
            seri.LabelForeColor = Color.White;
            seri.IsValueShownAsLabel = true;

            foreach (DataRow row in dt.Rows)
            {
      
                string personel = row["Personel"].ToString();
                int sayi = Convert.ToInt32(row["IsSayisi"]);
                int i = seri.Points.AddXY(personel, sayi);
                seri.Points[i].LegendText = $"{personel} ({sayi})";
            }
        }

        private void GrafikleriDoldur()
        {
            TaleplerDAO dao = new TaleplerDAO();
            System.Data.DataTable dt = dao.DurumIstatistikleriniGetir();
            chartDurum.Series.Clear();
            chartDurum.Legends.Clear(); 
            chartDurum.Legends.Add("Default");
            chartDurum.BackColor = Color.MidnightBlue;
            chartDurum.ChartAreas[0].BackColor = Color.MidnightBlue;
            chartDurum.Legends[0].BackColor = Color.MidnightBlue; 
            chartDurum.Legends[0].ForeColor = Color.White;  
            chartDurum.Legends[0].Font = new Font("Segoe UI", 10);

        }

        private void anasayfaDgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (anasayfaDgv.Rows[e.RowIndex].Cells["Durum"].Value == null) return;

            string durum = anasayfaDgv.Rows[e.RowIndex].Cells["Durum"].Value.ToString().Trim();
            DataGridViewRow satir = anasayfaDgv.Rows[e.RowIndex];
            switch (durum)
            {
                case "Bekliyor":
                    satir.DefaultCellStyle.BackColor = Color.IndianRed;
                    satir.DefaultCellStyle.ForeColor = Color.White;
                    break;

                case "İşlemde":
                    satir.DefaultCellStyle.BackColor = Color.Gold;
                    satir.DefaultCellStyle.ForeColor = Color.Black; 
                    break;

                case "Tamamlandı":
                    satir.DefaultCellStyle.BackColor = Color.SeaGreen;
                    satir.DefaultCellStyle.ForeColor = Color.White;
                    break;
            }
        }

        private void raporButon_Click(object sender, EventArgs e)
        {
            RaporlariOlustur();
        }
        private void RaporlariOlustur()
        {

            DataTable dtPersonel = rs.PersonelListesi();
            DataTable dtHizmet = rs.HizmetListesi();

            if (personelDgv != null)
            {
                personelDgv.DataSource = null;   
                personelDgv.Columns.Clear();        
                personelDgv.AutoGenerateColumns = true;

                personelDgv.DataSource = dtPersonel;
                GridTasarimi(personelDgv);
            }

     
            if (hizmetlerDgv != null)
            {
                hizmetlerDgv.DataSource = null;
                hizmetlerDgv.Columns.Clear();
                hizmetlerDgv.AutoGenerateColumns = true;

                hizmetlerDgv.DataSource = dtHizmet;
                GridTasarimi(hizmetlerDgv);
            }

            if (personelChart != null)
            {
                GrafikCiz(dtPersonel);
            }
            DataTable dtDurum = rs.DurumRaporu();
            DurumGrafigiCiz(dtDurum);

        }

        private void GrafikCiz(DataTable dt)
        {
            personelChart.Series.Clear();
            personelChart.Legends.Clear(); 
            personelChart.BackColor = Color.Transparent;
            personelChart.ChartAreas[0].BackColor = Color.Transparent;
            Legend l = personelChart.Legends.Add("Personel");
            l.ForeColor = Color.White;
            l.BackColor = Color.Transparent;
            Series s = personelChart.Series.Add("İşler");
            s.ChartType = SeriesChartType.Pie; 
            s.LabelForeColor = Color.White;
            s.IsValueShownAsLabel = true;

            foreach (DataRow row in dt.Rows)
            {
                string isim = row["Personel"].ToString();
               
                if (string.IsNullOrEmpty(isim)) isim = "Bilinmiyor";

                int sayi = Convert.ToInt32(row["IsSayisi"]);

                if (sayi > 0)
                {
                    int i = s.Points.AddXY(isim, sayi);
                    s.Points[i].LegendText = $"{isim} ({sayi})";
                }
            }
        }

        private void GridTasarimi(DataGridView dgv)
        {
            
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.FromArgb(60, 60, 60);
            dgv.DefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);
            dgv.DefaultCellStyle.ForeColor = Color.White;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Orange; 
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgv.RowHeadersVisible = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
    
}
