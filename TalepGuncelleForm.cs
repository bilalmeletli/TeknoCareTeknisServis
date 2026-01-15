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
    public partial class TalepGuncelleForm : Form
    {
        public int GelenTalepId { get; set; }
        public TalepGuncelleForm()
        {
            InitializeComponent();
        }

        private void TalepGuncelleForm_Load(object sender, EventArgs e)
        {
            KullanıcılarService ks = new KullanıcılarService();
            DataTable dtMusteri = ks.MusteriListesiGetir();
            musteriAdiComboBox.DataSource = dtMusteri;
            musteriAdiComboBox.DisplayMember = "AdSoyad";
            musteriAdiComboBox.ValueMember = "MusteriId";
            HizmetlerService hs = new HizmetlerService();
            DataTable dtHizmet = hs.HizmetListesiGetir();
            hizmetAdıComboBox.DataSource = dtHizmet;
            hizmetAdıComboBox.DisplayMember = "HizmetAdi";
            hizmetAdıComboBox.ValueMember = "HizmetId";
            personelComboBox.DataSource = ks.PersonelListesiGetir();
            personelComboBox.DisplayMember = "GorunenAd";
            personelComboBox.ValueMember = "KullanicilarId";
            durumComboBox.DataSource = null;
            durumComboBox.Items.Clear();
            durumComboBox.Items.Add("Bekliyor");
            durumComboBox.Items.Add("İşlemde");
            durumComboBox.Items.Add("Tamamlandı");
            
            try
            {
                TaleplerService ts = new TaleplerService();
                DataTable dtTalep = ts.TalepBilgisiniGetir(GelenTalepId);

                if (dtTalep.Rows.Count > 0)
                {
                    DataRow satir = dtTalep.Rows[0];
                    
                    aciklamaTxt.Text = satir["aciklama"].ToString();
                    durumComboBox.Text = satir["durum"].ToString();
                    if (satir["musteriId"] != DBNull.Value)
                    {
                        musteriAdiComboBox.SelectedValue = Convert.ToInt32(satir["musteriId"]);
                    }

                    if (satir["hizmetId"] != DBNull.Value)
                    {
                        hizmetAdıComboBox.SelectedValue = Convert.ToInt32(satir["hizmetId"]);
                    }

                    if (satir["personelId"] != DBNull.Value)
                    {
                        personelComboBox.SelectedValue = Convert.ToInt32(satir["personelId"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri çekme hatası: " + ex.Message);
            }
        }

        private void talepAtaKaydetButon_Click(object sender, EventArgs e)
        {
            try
            {
                string secilenDurum = durumComboBox.Text;
                
                int musteriId = musteriAdiComboBox.SelectedValue != null ? Convert.ToInt32(musteriAdiComboBox.SelectedValue) : 0;
                int hizmetId = hizmetAdıComboBox.SelectedValue != null ? Convert.ToInt32(hizmetAdıComboBox.SelectedValue) : 0;
                int personelId = personelComboBox.SelectedValue != null ? Convert.ToInt32(personelComboBox.SelectedValue) : 0;
                string durum = durumComboBox.Text;
                if (string.IsNullOrEmpty(durum) || durum == "None" || durum == "Seçiniz")
                {
               
                    MessageBox.Show("Lütfen geçerli bir Durum seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                TaleplerService ts = new TaleplerService();
                ts.talepGuncelle(
                    GelenTalepId,      
                    musteriId,          
                    hizmetId,          
                    personelId,        
                    durum,              
                    aciklamaTxt.Text  
                );

                MessageBox.Show("Talep başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            this.DialogResult = DialogResult.OK; 

            this.Close();

        }

        private void silButon_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Bu kaydı kalıcı olarak silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            if (cevap == DialogResult.Yes)
            {
                TaleplerService service = new TaleplerService();
                service.talepSil(GelenTalepId);
                MessageBox.Show("Talep başarıyla silindi.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
