using MusteriIliskileriVeHizmetTalepYonetimi.DAL;
using MusteriIliskileriVeHizmetTalepYonetimi.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriIliskileriVeHizmetTalepYonetimi.Service
{
    class HizmetlerService
    {
        public void hizmetKaydet(string gHizmetAdi, string gAciklama, int gFiyat)
        {
            (new HizmetlerDAO()).kaydet(new Hizmetler(gHizmetAdi, gAciklama, gFiyat));
        }

        internal ArrayList hizmetlerGetir()
        {
            return (new HizmetlerDAO().hizmetlerGetir());
        }

        internal void hizmetSil(int gHizmetlerId)
        {
            (new HizmetlerDAO()).hizmetlerSil(gHizmetlerId);
        }

        internal void musteriGuncelle(int gId, string gAd, string gAciklama, decimal gFiyat)
        {
            Hizmetler h = new Hizmetler();
            h.HizmetId = Convert.ToInt32(gId);
            h.HizmetAdi = gAd.ToString();
            h.Aciklama = gAciklama.ToString();
            h.Fiyat = Convert.ToInt32(gFiyat);
            (new HizmetlerDAO()).hizmetlerGuncelle(h);
        }
        public System.Data.DataTable HizmetListesiGetir()
        {
            HizmetlerDAO dao = new HizmetlerDAO();
            return dao.tumHizmetleriGetir();
        }
    }
}
