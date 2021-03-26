using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataAccess.DAO.Base
{
    public class BolumDAOBase
    {
        public static bool AddBolum(string Name)
        {
            try
            {
                Connection ConnectAndRun = new Connection();
                using (ConnectAndRun.OpenConnection())
                {
                    string Query = "INSERT INTO Bolum values (@Ad, @Aktif)";

                    SqlCommand Cmd = ConnectAndRun.CreateQuery(Query);

                    Cmd.Parameters.Add("@Ad", SqlDbType.NVarChar).Value = Name;
                    Cmd.Parameters.Add("@Aktif", SqlDbType.Bit).Value = true;
                    Cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return false;
            }
        }

        public static List<Bolum> FillComboBox()
        {
            List<Bolum> Bolumler = new List<Bolum>();
            Connection ConnectAndRun = new Connection();
            try
            {
                using (ConnectAndRun.OpenConnection())
                {

                    string Query = "Select Id, Ad from Bolum where Id != 1";

                    SqlCommand Cmd = ConnectAndRun.CreateQuery(Query);
                    SqlDataReader sqlDataReader = Cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (sqlDataReader.Read())
                    {
                        Bolum bolum = new Bolum
                        {
                            Id = Convert.ToInt32(sqlDataReader["Id"]),
                            Ad = sqlDataReader["Ad"].ToString()
                        };
                        Bolumler.Add(bolum);
                    }
                    return Bolumler;
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
