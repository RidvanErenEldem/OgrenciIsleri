using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataAccess.DAO.Base
{
    public class DersDAOBase
    {
        public static bool AddUpdateDeleteLesson(Ders ders, int Choose)
        {
            try
            {
                Connection ConnectAndRun = new Connection();
                using (ConnectAndRun.OpenConnection())
                {
                    string Query = null;
                    if (Choose == 0)
                        Query = "INSERT INTO Ders VALUES (@Ad, @FakulteId, @BolumId, @AkademisyenId, @Kredi, @Aktif, @Donem)";
                    else if (Choose == 1)
                        Query = "UPDATE Ders set Ad = @Ad, AkademisyenId = @AkademisyenId, Aktif = @Aktif, Donem = @Donem where Id = @Id";
                    else
                        Query = "UPDATE Ders set Aktif = @Aktif where Id = @Id";

                    SqlCommand Cmd = ConnectAndRun.CreateQuery(Query);

                    if(Choose == 0)
                    {
                        Cmd.Parameters.Add("@FakulteId", SqlDbType.Int).Value = ders.FakulteId;
                        Cmd.Parameters.Add("@BolumId", SqlDbType.Int).Value = ders.BolumId;
                        Cmd.Parameters.Add("@Kredi", SqlDbType.TinyInt).Value = ders.Kredi;
                        Cmd.Parameters.Add("@Ad", SqlDbType.NVarChar).Value = ders.Ad;
                        Cmd.Parameters.Add("@AkademisyenId", SqlDbType.Int).Value = ders.AkademisyenId;
                        Cmd.Parameters.Add("@Aktif", SqlDbType.Bit).Value = ders.Aktif;
                        Cmd.Parameters.Add("@Donem", SqlDbType.TinyInt).Value = ders.Donem;
                    }
                    else if (Choose == 1)
                    {
                        Cmd.Parameters.Add("@Ad", SqlDbType.NVarChar).Value = ders.Ad;
                        Cmd.Parameters.Add("@AkademisyenId", SqlDbType.Int).Value = ders.AkademisyenId;
                        Cmd.Parameters.Add("@Aktif", SqlDbType.Bit).Value = ders.Aktif;
                        Cmd.Parameters.Add("@Donem", SqlDbType.TinyInt).Value = ders.Donem;
                        Cmd.Parameters.Add("@Id", SqlDbType.Int).Value = ders.Id;
                    }
                    else
                    {
                        Cmd.Parameters.Add("@Id", SqlDbType.Int).Value = ders.Id;
                        Cmd.Parameters.Add("@Aktif", SqlDbType.Bit).Value = ders.Aktif;
                    }
                    Cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
                return false;
            }
                
        }

        public static DataTable GetGridData(int BolumId)
        {
            Connection ConnectAndRun = new Connection();
            using(ConnectAndRun.OpenConnection())
            {
                string Query2 = "Select Ders.Id, Ders.Ad, Fakulte.Ad as FakulteAd, Bolum.Ad as BolumAd, Ders.AkademisyenId, CONCAT(Akademisyen.Ad, ' ', Akademisyen.Soyad) as AkademisyenAd, Kredi, Donem from Ders " +
                    "inner join akademisyen on AkademisyenId = akademisyen.Id " +
                    "inner join Bolum on Ders.BolumId = Bolum.Id " +
                    "inner join Fakulte on Ders.FakulteId = Fakulte.Id " +
                    "where Ders.Aktif = 1 and Akademisyen.Aktif = 1 and Fakulte.Aktif = 1 and Bolum.Aktif = 1 and Ders.BolumId = " + BolumId.ToString();

                var dt = new DataTable();
                
                SqlCommand Cmd2 = ConnectAndRun.CreateQuery(Query2);
                dt.Load(Cmd2.ExecuteReader());
                dt.Columns["Id"].ColumnMapping = MappingType.Hidden;
                dt.Columns["AkademisyenId"].ColumnMapping = MappingType.Hidden;
                

                return dt;
            }
        }
        public static DataTable ApprovingList(List<int> dersIds)
        {
            try
            {
                Connection ConncectAndRun = new Connection();
                using (ConncectAndRun.OpenConnection())
                {
                    var idList = string.Join(",", dersIds);
                    string Query = $"Select Ad From Ders where Id in ({idList}) and Aktif = 1";

                    var dt = new DataTable();

                    SqlCommand Cmd = ConncectAndRun.CreateQuery(Query);
                    dt.Load(Cmd.ExecuteReader());
                    return dt;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Bu Öğrenci Daha Ders Kaydı Yapmamış", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static List<Ders> FillComboBox(int AkademisyenId)
        {
            List<Ders> Dersler = new List<Ders>();
            Connection ConnectAndRun = new Connection();
            try
            {
                using(ConnectAndRun.OpenConnection())
                {
                    string Query = "select Id, Ad from Ders where AkademisyenId = @AkademisyenId and Ders.Aktif = 1";

                    SqlCommand Cmd = ConnectAndRun.CreateQuery(Query);
                    Cmd.Parameters.Add("@AkademisyenId", SqlDbType.Int).Value = AkademisyenId;

                    SqlDataReader sqlDataReader = Cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while(sqlDataReader.Read())
                    {
                        Ders ders = new Ders
                        {
                            Id = Convert.ToInt32(sqlDataReader["Id"]),
                            Ad = sqlDataReader["Ad"].ToString()
                        };
                        Dersler.Add(ders);
                    }
                    return Dersler;
                }
            }
            catch(Exception Err)
            {
                MessageBox.Show(Err.Message);
                return null;
            }
        }

        public static string GetFirst(int BolumId)
        {
            string Classes;
            List<String> GettedData = new List<String>();
            Connection ConnectAndRun = new Connection();
            using(ConnectAndRun.OpenConnection())
            {
                
                string Query = "Select Id from Ders where BolumId = 1 or BolumId = " + BolumId.ToString();

                SqlCommand Cmd = ConnectAndRun.CreateQuery(Query);
                SqlDataReader sqlDataReader = Cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while(sqlDataReader.Read())
                {
                    int basamak = 0;
                    int dummy= Convert.ToInt32(sqlDataReader["Id"]);
                    int real = dummy;
                    while (dummy >=1)
                    {
                        dummy /= 10;
                        basamak++;
                    }
                    if(basamak == 1)
                    {
                        string Add = "0" + real.ToString();
                        GettedData.Add(Add);
                    }
                    else
                        GettedData.Add(sqlDataReader["Id"].ToString());
                }
                
                    
            }
            Classes = string.Join("",GettedData);
            return Classes;
        }
    }
}
