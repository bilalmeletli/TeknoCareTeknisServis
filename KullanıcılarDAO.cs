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
    internal class KullanıcılarDAO
    {
        public void kullanicilarKaydet(Kullanıcılar gKullanicilar)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430058;User ID=26_132430058; Password=İnif123.");
            baglanti.Open();
            new MySqlCommand("INSERT INTO `Kullanicilar` " +
                 "(`AdSoyad`, `KullaniciAdi`, `Sifre`, `Rol`, `Telefon`, `OlusturulmaTarihi`) " +
                 "VALUES " +
                 "('" + gKullanicilar.AdSoyad + "', " +
                 "'" + gKullanicilar.KullaniciAdi + "', " +
                 "'" + gKullanicilar.Sifre + "', " +
                 "'" + gKullanicilar.Rol + "', " +
                 "'" + gKullanicilar.Telefon + "', " +
                 "NOW())", baglanti).ExecuteNonQuery();
            baglanti.Close();
        }

        public ArrayList kullanicilarGetir()
        {
            ArrayList kullanicilar = new ArrayList();
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430058;User ID=26_132430058; Password=İnif123.");
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select * from Kullanicilar", baglanti);
            MySqlDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                Kullanıcılar k = new Kullanıcılar();
                k.KullanicilarId = Convert.ToInt32(okuyucu[0]);
                k.AdSoyad = okuyucu[1].ToString();
                k.KullaniciAdi = okuyucu[2].ToString();
                k.Sifre = okuyucu[3].ToString();
                k.Rol = okuyucu[4].ToString();
                k.Telefon = okuyucu[5].ToString();
                k.OlusturmaTarihi = Convert.ToDateTime(okuyucu[6]);

                kullanicilar.Add(k);
            }
            baglanti.Close();
            return kullanicilar;

        }

        public void kullanicilarSil(int gKullanicilarId)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430058;User ID=26_132430058; Password=İnif123.");
            baglanti.Open();
            new MySqlCommand("delete from Kullanicilar where kullanicilarId=" + gKullanicilarId, baglanti).ExecuteNonQuery();
            baglanti.Close();
        }

        public void kullanicilarGuncelle(Kullanıcılar k)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430058;User ID=26_132430058; Password=İnif123.");
            baglanti.Open();
            new MySqlCommand("UPDATE Kullanicilar SET " +
                                "adsoyad = '" + k.AdSoyad + "', " +
                                "kullaniciAdi = '" + k.KullaniciAdi + "', " +
                                "sifre = '" + k.Sifre + "', " +
                                "rol = '" + k.Rol + "', " +
                                "telefon = '" + k.Telefon + "' " +
                                "WHERE kullanicilarId = " + k.KullanicilarId, baglanti).ExecuteNonQuery();
            baglanti.Close();
        }

        public Kullanıcılar girisYap(string kullaniciAdi, string sifre)
        {
            Kullanıcılar k = null;
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430058;User ID=26_132430058; Password=İnif123.");
            try
            {

                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("select * from Kullanicilar where kullaniciAdi = '" + kullaniciAdi + "' AND Sifre = '" + sifre + "'", baglanti);
                MySqlDataReader okuyucu = komut.ExecuteReader();
                if (okuyucu.Read())
                {
                    k = new Kullanıcılar();
                    k.KullanicilarId = Convert.ToInt32(okuyucu[0]);
                    k.AdSoyad = okuyucu[1].ToString();
                    k.KullaniciAdi = okuyucu[2].ToString();
                    k.Sifre = okuyucu[3].ToString();
                    k.Rol = okuyucu[4].ToString();
                    k.Telefon = okuyucu[5].ToString();
                   
                }
                baglanti.Close();


            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + ex.Message);
            }
            return k;


        }
        public System.Data.DataTable TumMusterileriGetir()
        {

            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430058;User ID=26_132430058;Password=İnif123.");


            MySqlDataAdapter da = new MySqlDataAdapter("SELECT MusteriId, AdSoyad FROM Musteriler", baglanti);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            return dt;
        }
        public System.Data.DataTable PersonelListesiGetir()
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430058;User ID=26_132430058;Password=İnif123.");
            string  komut = "SELECT KullanicilarId, CONCAT(AdSoyad, ' (', Rol, ')') AS GorunenAd FROM Kullanicilar";
            MySqlDataAdapter da = new MySqlDataAdapter(komut, baglanti);
            System.Data.DataTable dt = new System.Data.DataTable();

            try
            {
                baglanti.Open();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                throw;
            }
            finally
            {
                baglanti.Close();
            }
        }
    }
}
