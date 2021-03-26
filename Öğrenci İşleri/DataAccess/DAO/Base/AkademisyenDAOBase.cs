using System.Collections.Generic;
using DataAccess.Entities;
using System.Data.SqlClient;
using System.Data;
using System;
using System.Windows.Forms;

namespace DataAccess.DAO.Base
{
    public class AkademisyenDAOBase
    {
        public static bool AddAcademican(Akademisyen akademisyen)
        {
            try
            {
                Connection ConnectAndRun = new Connection();
                using(ConnectAndRun.OpenConnection())
                {
                    string Query = "INSERT INTO Akademisyen values (@Ad, @Soyad,@Tcno,@Cinsiyet,@FakulteId,@BolumId,@KullaniciAdi,@Sifre,@Yetki,@Aktif)";

                    SqlCommand Cmd = ConnectAndRun.CreateQuery(Query);

                    Cmd.Parameters.Add("@Ad", SqlDbType.NVarChar ).Value = akademisyen.Ad;
                    Cmd.Parameters.Add("@Soyad", SqlDbType.NVarChar ).Value = akademisyen.Soyad;
                    Cmd.Parameters.Add("@Tcno", SqlDbType.NChar ).Value = akademisyen.Tcno;
                    Cmd.Parameters.Add("@Cinsiyet", SqlDbType.Bit ).Value = akademisyen.Cinsiyet;
                    Cmd.Parameters.Add("@FakulteId", SqlDbType.Int ).Value = akademisyen.FakulteId;
                    Cmd.Parameters.Add("@BolumId", SqlDbType.Int ).Value = akademisyen.BolumId;
                    Cmd.Parameters.Add("@KullaniciAdi", SqlDbType.NVarChar ).Value = akademisyen.KullaniciAdi;
                    Cmd.Parameters.Add("@Sifre", SqlDbType.NVarChar ).Value = akademisyen.Sifre;
                    Cmd.Parameters.Add("@Yetki", SqlDbType.TinyInt ).Value = akademisyen.Yetki;
                    Cmd.Parameters.Add("@Aktif", SqlDbType.Bit ).Value = true;

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
        public static bool ChangePass(int Id, string OldPass, string NewPass, string UserName, bool Choose)
        {
            try
            {
                bool Found = false;
                OldPass = Password.Encrypt(OldPass);
                Connection ConnectAndRun = new Connection();
                using(ConnectAndRun.OpenConnection())
                {
                    string Query = null;
                    if (Choose == true)
                        Query = "Select KullaniciAdi, Sifre from Akademisyen";
                    else
                        Query = "Select KullaniciAdi, Sifre from Ogrenci";

                    SqlCommand Cmd = ConnectAndRun.CreateQuery(Query);
                    SqlDataReader sqlDataReader = Cmd.ExecuteReader(CommandBehavior.CloseConnection);

                    while(sqlDataReader.Read())
                    {
                        if (UserName == sqlDataReader["KullaniciAdi"].ToString() && OldPass == sqlDataReader["Sifre"].ToString())
                        {
                            Found = true;
                            break;
                        }     
                    }
                    
                }
                if(Found == true)
                {
                    using (ConnectAndRun.OpenConnection())
                    {
                        NewPass = Password.Encrypt(NewPass);
                        string Query = null;
                        if (Choose == true)
                            Query = "UPDATE Akademisyen set Sifre = @Sifre where Id = " + Id.ToString();
                        else
                            Query = "UPDATE Ogrenci set Sifre = @Sifre where Id = " + Id.ToString();

                        SqlCommand Cmd = ConnectAndRun.CreateQuery(Query);
                        Cmd.Parameters.Add("@Sifre", SqlDbType.NVarChar).Value = NewPass;
                        Cmd.ExecuteNonQuery();
                    }
                    return true;
                }
                else
                {
                    MessageBox.Show("Girdiğiniz Şifre Hatalı", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch(Exception Err)
            {
                MessageBox.Show(Err.Message);
                return false;
            }
        }

        public static Akademisyen LoginChecker(string UserName, string UserPass)
        {
            UserPass = Password.Encrypt(UserPass);
            Connection ConnectAndRun = new Connection();
            SqlCommand Cmd = ConnectAndRun.CreateQuery("Select * from Akademisyen where Aktif = 1");
            SqlDataReader sqlDataReader = Cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while(sqlDataReader.Read())
            {
                if (UserName == sqlDataReader["KullaniciAdi"].ToString() && UserPass == sqlDataReader["Sifre"].ToString())
                {
                    Akademisyen akademisyen = new Akademisyen
                    {
                        Id = Convert.ToInt32(sqlDataReader["Id"]),
                        Ad = sqlDataReader["Ad"].ToString(),
                        Soyad = sqlDataReader["Soyad"].ToString(),
                        Tcno = sqlDataReader["Tcno"].ToString(),
                        Cinsiyet = Convert.ToBoolean(sqlDataReader["Cinsiyet"]),
                        FakulteId = Convert.ToInt32(sqlDataReader["FakulteId"]),
                        BolumId = Convert.ToInt32(sqlDataReader["BolumId"]),
                        KullaniciAdi = sqlDataReader["KullaniciAdi"].ToString(),
                        Sifre = sqlDataReader["Sifre"].ToString(),
                        Yetki = Convert.ToInt32(sqlDataReader["Yetki"]),
                        Aktif = Convert.ToBoolean(sqlDataReader["Aktif"])
                    };
                    return akademisyen;
                }
            }
            return null;
        }
        public static List<Akademisyen> FillComboBox(int BolumId)
        {
            List<Akademisyen> Akademisyenler = new List<Akademisyen>();
            Connection ConnectAndRun = new Connection();
            try
            {
                using (ConnectAndRun.OpenConnection())
                {
                    string Query = null;
                    if (BolumId == 1)
                        Query = "Select Id, Ad, Soyad from Akademisyen";
                    else
                        Query = "Select Id, Ad, Soyad from Akademisyen where BolumId = " + BolumId.ToString();

                    SqlCommand Cmd = ConnectAndRun.CreateQuery(Query);
                    SqlDataReader sqlDataReader = Cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (sqlDataReader.Read())
                    {
                        Akademisyen akademisyen = new Akademisyen
                        {
                            Id = Convert.ToInt32(sqlDataReader["Id"]),
                            Ad = sqlDataReader["Ad"].ToString() + " " + sqlDataReader["Soyad"].ToString()
                        };
                        Akademisyenler.Add(akademisyen);
                    }
                    return Akademisyenler;
                }
            }
            catch(Exception Err)
            {
                MessageBox.Show(Err.Message);
                return null;
            }
           
        }
    }
}
