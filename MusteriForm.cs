using MusteriIliskileriVeHizmetTalepYonetimi.DAL;
using MusteriIliskileriVeHizmetTalepYonetimi.Domain;
using MusteriIliskileriVeHizmetTalepYonetimi.Service;
using MySql.Data.MySqlClient;
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
    public partial class MusteriForm : Form
    {
        public int secilenId = 0;
        public string secilenAdSoyad = "";
        public string secilenTelefon = "";
        public string secilenEposta = "";
        public string secilenAdres = "";
        public DateTime secilenKayitTarihi = DateTime.Now;
        public MusteriForm()
        {
            InitializeComponent();
        }

        private void MusteriForm_Load(object sender, EventArgs e)
        {
            musteriDgvDoldur();
            
        }

        private void musteriEkleButon_Click(object sender, EventArgs e)
        {
            
            try
            {
                (new MusterilerService()).musteriKaydet(adSoyadTxt.Text, musteriTelefonTxt.Text, epostaTxt.Text, musteriAdresTxt.Text, Convert.ToDateTime(kayitTarihiTxt.Text));
                MessageBox.Show("Müşteri başarıyla eklendi.");
                musteriDgvDoldur();
                adSoyadTxt.Text = "";
                musteriTelefonTxt.Text = "";
                musteriAdresTxt.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        public void musteriDgvDoldur()
        {
            MusterilerService ms = new MusterilerService();
            musterilerDgv.DataSource = ms.musteriGetir();
            if (musterilerDgv.Columns["Adres"] != null)
            {
                musterilerDgv.Columns["Adres"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void musterilerDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = musterilerDgv.Rows[e.RowIndex];
                secilenId = Convert.ToInt32(row.Cells[0].Value);
                secilenAdSoyad = row.Cells[1].Value.ToString();
                secilenTelefon = row.Cells[2].Value.ToString();
                secilenEposta = row.Cells[3].Value.ToString();
                secilenAdres = row.Cells[4].Value.ToString();
                secilenKayitTarihi = Convert.ToDateTime(row.Cells[5].Value);
                musteriIdTxt.Text =(secilenId).ToString();
                adSoyadTxt.Text = secilenAdSoyad;
                musteriTelefonTxt.Text = secilenTelefon;
                epostaTxt.Text = secilenEposta;
                musteriAdresTxt.Text = secilenAdres;
                kayitTarihiTxt.Text =(secilenKayitTarihi).ToString();
            }
            
          
        }

        private void musteriSilButon_Click(object sender, EventArgs e)
        {
            if (secilenId == 0)
            {
                MessageBox.Show("Silinecek kayıt bulunamadı (ID Hatası).");
                return;
            }
            DialogResult cevap = MessageBox.Show("Bu müşteriyi kalıcı olarak silmek istediğinize emin misiniz?",
                                                 "Silme Onayı",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Warning);

            if (cevap == DialogResult.Yes)
            {
                try
                {
                    MusterilerService ms = new MusterilerService();
                    ms.musteriSil(secilenId);
                    MessageBox.Show("Müşteri başarıyla silindi.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme işlemi sırasında hata oluştu: " + ex.Message);
                }
                musteriDgvDoldur();
                adSoyadTxt.Text = "";
                secilenId = 0;
            }
        }

        private void musteriGuncelleButon_Click(object sender, EventArgs e)
        {
            if (secilenId == 0)
            {
                MessageBox.Show("Güncellenecek kayıt ID'si bulunamadı!");
                return;
            }
            try
            {
                (new MusterilerService()).musterilerGuncelle(secilenId, adSoyadTxt.Text, musteriTelefonTxt.Text, epostaTxt.Text, musteriAdresTxt.Text, Convert.ToDateTime(kayitTarihiTxt.Text));
                MessageBox.Show("Müşteri bilgileri başarıyla güncellendi.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında bir hata oluştu:" + ex.Message);
            }
        }

        private void musteriTemizleButon_Click(object sender, EventArgs e)
        {

        }
    }
}
