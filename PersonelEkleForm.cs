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
    public partial class PersonelEkleForm : Form
    {
        public PersonelEkleForm()
        {
            InitializeComponent();
        }

        private void personelKaydetButon_Click(object sender, EventArgs e)
        {
            new KullanıcılarService().kullaniciKaydet(adSoyadTxt.Text,kullaniciAdiTxt.Text,sifreTxt.Text, rolComboBox.Text, telefonTxt.Text,DateTime.Now);
            MessageBox.Show("Personel ekleme işlemi başarıyla gerçekleşti.");
            this.Close();
        }

        private void PersonelEkleForm_Load(object sender, EventArgs e)
        {
            rolComboBox.Items.Clear();
            rolComboBox.Items.Add("Admin");      
            rolComboBox.Items.Add("Destek Personeli"); 
            rolComboBox.Items.Add("Çağrı Merkezi Personeli");
            rolComboBox.Items.Add("Yazılım Uzmanı");
            rolComboBox.Items.Add("Anakart Tamircisi");
            rolComboBox.Items.Add("Veri Kurtarma Uzmanı");
            rolComboBox.Items.Add("Kalite Kontrol Uzmanı");
            rolComboBox.Items.Add("Stajyer");
            rolComboBox.Items.Add("Donanım Teknisyeni");
            rolComboBox.SelectedIndex = 0;
        }
    }
}
