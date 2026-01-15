using MusteriIliskileriVeHizmetTalepYonetimi.Domain;
using MySql.Data.MySqlClient;
using System;
using System.Collections;

namespace MusteriIliskileriVeHizmetTalepYonetimi.DAL
{
    public class HizmetlerDAO
    {
        public void kaydet(Hizmetler gHizmetler)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430058;User ID=26_132430058; Password=İnif123.");
            baglanti.Open();
            new MySqlCommand("INSERT INTO Hizmetler (hizmetAdi, aciklama, fiyat) " +
             "VALUES ('" +
             gHizmetler.HizmetAdi + "', '" +
             gHizmetler.Aciklama + "', " +
             gHizmetler.Fiyat + ")", baglanti).ExecuteNonQuery();
            baglanti.Close();
        }
    
        public ArrayList hizmetlerGetir()
        {
            ArrayList hizmetler = new ArrayList();
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430058;User ID=26_132430058; Password=İnif123.");
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select*  from Hizmetler", baglanti);
            MySqlDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                Hizmetler h = new Hizmetler();
                h.HizmetId = Convert.ToInt32(okuyucu[0]);
                h.HizmetAdi = okuyucu[1].ToString();
                h.Aciklama = okuyucu[2].ToString();
                h.Fiyat = Convert.ToInt32(okuyucu[3]);
                hizmetler.Add(h);
            }
            baglanti.Close();
            return hizmetler;
        }

        internal void hizmetlerSil(int gHizmetlerId)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430058;User ID=26_132430058; Password=İnif123.");
            baglanti.Open();
            new MySqlCommand("delete from Hizmetler where hizmetId="+gHizmetlerId, baglanti).ExecuteNonQuery();
            baglanti.Close();
        }

        internal void hizmetlerGuncelle(Hizmetler h)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430058;User ID=26_132430058; Password=İnif123.");
            baglanti.Open();
            new MySqlCommand("UPDATE Hizmetler SET hizmetAdi='" + h.HizmetAdi +
               "',aciklama='" + h.Aciklama +
               "',fiyat=" + Convert.ToInt32(h.Fiyat) + " " + "WHERE hizmetId=" + h.HizmetId, baglanti).ExecuteNonQuery();
            baglanti.Close();
        }
        public System.Data.DataTable tumHizmetleriGetir()
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430058;User ID=26_132430058;Password=İnif123.");
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT HizmetId, HizmetAdi FROM Hizmetler", baglanti);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            return dt;
        }
    }

}
