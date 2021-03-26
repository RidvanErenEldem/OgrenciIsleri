using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataAccess.DAO.Base
{
    public class OgrenciDAOBase
    {
        public static DataTable GetData(int BolumId)
        {
            try
            {
                List<Ogrenci> Ogrenciler = new List<Ogrenci>();
                Connection ConnectAndRun = new Connection();
                using (ConnectAndRun.OpenConnection())
                {
                    string Query = "Select Ogrenci.Id, Numara, Ogrenci.Ad, Ogrenci.Soyad, Fakulte.Ad as 'Fakülte Adı', " +
                        "Bolum.Ad as 'Bolüm Adı', Ogrenci.Cinsiyet, Ogrenci.FakulteId, " +
                        "Ogrenci.BolumId, AlinanDersler, Onay, Ogrenci.Aktif, Ogrenci.Donem as Dönem from Ogrenci " +
                        "inner join Bolum on Ogrenci.BolumId = Bolum.Id " +
                        "inner join Fakulte on Ogrenci.FakulteId = Fakulte.Id " +
                        "where Ogrenci.Aktif = 1 and Bolum.Aktif = 1 and Fakulte.Aktif = 1 and Ogrenci.BolumId = " + BolumId.ToString();

                    var dt = new DataTable();
                    SqlCommand Cmd = ConnectAndRun.CreateQuery(Query);
                    dt.Load(Cmd.ExecuteReader());
                    dt.Columns["Id"].ColumnMapping = MappingType.Hidden;
                    dt.Columns["FakulteId"].ColumnMapping = MappingType.Hidden;
                    dt.Columns["BolumId"].ColumnMapping = MappingType.Hidden;
                    dt.Columns["AlinanDersler"].ColumnMapping = MappingType.Hidden;
                    dt.Columns["Aktif"].ColumnMapping = MappingType.Hidden;

                    return dt;
                }

            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message);
                return null;
            }
        }

        public static Ogrenci LoginChecker(string UserName, string UserPass)
        {
            UserPass = Password.Encrypt(UserPass);
            Connection ConnectAndRun = new Connection();
            SqlCommand Cmd = ConnectAndRun.CreateQuery("Select * from Ogrenci where Aktif = 1");
            SqlDataReader sqlDataReader = Cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (sqlDataReader.Read())
            {
                if (UserName == sqlDataReader["KullaniciAdi"].ToString() && UserPass == sqlDataReader["Sifre"].ToString())
                {
                    Ogrenci ogrenci = new Ogrenci
                    {
                        Id = Convert.ToInt32(sqlDataReader["Id"]),
                        Ad = sqlDataReader["Ad"].ToString(),
                        Soyad = sqlDataReader["Soyad"].ToString(),
                        Numara = sqlDataReader["Numara"].ToString(),
                        Cinsiyet = Convert.ToBoolean(sqlDataReader["Cinsiyet"]),
                        FakulteId = Convert.ToInt32(sqlDataReader["FakulteId"]),
                        BolumId = Convert.ToInt32(sqlDataReader["BolumId"]),
                        AlinanDersler = sqlDataReader["AlinanDersler"].ToString(),
                        KullaniciAdi = sqlDataReader["KullaniciAdi"].ToString(),
                        Sifre = sqlDataReader["Sifre"].ToString(),
                        Onay = Convert.ToBoolean(sqlDataReader["Onay"]),
                        Aktif = Convert.ToBoolean(sqlDataReader["Aktif"]),
                        Donem = Convert.ToByte(sqlDataReader["Donem"]),
                        OnceOnay = Convert.ToBoolean(sqlDataReader["OnceOnay"])
                    };
                    return ogrenci;
                }
            }
            return null;
        }

        public static DataTable GetScoresForStudent(int Id, int DonemId)
        {
            try
            {
                Connection ConnectAndRun = new Connection();
                using (ConnectAndRun.OpenConnection())
                {
                    string Query = "select Ders.Ad, Vize, Final, Ortalama, " +
                        "CONCAT(Akademisyen.Ad, ' ', Akademisyen.Soyad) as 'Akademisyen Adı Soyadı' from Notlar " +
                        "inner join Ogrenci on Ogrenci.Id = OgrenciId " +
                        "inner join Ders on DersId = Ders.Id " +
                        "inner join Akademisyen on AkademisyenId = Akademisyen.Id " +
                        "where Ogrenci.Id = " + Id.ToString() + " and Ogrenci.Donem = " + DonemId.ToString();

                    SqlCommand Cmd = ConnectAndRun.CreateQuery(Query);

                    var dt = new DataTable();
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

        public static DataTable GetOneStudentData(Ogrenci ogrenci)
        {
            try
            {
                Connection ConnectAndRun = new Connection();
                using (ConnectAndRun.OpenConnection())
                {
                    string Query = "select Ogrenci.Ad, Ogrenci.Soyad, Numara, Cinsiyet, Fakulte.Ad as FakulteAd, Bolum.Ad as BolumAd from ogrenci " +
                        "inner join Fakulte on Ogrenci.FakulteId = Fakulte.Id " +
                        "inner join Bolum on Ogrenci.BolumId = Bolum.Id " +
                        "where Ogrenci.Aktif = 1 and Fakulte.Aktif = 1 and Bolum.Aktif = 1 and Ogrenci.Id = " + ogrenci.Id.ToString();

                    SqlCommand Cmd = ConnectAndRun.CreateQuery(Query);

                    var dt = new DataTable();
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

        public static bool Approve(Ogrenci ogrenci)
        {
            try
            {
                Connection ConnectAndRun = new Connection();
                using (ConnectAndRun.OpenConnection())
                {
                    string Query = "UPDATE ogrenci set Onay = 1 where Aktif = 1 and Id = @Id";
                    SqlCommand Cmd = ConnectAndRun.CreateQuery(Query);

                    Cmd.Parameters.Add("@Id", SqlDbType.Int).Value = ogrenci.Id;
                    Cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message);
                return false;
            }
        }

        public static DataTable GetLessons(int DonemId, int BolumId)
        {
            try
            {
                Connection ConnectAndRun = new Connection();
                using (ConnectAndRun.OpenConnection())
                {
                    string Query = "Select ders.Id, ders.Ad, ders.Kredi,CONCAT(Akademisyen.Ad,' ',Akademisyen.Soyad) as 'Akademisyen Adı', Donem from ders " +
                        "inner join Akademisyen on AkademisyenId = Akademisyen.Id " +
                        "where Donem = @Donem and (ders.BolumId = 1 or Ders.BolumId=@Bolum)";

                    SqlCommand Cmd = ConnectAndRun.CreateQuery(Query);

                    Cmd.Parameters.Add("@Donem", SqlDbType.Int).Value = DonemId;
                    Cmd.Parameters.Add("@Bolum", SqlDbType.Int).Value = BolumId;

                    var dt = new DataTable();
                    dt.Load(Cmd.ExecuteReader());
                    dt.Columns["Id"].ColumnMapping = MappingType.Hidden;
                    return dt;
                }
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message);
                return null;
            }
        }

        public static bool AddLessons(int Id, string Classes)
        {
            try
            {
                Connection ConnectAndRun = new Connection();
                using (ConnectAndRun.OpenConnection())
                {
                    string Query = "UPDATE Ogrenci set AlinanDersler = @AlinanDersler, OnceOnay = 1 where Id = @Id";
                    SqlCommand Cmd = ConnectAndRun.CreateQuery(Query);

                    Cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
                    Cmd.Parameters.Add("@AlinanDersler", SqlDbType.NVarChar).Value = Classes;

                    Cmd.ExecuteNonQuery();
                }
                int dummy = Id;
                int basamak = 0;
                string Add;

                while (dummy >= 1)
                {
                    dummy /= 10;
                    basamak++;
                }
                if (basamak == 1)
                    Add = "0" + Id.ToString();
                else
                    Add = Id.ToString();

                string Query2 = "UPDATE ders set AlanOgrenciler = CONCAT(AlanOgrenciler, @AlanOgrenciler) where Id = @Id";
                List<int> DersIds = new List<int>();
                string dummyString = null;

                for (int i = 0; i < Classes.Length; i += 2)
                {
                    dummyString = Classes.Substring(i, 2);
                    DersIds.Add(Convert.ToInt32(dummyString));
                }
                for (int i = 0; i < DersIds.Count; i++)
                {
                    using (ConnectAndRun.OpenConnection())
                    {
                        SqlCommand Cmd = ConnectAndRun.CreateQuery(Query2);

                        Cmd.Parameters.Add("@AlanOgrenciler", SqlDbType.NVarChar).Value = Add;
                        Cmd.Parameters.Add("@Id", SqlDbType.Int).Value = DersIds[i];

                        Cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message);
                return false;
            }
        }

        public static bool AddUpdateDeleteStudent(Ogrenci ogrenci, int Choose)
        {
            try
            {
                Connection ConnectAndRun = new Connection();
                using (ConnectAndRun.OpenConnection())
                {
                    string Query = null;

                    if (Choose == 0)
                        Query = "INSERT INTO Ogrenci values (@Ad, @Soyad, @Numara, @Cinsiyet, @FakulteId, @BolumId, @AlinanDersler, @KullaniciAdi, @Sifre, @Onay, @Aktif, @Donem, @OnceOnay)";
                    else if (Choose == 1)
                        Query = "UPDATE Ogrenci set Ad = @Ad, Soyad = @Soyad, Numara = @Numara, Cinsiyet = @Cinsiyet where Id = @Id";
                    else
                        Query = "UPDATE Ogrenci set Aktif = 0 where Id = @Id";

                    SqlCommand Cmd = ConnectAndRun.CreateQuery(Query);

                    if (Choose == 0)
                    {
                        Cmd.Parameters.Add("@Ad", SqlDbType.NVarChar).Value = ogrenci.Ad;
                        Cmd.Parameters.Add("@Soyad", SqlDbType.NVarChar).Value = ogrenci.Soyad;
                        Cmd.Parameters.Add("@Numara", SqlDbType.NChar).Value = ogrenci.Numara;
                        Cmd.Parameters.Add("@Cinsiyet", SqlDbType.Bit).Value = ogrenci.Cinsiyet;
                        Cmd.Parameters.Add("@FakulteId", SqlDbType.Int).Value = ogrenci.FakulteId;
                        Cmd.Parameters.Add("@BolumId", SqlDbType.Int).Value = ogrenci.BolumId;
                        Cmd.Parameters.Add("@AlinanDersler", SqlDbType.NVarChar).Value = ogrenci.AlinanDersler;
                        Cmd.Parameters.Add("@KullaniciAdi", SqlDbType.NVarChar).Value = ogrenci.KullaniciAdi;
                        Cmd.Parameters.Add("@Sifre", SqlDbType.NVarChar).Value = ogrenci.Sifre;
                        Cmd.Parameters.Add("@Onay", SqlDbType.Bit).Value = ogrenci.Onay;
                        Cmd.Parameters.Add("@Aktif", SqlDbType.Bit).Value = ogrenci.Aktif;
                        Cmd.Parameters.Add("@Donem", SqlDbType.TinyInt).Value = ogrenci.Donem;
                        Cmd.Parameters.Add("@OnceOnay", SqlDbType.Bit).Value = false;
                    }
                    else if (Choose == 1)
                    {
                        Cmd.Parameters.Add("@Ad", SqlDbType.NVarChar).Value = ogrenci.Ad;
                        Cmd.Parameters.Add("@Soyad", SqlDbType.NVarChar).Value = ogrenci.Soyad;
                        Cmd.Parameters.Add("@Numara", SqlDbType.NChar).Value = ogrenci.Numara;
                        Cmd.Parameters.Add("@Cinsiyet", SqlDbType.Bit).Value = ogrenci.Cinsiyet;
                        Cmd.Parameters.Add("@Id", SqlDbType.Int).Value = ogrenci.Id;
                    }
                    else
                    {
                        Cmd.Parameters.Add("@Id", SqlDbType.Int).Value = ogrenci.Id;
                        Cmd.Parameters.Add("@Aktif", SqlDbType.Bit).Value = ogrenci.Aktif;
                    }
                    Cmd.ExecuteNonQuery();

                    
                }
                if(Choose == 0)
                {
                    int Id = 0;

                    using (ConnectAndRun.OpenConnection())
                    {
                        SqlCommand Cmd = ConnectAndRun.CreateQuery("select max(ID) as Id from ogrenci");
                        SqlDataReader sqlDataReader = Cmd.ExecuteReader(CommandBehavior.CloseConnection);
                        while (sqlDataReader.Read())
                        {
                            Id = Convert.ToInt32(sqlDataReader["Id"]);
                        }
                    }

                    int dummy = Id;
                    int basamak = 0;
                    string Add;

                    while (dummy >= 1)
                    {
                        dummy /= 10;
                        basamak++;
                    }
                    if (basamak == 1)
                        Add = "0" + Id.ToString();
                    else
                        Add = Id.ToString();

                    using (ConnectAndRun.OpenConnection())
                    {
                        string Query2 = "UPDATE ders set AlanOgrenciler = CONCAT(AlanOgrenciler, @AlanOgrenciler) where Id = @Id";
                        List<int> DersIds = new List<int>();
                        string dummyString = null;

                        for (int i = 0; i < ogrenci.AlinanDersler.Length; i += 2)
                        {
                            dummyString = ogrenci.AlinanDersler.Substring(i, 2);
                            DersIds.Add(Convert.ToInt32(dummyString));
                        }
                        for (int i = 0; i < DersIds.Count; i++)
                        {
                            using (ConnectAndRun.OpenConnection())
                            {
                                SqlCommand Cmd2 = ConnectAndRun.CreateQuery(Query2);

                                Cmd2.Parameters.Add("@AlanOgrenciler", SqlDbType.NVarChar).Value = Add;
                                Cmd2.Parameters.Add("@Id", SqlDbType.Int).Value = DersIds[i];

                                Cmd2.ExecuteNonQuery();
                            }
                        }
                    }
                }
                
                return true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return false;
            }

        }
    }
}
