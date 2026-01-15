using MusteriIliskileriVeHizmetTalepYonetimi.Service;
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
    public partial class HizmetGuncelleForm : Form
    {

        public int GelenId;
        public string GelenAd;
        public string GelenAciklama;
        public string GelenFiyat;
        public HizmetGuncelleForm()
        {
            InitializeComponent();
        }

        private void hizmetGuncelleSilButon_Click(object sender, EventArgs e)
        {
            if (GelenId == 0)
            {
                MessageBox.Show("Silinecek kayıt bulunamadı (ID Hatası).");
                return;
            }
            DialogResult cevap = MessageBox.Show("Bu hizmeti kalıcı olarak silmek istediğinize emin misiniz?",
                                                 "Silme Onayı",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Warning);

            if (cevap == DialogResult.Yes)
            {
                try
                {
                    HizmetlerService servis = new HizmetlerService();
                    servis.hizmetSil(GelenId);
                    MessageBox.Show("Hizmet başarıyla silindi.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme işlemi sırasında hata oluştu: " + ex.Message);
                }
            }
        }

        private void HizmetGuncelleForm_Load(object sender, EventArgs e)
        {
            hizmetGuncelleAdTxt.Text = GelenAd;
            hizmetGuncelleAcıklamaTxt.Text = GelenAciklama;
            fiyatTxt.Text = GelenFiyat;
        }

        private void hizmetGuncelleKaydetButon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gelen ID Değeri: " + GelenId.ToString());
            if (GelenId == 0)
            {
                MessageBox.Show("Güncellenecek kayıt ID'si bulunamadı!");
                return;
            }
            try
            {
                HizmetlerService hs = new HizmetlerService();
                decimal guncelFiyat = Convert.ToInt32(fiyatTxt.Text);
                hs.musteriGuncelle(GelenId, hizmetGuncelleAdTxt.Text, hizmetGuncelleAcıklamaTxt.Text, guncelFiyat);
                MessageBox.Show("Hizmet başarıyla güncellendi.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncellem sırasında bir hata oluştu:" + ex.Message);
            }
        }

        private void hizmetDüzenleBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
