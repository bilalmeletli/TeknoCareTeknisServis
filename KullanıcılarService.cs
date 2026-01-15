using MusteriIliskileriVeHizmetTalepYonetimi.Domain;
using nypDönemSonuProje.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nypDönemSonuProje.Service
{
    internal class KullanıcılarService
    {
        public void kullaniciKaydet(string gAdSoyad, string gKullaniciAdi, string gSifre, string gRol, string gTelefon, DateTime gOlusturmaTarihi)
        {
            (new KullanıcılarDAO()).kullanicilarKaydet(new Kullanıcılar(gAdSoyad,gKullaniciAdi,gSifre,gRol,gTelefon,gOlusturmaTarihi));
        }

        public ArrayList kullaniciGetir()
        {
            return ( new KullanıcılarDAO()).kullanicilarGetir();
        }

        public void kullaniciSil(int gKullanicilarId)
        {
            (new KullanıcılarDAO()).kullanicilarSil(gKullanicilarId);
        }

        public void kullaniciGuncelle(int gKullanicilarId, string gAdSoyad, string gKullaniciAdi, string gSifre, string gRol, string gTelefon, DateTime gOlusturmaTarihi)
        {
            Kullanıcılar k = new Kullanıcılar();
            k.KullanicilarId =Convert.ToInt32( gKullanicilarId);
            k.AdSoyad= gAdSoyad.ToString(); 
            k.KullaniciAdi= gKullaniciAdi.ToString();
            k.Sifre= gSifre.ToString();
            k.Rol= gRol.ToString(); 
            k.Telefon= gTelefon.ToString();
            k.OlusturmaTarihi=Convert.ToDateTime(gOlusturmaTarihi);
            
            (new KullanıcılarDAO()).kullanicilarGuncelle(k);
        }

        public Kullanıcılar GirisYap(string kullaniciAdi, string sifre)
        {
            KullanıcılarDAO kd = new KullanıcılarDAO();
            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                
                throw new Exception("Kullanıcı adı veya şifre boş bırakılamaz!");
            }

           
            return kd.girisYap(kullaniciAdi, sifre);
        }
        public System.Data.DataTable MusteriListesiGetir()
        {
            KullanıcılarDAO dao = new KullanıcılarDAO();
            return dao.TumMusterileriGetir();
        }
        public System.Data.DataTable PersonelListesiGetir()
        {
            return (new KullanıcılarDAO()).PersonelListesiGetir();
        }
    }
}
