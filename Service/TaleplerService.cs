using MusteriIliskileriVeHizmetTalepYonetimi.Domain;
using nypDönemSonuProje.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nypDönemSonuProje.Service
{
    internal class TaleplerService
    {
        public void talepKaydet(int gMusteriId , int gHizmetId , int gPersonelId , string gDurum ,  string gAciklama)
        {
            (new TaleplerDAO()).taleplerKaydet(new Talepler(gMusteriId, gHizmetId, gPersonelId, gDurum,  gAciklama,DateTime.Now));
        }

        public List<Talepler> talepGetir()
        {
            return (new TaleplerDAO()).taleplerGetir();
        }

        public void talepSil(int gTalepId)
        {
            (new TaleplerDAO()).taleplerSil(gTalepId);
        }

        public void talepGuncelle(int gTalepId ,int gMusteriId, int gHizmetId, int gPersonelId, string gDurum,  string gAciklama)
        {
            Talepler t = new Talepler();
            t.TalepId = Convert.ToInt32 (gTalepId);
            t.MusteriId = Convert.ToInt32 (gMusteriId);
            t.HizmetId = Convert.ToInt32 (gHizmetId);
            t.PersonelId = Convert.ToInt32(gPersonelId);
            t.Durum = gDurum.ToString();
           
            t.Aciklama = gAciklama.ToString();
            (new TaleplerDAO()).taleplerGuncelle (t);
        }
        public System.Data.DataTable TalepBilgisiniGetir(int id)
        {
            return (new TaleplerDAO()).TalepGetir(id);
           
        }
    }
}
