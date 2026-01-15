using MusteriIliskileriVeHizmetTalepYonetimi.Domain;
using nypDönemSonuProje.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nypDönemSonuProje.Service
{
    internal class MusterilerService
    {
        public void musteriKaydet(string gAdSoyad, string gTelefon,string gEposta, string gAdres, DateTime gKayitTarihi)
        {
            (new MusterilerDAO()).musterilerKaydet(new Musteriler(gAdSoyad, gTelefon, gEposta, gAdres, gKayitTarihi));
        }
        public ArrayList  musteriGetir()
        {
            return (new MusterilerDAO()).musterilerGetir();
        }

        public void musteriSil(int gMusteriId)
        {
            (new MusterilerDAO()).musterilerSil(gMusteriId);
        }

        public void musterilerGuncelle(int gMusteriId, string gAdSoyad, string gTelefon, string gEposta, string gAdres, DateTime gKayitTarihi)
        {
            Musteriler m = new Musteriler();
            m.MusteriId = Convert.ToInt32(gMusteriId);
            m.AdSoyad = gAdSoyad.ToString();
            m.Telefon = gTelefon.ToString();
            m.Eposta = gEposta.ToString();
            m.Adres = gAdres.ToString();
            m.KayitTarihi = Convert.ToDateTime(gKayitTarihi);
            (new MusterilerDAO()).musterilerGuncelle(m);
        }
    }
}
