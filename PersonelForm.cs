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
    public partial class PersonelForm : Form
    {
        public int secilenId= 0;
        public string secilenAdSoyad = "";
        public string secilenKullaniciAdi = "";
        public string secilenSifre = "";
        public string secilenRol = "";
        public string secilenTelefon = "";
        public DateTime secilenTarih = DateTime.Now;
       

        public PersonelForm()
        {
            InitializeComponent();
        }

        private void personelEkleButon_Click(object sender, EventArgs e)
        {
            PersonelEkleForm pef= new PersonelEkleForm();
            pef.ShowDialog();
            personelDgvDoldur();
        }

        private void PersonelForm_Load(object sender, EventArgs e)
        {
            personelDgvDoldur();
        }

        public void personelDgvDoldur()
        {
            KullanıcılarService ps = new KullanıcılarService();
            personellerDgv.DataSource = ps.kullaniciGetir();

        }

        private void personllerDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = personellerDgv.Rows[e.RowIndex];
                if (row.Cells["kullanicilarId"].Value != null)
                {
                    secilenId = Convert.ToInt32(row.Cells["kullanicilarId"].Value);
                }
                secilenAdSoyad = row.Cells[1].Value.ToString();
                secilenKullaniciAdi = row.Cells[2].Value.ToString();
                secilenSifre = row.Cells[3].Value.ToString();
                secilenRol = row.Cells[4].Value.ToString();
                secilenTelefon = row.Cells[5].Value.ToString();
                secilenTarih = Convert.ToDateTime(row.Cells[6].Value);
                
                
          
            }

        }

        private void personelGuncelleButon_Click(object sender, EventArgs e)
        {
            PersonelGuncelleForm pgf = new PersonelGuncelleForm();
            pgf.gelenId = secilenId;
            pgf.gelenAdsoyad = secilenAdSoyad;
            pgf.gelenKullaniciAdi = secilenKullaniciAdi;
            pgf.gelenSifre = secilenSifre;
            pgf.gelenRol = secilenRol;
            pgf.gelenTelefon = secilenTelefon;
            
            pgf.ShowDialog();
            personelDgvDoldur();
            secilenId = 0;
        }

        private void anaPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
