using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MusteriIliskileriVeHizmetTalepYonetimi.Domain;
using MusteriIliskileriVeHizmetTalepYonetimi;

namespace MusteriIliskileriVeHizmetTalepYonetimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string gelenRol;

       
        public Form1(string rol)
        {
            InitializeComponent();

            gelenRol = rol; 
            YetkileriAyarla(); 
        }
        private void YetkileriAyarla()
        {
           

          
            string temizRol = gelenRol.Trim().ToLower();

        

            if (temizRol == "destek personeli") 
            {
                musterilerButon.Visible = false;
                personelButon.Visible = false;
                
                hizmetlerButon.Visible = false;
                taleplerButon.Visible = true;
            }
            else if (temizRol == "çağrı merkezi personeli") 
            {
                personelButon.Visible = false;
               
                hizmetlerButon.Visible = false;
                
            }
            else if (temizRol == "admin" || temizRol == "yönetici")
            {
               button1.Visible = false;
            }
            else
            {
                MessageBox.Show("Yetkisiz Giriş veya Tanımsız Rol: " + temizRol);
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            SayfaGetir(new GirisForm());
        }



        private void taleplerButon_Click(object sender, EventArgs e)
        {
            SayfaGetir(new TaleplerForm());

        }

        private void musterilerButon_Click(object sender, EventArgs e)
        {
            /*MusteriForm m = new MusteriForm();
            m.Show();*/
            SayfaGetir(new MusteriForm());
             
        }
         

        public void SayfaGetir(Form MusteriForm)
        {
            
            panelAnaIcerik.Controls.Clear();

            
            MusteriForm.TopLevel = false;             
            MusteriForm.FormBorderStyle = FormBorderStyle.None; 
            MusteriForm.Dock = DockStyle.Fill;        

            
            panelAnaIcerik.Controls.Add(MusteriForm);
            MusteriForm.Show();
        }

        private void personelButon_Click(object sender, EventArgs e)
        {
            SayfaGetir(new  PersonelForm());
        }

      

        private void anaSayfaButon_Click(object sender, EventArgs e)
        {
            SayfaGetir(new AnasayfaForm());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SayfaGetir(new GirisForm());
        }

        private void hizmetlerButon_Click(object sender, EventArgs e)
        {
            SayfaGetir(new HizmetlerForm());
        }

        private void panelAnaIcerik_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Uygulamadan çıkmak istediğinize emin misiniz?",
                                         "Çıkış",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            
            if (cevap == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
    }
