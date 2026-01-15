using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriIliskileriVeHizmetTalepYonetimi.Domain
{
    public class Kullanıcılar
    {
        public Kullanıcılar(string gAdSoyad, string gKullaniciAdi, string gSifre, string gRol, string gTelefon, DateTime gOlusturmaTarihi)
        {
            this.AdSoyad = gAdSoyad;
            this.KullaniciAdi = gKullaniciAdi;
            this.Sifre = gSifre;
            this.Rol = gRol;
            this.Telefon = gTelefon;
            this.OlusturmaTarihi = gOlusturmaTarihi;
        }
        
        public Kullanıcılar() 
        {

        }
        int kullanicilarId;
        public int KullanicilarId
        {
            get { return kullanicilarId; }
            set { kullanicilarId = value; }
        }

        string adSoyad;
        public string AdSoyad
        {
            get { return adSoyad; }
            set { adSoyad = value; }
        }

        string kullaniciAdi;
        public string KullaniciAdi
        {
            get { return kullaniciAdi; }
            set { kullaniciAdi = value; }
        }

        string sifre;

        public string Sifre
        {
            get { return sifre; }
            set { sifre = value; }
        }

        string rol;
        public string Rol
        {
            get { return rol; }
            set { rol = value; }
        }

        string telefon;
        public string Telefon
        {
            get { return telefon; }
            set { telefon = value; }
        }

         DateTime olusturmaTarihi;

        public DateTime OlusturmaTarihi
        {
            get { return olusturmaTarihi; }
            set { olusturmaTarihi = value; }
        }
        
       

        
    }
}
