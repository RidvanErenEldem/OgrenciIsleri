using DataAccess.Entities;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.DAO.Base
{
    public class DekanDAOBase
    {
        public static Dekan LoginChecker(string UserName, string UserPass)
        {
            UserPass = Password.Encrypt(UserPass);
            Connection ConnectAndRun = new Connection();
            SqlCommand Cmd = ConnectAndRun.CreateQuery("Select * from Dekan where Aktif = 1");
            SqlDataReader sqlDataReader = Cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (sqlDataReader.Read())
            {
                if (UserName == sqlDataReader["KullaniciAdi"].ToString() && UserPass == sqlDataReader["Sifre"].ToString())
                {
                    Dekan dekan = new Dekan
                    {
                        Id = Convert.ToInt32(sqlDataReader["Id"]),
                        Ad = sqlDataReader["Ad"].ToString(),
                        Soyad = sqlDataReader["Soyad"].ToString(),
                        KullaniciAdi = sqlDataReader["KullaniciAdi"].ToString(),
                        Sifre = sqlDataReader["Sifre"].ToString(),
                        Aktif = Convert.ToBoolean(sqlDataReader["Aktif"])
                    };
                    return dekan;
                }
            }
            return null;
        }
    }
}
