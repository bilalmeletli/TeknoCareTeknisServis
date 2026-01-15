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
    public partial class HizmetEkleForm : Form
    {
        public HizmetEkleForm()
        {
            InitializeComponent();
        }

        private void hizmetEkleKaydetButon_Click(object sender, EventArgs e)
        {
          new HizmetlerService().hizmetKaydet(hizmetEkleAdTxt.Text, hizmetEkleAcıklamaTxt.Text, Convert.ToInt32(fiyatTxt.Text));
            MessageBox.Show("Hizmet Başarıyla Eklendi");
          
        }

        private void hizmetEkleBox_Enter(object sender, EventArgs e)
        {

        }

        private void HizmetEkleForm_Load(object sender, EventArgs e)
        {

        }
    }
}
