using MusteriIliskileriVeHizmetTalepYonetimi.Domain;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nypDönemSonuProje.DAL
{
    internal class MusterilerDAO
    {
        public void musterilerKaydet(Musteriler gMusteriler)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430058;User ID=26_132430058; Password=İnif123.");
            baglanti.Open();
            new MySqlCommand("INSERT INTO Musteriler (AdSoyad, telefon, eposta, adres, kayitTarihi) " +
             "VALUES ('" + gMusteriler.AdSoyad + "', " +
                    "'" + gMusteriler.Telefon + "', " +
                    "'" + gMusteriler.Eposta + "', " +
                    "'" + gMusteriler.Adres + "', " +
                    "'" + gMusteriler.KayitTarihi.ToString("yyyy-MM-dd HH:mm:ss") + "')", baglanti).ExecuteNonQuery();
            baglanti.Close();
        }

        public ArrayList musterilerGetir()
        {
            ArrayList musteriler = new ArrayList();
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430058;User ID=26_132430058; Password=İnif123.");
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select*  from Musteriler", baglanti);
            MySqlDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                Musteriler m = new Musteriler();
                m.MusteriId = Convert.ToInt32(okuyucu[0]);
                m.AdSoyad = okuyucu[1].ToString();
                m.Telefon = okuyucu[2].ToString();
                m.Eposta = okuyucu[3].ToString();
                m.Adres = okuyucu[4].ToString();
                m.KayitTarihi = Convert.ToDateTime(okuyucu[5]);
                musteriler.Add(m);
                
            }
            baglanti.Close();
            return musteriler;
        }

        public void musterilerSil(int gMusteriId)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430058;User ID=26_132430058; Password=İnif123.");
            baglanti.Open();
            new MySqlCommand("delete from Musteriler where musteriId=" + gMusteriId, baglanti).ExecuteNonQuery();
            baglanti.Close();
        }

        public void musterilerGuncelle(Musteriler m)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430058;User ID=26_132430058; Password=İnif123.");
            baglanti.Open();
            new MySqlCommand("UPDATE Musteriler SET " +
                     "adsoyad = '" + m.AdSoyad + "', " +
                     "telefon = '" + m.Telefon + "', " +
                     "eposta = '" + m.Eposta + "', " +
                     "adres = '" + m.Adres + "', " +
                     "kayitTarihi = '" + m.KayitTarihi.ToString("yyyy-MM-dd HH:mm:ss") + "' " +
                     "WHERE musteriId = " + m.MusteriId , baglanti).ExecuteNonQuery();
            baglanti.Close();
        }
        public System.Data.DataTable TumMusterileriGetir()
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430058;User ID=26_132430058;Password=İnif123.");
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT KullanicilarId, AdSoyad FROM Kullanicilar WHERE Rol='Musteri'", baglanti);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
