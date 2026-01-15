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

namespace MusteriIliskileriVeHizmetTalepYonetimi
{
    public partial class YeniTalepOlusturForm : Form
    {
        public YeniTalepOlusturForm()
        {
            InitializeComponent();
        }

        private void YeniTalepOlusturForm_Load(object sender, EventArgs e)
        {

            
                
                KullanıcılarService ks = new KullanıcılarService();
                musteriAdiComboBox.DataSource = ks.MusteriListesiGetir();
                musteriAdiComboBox.DisplayMember = "AdSoyad"; 
                musteriAdiComboBox.ValueMember = "MusteriId"; 

                
                HizmetlerService hs = new HizmetlerService();
                hizmetAdiComboBox.DataSource = hs.HizmetListesiGetir();
                hizmetAdiComboBox.DisplayMember = "HizmetAdi";  
                hizmetAdiComboBox.ValueMember = "HizmetId"; 
            
        }

        private void talepOlusturButon_Click(object sender, EventArgs e)
        {
            int secilenMusteriId = Convert.ToInt32(musteriAdiComboBox.SelectedValue);
            int secilenHizmetId = Convert.ToInt32(hizmetAdiComboBox.SelectedValue);

            
            TaleplerService ts = new TaleplerService();

            ts.talepKaydet(
                secilenMusteriId,
                secilenHizmetId,
                1,                   
                "Bekliyor",          
                    
                aciklamaTxt.Text    
            );
            
            MessageBox.Show("Talep oluşturuldu!");
        }
    }
}
