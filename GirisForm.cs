using MusteriIliskileriVeHizmetTalepYonetimi.Domain;
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
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }

        private void girisButon_Click(object sender, EventArgs e)
        {
            try
            {
                
                KullanıcılarService service = new KullanıcılarService();
                Kullanıcılar girisYapan = service.GirisYap(kullaniciAdiTxt.Text,sifreTxt.Text);
                if (girisYapan != null)
                {
                    MessageBox.Show("Hoşgeldiniz: " + girisYapan.AdSoyad);
                    this.Hide(); 
                    Form1 f = new Form1(girisYapan.Rol);
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void GirisForm_Load(object sender, EventArgs e)
        {
            kullaniciAdiTxt.Text = "Kullanıcı Adı";
            kullaniciAdiTxt.ForeColor = Color.Black;

          
            sifreTxt.Text = "Şifre";
            sifreTxt.ForeColor = Color.Silver;
        }

        private void kullaniciAdiTxt_Enter(object sender, EventArgs e)
        {
            if (kullaniciAdiTxt.Text == "Kullanıcı Adı")
            {
                kullaniciAdiTxt.Text = "";
                kullaniciAdiTxt.ForeColor = Color.Black;
            }
        }

        private void sifreTxt_Leave(object sender, EventArgs e)
        {
            if (sifreTxt.Text == "")
            {
                sifreTxt.PasswordChar = '\0';
                sifreTxt.Text = "Şifre";
                sifreTxt.ForeColor = Color.Black;
            }
        }

        private void kullaniciAdiTxt_Leave(object sender, EventArgs e)
        {
            if (kullaniciAdiTxt.Text == "")
            {
                kullaniciAdiTxt.Text = "Kullanıcı Adı";
                kullaniciAdiTxt.ForeColor = Color.Black; 
            }
        }

        private void sifreTxt_MouseEnter(object sender, EventArgs e)
        {
            if (sifreTxt.Text == "Şifre")
            {
                sifreTxt.Text = "";
                sifreTxt.ForeColor = Color.Black;
               
            }
        }
    }
}
