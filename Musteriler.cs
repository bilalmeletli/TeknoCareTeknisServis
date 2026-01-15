using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriIliskileriVeHizmetTalepYonetimi.Domain
{
    public class Musteriler
    {
        public Musteriler(string gAdSoyad, string gTelefon,string gEposta,string gAdres,DateTime gKayitTarihi)
        {
            this.adSoyad = gAdSoyad;
            this.telefon = gTelefon;
            this.eposta = gEposta;
            this.adres = gAdres;
            this.kayitTarihi = gKayitTarihi;
        }
        public Musteriler()
        {

        }
        int musteriId;
        public int MusteriId
        {
            get { return musteriId; }
            set { musteriId = value; }
        }
        string adSoyad;
        public string AdSoyad
        {
            get { return adSoyad; }
            set { adSoyad = value; }
        }
        string telefon;
        public string Telefon
        {
            get { return telefon; }
            set { telefon = value; }    
        }
        string eposta;
        public string Eposta
        {
            get { return eposta; }
            set { eposta = value; }
        }
        string adres;
        public string Adres
        {
            get { return adres; }
            set { adres = value; }
        }
        DateTime kayitTarihi;
        public DateTime KayitTarihi
        {
            get { return kayitTarihi; }
            set { kayitTarihi = value; }
        }
        public override string ToString()
        {
            return this.adSoyad;
        }
    }
}
