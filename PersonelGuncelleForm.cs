using MusteriIliskileriVeHizmetTalepYonetimi.Service;
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

namespace nypDönemSonuProje
{
    public partial class PersonelGuncelleForm : Form
    {
        public int gelenId = 0;
        public string gelenAdsoyad = "";
        public string gelenKullaniciAdi = "";
        public string gelenSifre = "";
        public string gelenRol = "";
        public string gelenTelefon = "";
        public DateTime gelenOlusturmaTarihi= DateTime.Now;
        
        
        public PersonelGuncelleForm()
        {
            InitializeComponent();
        }

        private void guncelleSilButon_Click(object sender, EventArgs e)
        {
            if (gelenId == 0)
            {
                MessageBox.Show("Silinecek kayıt bulunamadı(ID Hatası)");
                return;
            }
            DialogResult cevap = MessageBox.Show("Bu personeli kalıcı olarak silmek istediğinize emin misiniz?",
                                                "Silme Onayı",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning);
            if (cevap == DialogResult.Yes)
            {
                try
                {
                    KullanıcılarService ps = new KullanıcılarService();
                    ps.kullaniciSil(gelenId);
                    MessageBox.Show("Personel başarıyla silindi.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme işlemi sırasında hata oluştu: " + ex.Message);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void PersonelGuncelleForm_Load(object sender, EventArgs e)
        {
            
            adSoyadTxt.Text = gelenAdsoyad;
            kullaniciAdiTxt.Text= gelenKullaniciAdi;
            sifreTxt.Text = gelenSifre; 
            rolTxt.Text = gelenRol;
            telefonTxt.Text = gelenTelefon;
            
            
        }

        private void guncelleKaydetButon_Click(object sender, EventArgs e)
        {
            if (gelenId == 0)
            {
                MessageBox.Show("Güncellenecek kayıt ID'si bulunamadı!");
                return;
            }
            try
            {
                KullanıcılarService ks = new KullanıcılarService();
               
                ks.kullaniciGuncelle(gelenId,adSoyadTxt.Text,kullaniciAdiTxt.Text,sifreTxt.Text,rolTxt.Text,telefonTxt.Text,gelenOlusturmaTarihi);
                MessageBox.Show("Personel bilgileri başarıyla güncellendi.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında bir hata oluştu:" + ex.Message);
            }
        }
    }
}
