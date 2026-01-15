using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriIliskileriVeHizmetTalepYonetimi.Domain
{
    public class Talepler
    {
        public Talepler(int musteriId, int hizmetId, int personelId, string durum,  string aciklama, DateTime olusturmaTarihi)
        {
            this.MusteriId = musteriId;
            this.HizmetId = hizmetId;
            this.PersonelId = personelId;
            this.Durum = durum;
           
            this.Aciklama = aciklama;
            this.OlusturmaTarihi = olusturmaTarihi;
        }
        public string MusteriAdSoyad { get; set; } 
        public string HizmetAdi { get; set; }
        public Talepler()
        {

        }
        int talepId;
        public int TalepId
        {
            get { return talepId; }
            set { talepId = value; }
        }
        int musteriId;
        public int MusteriId
        {
            get { return musteriId; }
            set { musteriId = value; } 
        }
        int hizmetId;
        public int HizmetId
        {
            get { return hizmetId; }
            set { hizmetId = value; }
        }
        int personelId;
        public int PersonelId
        {
            get { return personelId; }
            set { personelId = value; }
        }
        string durum;
        public string Durum
        {
            get { return durum; }
            set { durum = value; }
        }
        string baslik;
       
        string aciklama;
        public string Aciklama
        {
            get { return aciklama; }
            set {  aciklama = value; }
        }
        DateTime olusturmaTarihi;

        public DateTime OlusturmaTarihi
        {
            get { return olusturmaTarihi; }
            set { olusturmaTarihi = value; }
        }

        DateTime tamamlanmaTarihi;
        public DateTime TamamlanmaTarihi
        {
            get { return tamamlanmaTarihi; }
            set { tamamlanmaTarihi = value; }
        }
        public decimal OnaylananFiyat { get; set; }
        public string AtananPersonelAdi { get; set; }






    }

}
