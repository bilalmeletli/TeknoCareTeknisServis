using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriIliskileriVeHizmetTalepYonetimi.Domain
{
    public class Hizmetler
    {
        public Hizmetler(string gAd, string gAciklama, int gFiyat)
        {
            this.hizmetAdi= gAd;
            this.aciklama= gAciklama;
            this.fiyat= gFiyat;
        }
        public Hizmetler()
        {

        }
        int hizmetId;

        public int HizmetId
        {
            get { return hizmetId; }
            set { hizmetId = value; }
        }
        string hizmetAdi;

        public string HizmetAdi
        {
            get { return hizmetAdi; }
            set { hizmetAdi = value; }
        }
        string aciklama;
        public string Aciklama
        {
            get { return aciklama; }
            set { aciklama = value; }
        }
        int  fiyat;

        public int Fiyat
        { 
            get { return fiyat; }
            set { fiyat = value; }
        }

        public override string ToString()
        {
            return this.hizmetAdi;
        }
    

      
    }

}
