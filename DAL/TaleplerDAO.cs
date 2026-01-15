using MusteriIliskileriVeHizmetTalepYonetimi.Domain;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nypDönemSonuProje.DAL
{
    internal class TaleplerDAO
    {
        public void taleplerKaydet(Talepler gTalepler)
        {
            gTalepler.OnaylananFiyat = HizmetFiyatiniBul(gTalepler.HizmetId);
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430058;User ID=26_132430058; Password=İnif123.");
            baglanti.Open();
            new MySqlCommand("INSERT INTO Talepler (musteriId, hizmetId, durum,  aciklama, olusturmaTarihi, onaylananFiyat) " +
             "VALUES (" +
             gTalepler.MusteriId + ", " +
             gTalepler.HizmetId + ", '" +
             gTalepler.Durum + "', '" +
             gTalepler.Aciklama + "', '" +
             gTalepler.OlusturmaTarihi.ToString("yyyy-MM-dd HH:mm:ss") + "', " + 
             gTalepler.OnaylananFiyat.ToString(System.Globalization.CultureInfo.InvariantCulture) + ")",baglanti).ExecuteNonQuery();
            baglanti.Close();
        }
        public void taleplerSil(int gTalepId)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430058;User ID=26_132430058; Password=İnif123.");
            baglanti.Open();
            new MySqlCommand("delete from Talepler where  talepId=" + gTalepId, baglanti).ExecuteNonQuery();
            baglanti.Close();
        }
        public void taleplerGuncelle(Talepler t)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430058;User ID=26_132430058;Password=İnif123.");
            string tarihDegeri = "NULL";
            if (t.Durum != null && t.Durum.Trim() == "Tamamlandı")
            {
                tarihDegeri = "NOW()";
            }
            MySqlCommand komut = new MySqlCommand("UPDATE Talepler SET " +
                           "musteriId='" + t.MusteriId + "', " +
                           "hizmetId='" + t.HizmetId + "', " +
                           "personelId='" + t.PersonelId + "', " +
                           "durum='" + t.Durum + "', " +
                           "aciklama='" + t.Aciklama + "', " +
                           "tamamlanmaTarihi=" + tarihDegeri + " " +
                           "WHERE talepId=" + t.TalepId, baglanti);
            try
            {
                baglanti.Open();
                komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                 MessageBox.Show("Güncelleme başarısız: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }
        public  List<Talepler> taleplerGetir()
        {
            List<Talepler> talepler = new List<Talepler>();
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430058;User ID=26_132430058;Password=İnif123.");

            MySqlCommand komut = new MySqlCommand("SELECT t.*, k.AdSoyad FROM Talepler t " +
                 "LEFT JOIN Kullanicilar k ON t.personelId = k.KullanicilarId", baglanti);
            try
            {
                baglanti.Open();
                MySqlDataReader okuyucu = komut.ExecuteReader();

                while (okuyucu.Read())
                {
                    Talepler t = new Talepler();

                    t.TalepId = Convert.ToInt32(okuyucu["TalepId"]);
                    t.MusteriId = Convert.ToInt32(okuyucu["musteriId"]);
                    t.HizmetId = Convert.ToInt32(okuyucu["hizmetId"]);
                    t.Durum = okuyucu["durum"].ToString();
                    
                    t.Aciklama = okuyucu["aciklama"].ToString();
                    t.OlusturmaTarihi = Convert.ToDateTime(okuyucu["olusturmaTarihi"]);
                    t.Aciklama = okuyucu["aciklama"].ToString();
                    if (okuyucu["TamamlanmaTarihi"] != DBNull.Value)
                    {
                        t.TamamlanmaTarihi = Convert.ToDateTime(okuyucu["TamamlanmaTarihi"]);
                    }

                    if (okuyucu["onaylananFiyat"] != DBNull.Value)
                    {
                        t.OnaylananFiyat = Convert.ToDecimal(okuyucu["onaylananFiyat"]);
                    }
                    else
                    {
                        t.OnaylananFiyat = 0;
                    }
                    t.MusteriAdSoyad = MusteriAdiniBul(t.MusteriId);
                    t.HizmetAdi = HizmetAdiniBul(t.HizmetId);
                    if (okuyucu["AdSoyad"] != DBNull.Value)
                    {
                        t.AtananPersonelAdi = okuyucu["AdSoyad"].ToString();
                    }
                    else
                    {
                        t.AtananPersonelAdi = "Atanmadı"; 
                    }

                    talepler.Add(t);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            baglanti.Close();
            return talepler;
        }
        private string MusteriAdiniBul(int id)
        {
            string isim = "";
            MySqlConnection baglanti2 = new MySqlConnection("Server=172.21.54.253;Database=26_132430058;User ID=26_132430058;Password=İnif123.");
            try
            {
                baglanti2.Open();
                
                MySqlCommand komut = new MySqlCommand("SELECT AdSoyad FROM Musteriler WHERE MusteriId=" + id, baglanti2);
                MySqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    isim = oku["AdSoyad"].ToString();
                }
            }
            catch { }
            baglanti2.Close(); 

            return isim;
        }

        public System.Data.DataTable TalepGetir(int id)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430058;User ID=26_132430058;Password=İnif123.");
            string sql = "SELECT * FROM Talepler WHERE talepId = " + id;
            MySqlDataAdapter okuyucu = new MySqlDataAdapter(sql, baglanti);
            System.Data.DataTable dt = new System.Data.DataTable();

            try
            {
                baglanti.Open();
                okuyucu.Fill(dt);
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

        private string HizmetAdiniBul(int id)
        {
            string hizmet = "Bulunamadı (ID:" + id + ")"; 
            MySqlConnection baglanti2 = new MySqlConnection("Server=172.21.54.253;Database=26_132430058;User ID=26_132430058;Password=İnif123.");
            try
            {
                baglanti2.Open();
                MySqlCommand komut = new MySqlCommand("SELECT hizmetAdi FROM Hizmetler WHERE hizmetId=" + id, baglanti2);

                MySqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    hizmet = oku["hizmetAdi"].ToString();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Hizmet Hatası: " + ex.Message);
            }
            finally
            {
                baglanti2.Close();
            }
            return hizmet;
        }
        public decimal HizmetFiyatiniBul(int hizmetId)
        {
            decimal fiyat = 0;
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430058;User ID=26_132430058;Password=İnif123.");
            try
            {
                baglanti.Open();
                string sql = "SELECT fiyat FROM Hizmetler WHERE hizmetId=" + hizmetId;
                MySqlCommand komut = new MySqlCommand(sql, baglanti);
                object sonuc = komut.ExecuteScalar();
                if (sonuc == null)
                {
                    System.Windows.Forms.MessageBox.Show("HATA: Veritabanında bu ID (" + hizmetId + ") ile kayıtlı bir hizmet bulunamadı!");
                }
                else if (sonuc == DBNull.Value)
                {
                    System.Windows.Forms.MessageBox.Show("HATA: Hizmet bulundu ama 'ucret' sütunu BOŞ (Null)!");
                }
                else
                {
                    
                    fiyat = Convert.ToDecimal(sonuc);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("KRİTİK HATA: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            return fiyat;
        }
        public System.Data.DataTable TariheGoreSonBesTalep()
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430058;User ID=26_132430058;Password=İnif123.");
            string sql = "SELECT t.talepId, m.adSoyad as Musteriler, h.hizmetAdi as Hizmetler, t.durum, t.olusturmaTarihi " +
                         "FROM Talepler t " +
                         "JOIN Musteriler m ON t.musteriId = m.musteriId " +
                         "JOIN Hizmetler h ON t.hizmetId = h.HizmetId " +
                         "ORDER BY t.OlusturmaTarihi DESC LIMIT 5";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, baglanti);
            System.Data.DataTable dt = new System.Data.DataTable();
            try
            {
                baglanti.Open();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            return dt;
        }
        public System.Data.DataTable DurumIstatistikleriniGetir()
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430058;User ID=26_132430058;Password=İnif123.");
            string sql = "SELECT Durum, COUNT(*) as Sayi FROM Talepler GROUP BY Durum";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, baglanti);
            System.Data.DataTable dt = new System.Data.DataTable();
            try
            {
                baglanti.Open();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Grafik verisi çekilemedi: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

            return dt;
        }
    }
    
    
}
