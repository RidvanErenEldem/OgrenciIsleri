using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataAccess.DAO.Base
{
    public class NotlarDAOBase
    {
        public static DataTable GetScoresForHead(int Id, int OgrenciId)
        {
            try
            {
                Connection ConnectAndRun = new Connection();
                using (ConnectAndRun.OpenConnection())
                {
                    string Query = "Select Ogrenci.Ad, Ogrenci.Soyad, Ogrenci.Cinsiyet,Ogrenci.Numara,Ders.Ad as 'Ders Adı', Vize , Final, Ortalama from Notlar " +
                        "inner join Ogrenci on OgrenciId = Ogrenci.Id " +
                        "inner join Ders on DersId = Ders.Id " +
                        "where Notlar.Aktif = 1 and Ogrenci.Aktif = 1 and Ogrenci.BolumId = " + Id.ToString() + " and Ogrenci.Id = " + OgrenciId.ToString();

                    var dt = new DataTable();
                    SqlCommand Cmd = ConnectAndRun.CreateQuery(Query);
                    dt.Load(Cmd.ExecuteReader());

                    return dt;
                }
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message);
                return null;
            }
        }
        public static bool UpdateScore(Notlar notlar, bool Choose)
        {
            try
            {
                Connection ConnectAndRun = new Connection();
                using (ConnectAndRun.OpenConnection())
                {
                    string Query = null;
                    if (Choose == true)
                        Query = "UPDATE Notlar set Vize = @Notu where Id = @Id";
                    else
                        Query = "UPDATE Notlar set Final = @Notu where Id = @Id";

                    SqlCommand Cmd = ConnectAndRun.CreateQuery(Query);

                    Cmd.Parameters.Add("@Notu", SqlDbType.Int).Value = notlar.Vize;
                    Cmd.Parameters.Add("@Id", SqlDbType.Int).Value = notlar.Id;
                    Cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch(Exception Err)
            {
                MessageBox.Show(Err.Message);
                return false;
            }
        }
        public static DataTable GetScoresForAcademician(int Id, int AId)
        {
            try
            {
                List<int> GettedData = new List<int>();
                string dummy = null;
                Connection ConnectAndRun = new Connection();
                using (ConnectAndRun.OpenConnection())
                {
                    string Query = "Select AlanOgrenciler from ders where Aktif = 1 and AlanOgrenciler is NOT NULL and Id = " + Id.ToString();

                    SqlCommand Cmd = ConnectAndRun.CreateQuery(Query);
                    SqlDataReader sqlDataReader = Cmd.ExecuteReader(CommandBehavior.CloseConnection);

                    while (sqlDataReader.Read())
                    {
                        for (int i = 0; i < sqlDataReader["AlanOgrenciler"].ToString().Length; i += 2)
                        {
                            dummy = sqlDataReader["AlanOgrenciler"].ToString().Substring(i, 2);
                            GettedData.Add(Convert.ToInt32(dummy));
                        }
                    }
                }
                string Query2 = "IF NOT EXISTS (select * from notlar where OgrenciId = @OgrenciId and DersId = @DersId)" +
                    "INSERT INTO Notlar values (@OgrenciId, @Vize, @Final,@DersId, @Aktif)";
                for (int i = 0; i < GettedData.Count; i++)
                {
                    using(ConnectAndRun.OpenConnection())
                    {
                        SqlCommand Cmd = ConnectAndRun.CreateQuery(Query2);
                        int data = GettedData[i];
                        Cmd.Parameters.Add("@OgrenciId", SqlDbType.Int).Value = data;
                        Cmd.Parameters.Add("@DersId", SqlDbType.Int).Value = Id;
                        Cmd.Parameters.Add("@Vize", SqlDbType.Int).Value = DBNull.Value;
                        Cmd.Parameters.Add("@Final", SqlDbType.Int).Value = DBNull.Value;
                        Cmd.Parameters.Add("@Aktif", SqlDbType.Bit).Value = true;

                        Cmd.ExecuteNonQuery();
                    }
                }
                using(ConnectAndRun.OpenConnection())
                {
                    string Query = "Select Notlar.Id, OgrenciId, Ogrenci.Ad, Ogrenci.Soyad, Ogrenci.Numara, Ders.Ad as 'Ders Adı', Kredi, Vize, Final, Ortalama from Ders " +
                        " inner join Notlar on Ders.Id = Notlar.DersId " +
                        "inner join Ogrenci on Notlar.OgrenciId = Ogrenci.Id " +
                        "where AkademisyenId = @AkademisyenId and Ogrenci.Aktif = 1 and Ders.Aktif = 1 and DersId = @DersId";

                    SqlCommand Cmd = ConnectAndRun.CreateQuery(Query);

                    Cmd.Parameters.Add("@AkademisyenId", SqlDbType.Int).Value = AId;
                    Cmd.Parameters.Add("@DersId", SqlDbType.Int).Value = Id;

                    var dt = new DataTable();
                    dt.Load(Cmd.ExecuteReader());
                    dt.Columns["Id"].ColumnMapping = MappingType.Hidden;
                    dt.Columns["OgrenciId"].ColumnMapping = MappingType.Hidden;

                    return dt;
                }
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message);
                return null;
            }
        }
    }
}
