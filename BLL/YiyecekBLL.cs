using DAL.Context;
using Entities;
using Entities.Enums;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class YiyecekBLL : ICRUD<Yiyecek>
    {
        CaloCalcDbContext Db;
        public YiyecekBLL()
        {
            Db = new CaloCalcDbContext();
        }
        public Yiyecek Ara(int id)
        {
            return Db.Yiyecekler.Find(id);
        }

        public bool Ekle(Yiyecek entity)
        {
            Db.Yiyecekler.Add(entity);
            if (Db.SaveChanges() > 0)
                return true;
            else
                return false;
        }

        public bool Guncelle(Yiyecek entity)
        {
            Db.Yiyecekler.Update(entity);
            return Db.SaveChanges() > 0;

        }

        public List<Yiyecek> Liste()
        {
            return Db.Yiyecekler.ToList();
        }

        public bool Sil(int id)
        {
            Db.Yiyecekler.Remove(Ara(id));
            return Db.SaveChanges() > 0;
        }


        public Yiyecek AdaGoreAra(string yiyecekAdi)
        {
            return Db.Yiyecekler.FirstOrDefault(x => x.YiyecekAdi == yiyecekAdi);
        }

        public List<Yiyecek> EnCokYenenler()
        {
            string connectionString = "Data Source=DESKTOP-JSFRVR1\\MSSQLKD15;Initial Catalog=Prj_KD15_CaloCalc;Integrated Security=True";
            string query = "SELECT TOP 10 y.YiyecekAdi,y.Kalori,o.OgunAdi, COUNT(*) AS 'Toplam' FROM Ogunler o JOIN Yiyecekler y ON o.YiyecekID=y.YiyecekID GROUP BY y.YiyecekAdi,y.Kalori,o.OgunAdi ORDER BY Toplam DESC"; ;

            List<Yiyecek> results = new List<Yiyecek>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string yiyecekAdi = reader["YiyecekAdi"].ToString();
                    int toplam = Convert.ToInt32(reader["Toplam"]);
                    int kalori = Convert.ToInt32(reader["Kalori"]);
                    int ogun = Convert.ToInt32(reader["OgunAdi"]);
                    results.Add(new Yiyecek(yiyecekAdi, toplam,kalori,ogun));
                }
            }

            return results;
        }
        public List<Yiyecek> EnCokYediklerim(int id,int gün)
        {
            string connectionString = "Data Source=DESKTOP-JSFRVR1\\MSSQLKD15;Initial Catalog=Prj_KD15_CaloCalc;Integrated Security=True";
            string query = $"SELECT TOP 10 y.YiyecekAdi,y.Kalori,o.OgunAdi, COUNT(*) AS 'Toplam'FROM Ogunler o JOIN Yiyecekler y ON o.YiyecekID=y.YiyecekID where o.YemekYemeZamani >= DATEADD(day, -{gün}, GETDATE()) and o.KullaniciID={id} GROUP BY y.YiyecekAdi,y.Kalori,o.OgunAdi,o.KullaniciID ORDER BY Toplam DESC";
            List<Yiyecek> results = new List<Yiyecek>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string yiyecekAdi = reader["YiyecekAdi"].ToString();
                    int toplam = Convert.ToInt32(reader["Toplam"]);
                    int kalori = Convert.ToInt32(reader["Kalori"]);
                    int ogun = Convert.ToInt32(reader["OgunAdi"]);
                    results.Add(new Yiyecek(yiyecekAdi, toplam, kalori, ogun));
                }
            }

            return results;
        }
        

        public List<Yiyecek> EnCokYedikleri(int id, int gün)
        {
            string connectionString = "Data Source=DESKTOP-JSFRVR1\\MSSQLKD15;Initial Catalog=Prj_KD15_CaloCalc;Integrated Security=True";
            string query = $"SELECT TOP 10 y.YiyecekAdi,y.Kalori,o.OgunAdi, COUNT(*) AS 'Toplam'FROM Ogunler o JOIN Yiyecekler y ON o.YiyecekID=y.YiyecekID where o.YemekYemeZamani >= DATEADD(day, -{gün}, GETDATE()) and o.KullaniciID!={id} GROUP BY y.YiyecekAdi,y.Kalori,o.OgunAdi,o.KullaniciID ORDER BY Toplam DESC";
            List<Yiyecek> results = new List<Yiyecek>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string yiyecekAdi = reader["YiyecekAdi"].ToString();
                    int toplam = Convert.ToInt32(reader["Toplam"]);
                    int kalori = Convert.ToInt32(reader["Kalori"]);
                    int ogun = Convert.ToInt32(reader["OgunAdi"]);
                    results.Add(new Yiyecek(yiyecekAdi, toplam, kalori, ogun));
                }
            }

            return results;
        }




    }
}
