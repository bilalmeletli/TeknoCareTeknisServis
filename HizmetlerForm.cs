using MusteriIliskileriVeHizmetTalepYonetimi.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusteriIliskileriVeHizmetTalepYonetimi
{
    public partial class HizmetlerForm : Form

        
    {
        int secilenId = 0;
        string secilenAd = "";
        string secilenAciklama = "";
        int secilenFiyat = 0;
        public HizmetlerForm()
        {
            InitializeComponent();
        }

        private void hizmetGuncelleButon_Click(object sender, EventArgs e)
        {
            
            if (secilenId == 0)
            {
                MessageBox.Show("Lütfen önce listeden güncellenecek hizmeti seçin.");
                return;
            }
            HizmetGuncelleForm hgf = new HizmetGuncelleForm();
            hgf.GelenId = secilenId;
            hgf.GelenAd = secilenAd;
            hgf.GelenAciklama = secilenAciklama;
            hgf.GelenFiyat = secilenFiyat.ToString();
            hgf.ShowDialog();
            gridDoldur();
            secilenId = 0;

        }

        private void yeniHizmetEkleButon_Click(object sender, EventArgs e)
        {
           HizmetEkleForm hef = new HizmetEkleForm();
            hef.ShowDialog();
            gridDoldur();


        }

        public void gridDoldur()
        {
            HizmetlerService hs = new HizmetlerService();
            hizmetlerDgv.DataSource=hs.hizmetlerGetir();
            if (hizmetlerDgv.Columns["HizmetId"] != null)
            {
               hizmetlerDgv.Columns["HizmetId"].Visible = false;
            }
            if (hizmetlerDgv.Columns["Aciklama"] != null)
            {
                hizmetlerDgv.Columns["Aciklama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void HizmetlerForm_Load(object sender, EventArgs e)
        {
            gridDoldur();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void hizmetlerDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = hizmetlerDgv.Rows[e.RowIndex];


                secilenId = Convert.ToInt32(row.Cells[0].Value);
                secilenAd = row.Cells[1].Value.ToString();
                secilenAciklama = row.Cells[2].Value.ToString();
                secilenFiyat = Convert.ToInt32(row.Cells[3].Value);
            }
        }

        private void hizmetlerDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
