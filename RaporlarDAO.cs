using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nypDönemSonuProje.DAL
{
    public class RaporlarDAO
    {
        private string baglantiCumlesi = "Server=172.21.54.253;Database=26_132430058;User ID=26_132430058; Password=İnif123.";

        private DataTable VeriCek(string sql)
        {
            using (MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi))
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter(sql, baglanti))
                {
                    DataTable dt = new DataTable();
                    try
                    {
                        baglanti.Open();
                        da.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SQL Hatası: " + ex.Message);
                    }
                    return dt;
                }
            }
        }

       
        public DataTable PersonelGetir()
        {
            
            string sql = @"
            SELECT 
                COALESCE(k.adSoyad, CONCAT('ID: ', t.personelId)) as Personel, 
                COUNT(*) as IsSayisi 
            FROM Talepler t
            LEFT JOIN Kullanicilar k ON t.personelId = k.kullanicilarId
            GROUP BY t.personelId, k.adSoyad 
            ORDER BY IsSayisi DESC";
            return VeriCek(sql);
        }

        public DataTable HizmetGetir()
        {
          
            string sql = @"
            SELECT 
                COALESCE(h.hizmetAdi, CONCAT('Kod: ', t.hizmetId)) as Hizmet, 
                COUNT(*) as Adet 
            FROM Talepler t
            LEFT JOIN Hizmetler h ON t.hizmetId = h.hizmetId
            GROUP BY t.hizmetId, h.hizmetAdi 
            ORDER BY Adet DESC";
            return VeriCek(sql);
        }

        public DataTable DurumDagilimiGetir()
        {
            
            string sql = "SELECT durum, COUNT(*) as Sayi FROM Talepler GROUP BY durum";
            return VeriCek(sql);
        }

       

    }
}
