using MusteriIliskileriVeHizmetTalepYonetimi.Domain;
using nypDönemSonuProje;
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

namespace MusteriIliskileriVeHizmetTalepYonetimi
{
    public partial class TaleplerForm : Form
    {
        public TaleplerForm()
        {
            InitializeComponent();
        }

        private void talepOluşturForm_Click(object sender, EventArgs e)
        {
            YeniTalepOlusturForm ytof = new YeniTalepOlusturForm();
            ytof.ShowDialog();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void TaleplerListele()
        {
            TaleplerService ts = new TaleplerService();
            var gelenListe = ts.talepGetir();
            taleplerDgv.DataSource = null;          
            taleplerDgv.Columns.Clear();             
            taleplerDgv.AutoGenerateColumns = true; 
            taleplerDgv.DataSource = gelenListe;
            if(taleplerDgv.Columns["Aciklama"] != null)
            {
                taleplerDgv.Columns["Aciklama"].AutoSizeMode  =DataGridViewAutoSizeColumnMode.Fill;
            }
            if (taleplerDgv.Columns["MusteriId"] != null) taleplerDgv.Columns["MusteriId"].Visible = false;
            if (taleplerDgv.Columns["HizmetId"] != null) taleplerDgv.Columns["HizmetId"].Visible = false;
            if (taleplerDgv.Columns["PersonelId"] != null) taleplerDgv.Columns["PersonelId"].Visible = false;
            if (taleplerDgv.Columns["TalepId"] != null) taleplerDgv.Columns["TalepId"].Visible = false;
            if (taleplerDgv.Columns["MusteriAdSoyad"] != null)
            {
                taleplerDgv.Columns["MusteriAdSoyad"].HeaderText = "Müşteri Adı";
                taleplerDgv.Columns["MusteriAdSoyad"].DisplayIndex = 0; 
            }
            if (taleplerDgv.Columns["HizmetAdi"] != null)
            {
                taleplerDgv.Columns["HizmetAdi"].HeaderText = "Hizmet";
                taleplerDgv.Columns["HizmetAdi"].DisplayIndex = 1;
            }
        }

        private void TaleplerForm_Load(object sender, EventArgs e)
        {
            TaleplerListele();
        }

        private void guncelleButon_Click(object sender, EventArgs e)
        {
            if (taleplerDgv.SelectedRows.Count > 0)
            {

                int secilenId = Convert.ToInt32(taleplerDgv.SelectedRows[0].Cells["TalepId"].Value);
                TalepGuncelleForm tgf = new TalepGuncelleForm();
                tgf.GelenTalepId = secilenId;
                
                DialogResult sonuc = tgf.ShowDialog();

                
                if (sonuc == DialogResult.OK)
                {
                   
                    TaleplerListele();
                }


            }
            else
            {
                MessageBox.Show("Lütfen güncellemek için listeden bir talep seçin.");
            }
          
        }

        private void taleplerDgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (taleplerDgv.Columns[e.ColumnIndex].Name == "Durum" && e.Value != null)
            {
                string durum = e.Value.ToString();

              
                DataGridViewRow satir = taleplerDgv.Rows[e.RowIndex];

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
        }
    }
}
