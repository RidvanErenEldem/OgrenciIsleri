using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataAccess.DAO.Base
{
    public class FakulteDAOBase
    {
        public static bool AddFakulte(string Name)
        {
            try
            {
                Connection ConnectAndRun = new Connection();
                using (ConnectAndRun.OpenConnection())
                {
                    string Query = "INSERT INTO Fakulte values (@Ad, @Aktif)";

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

        public static List<Fakulte> FillComboBox()
        {
            List<Fakulte> Fakulteler = new List<Fakulte>();
            Connection ConnectAndRun = new Connection();
            try
            {
                using (ConnectAndRun.OpenConnection())
                {

                       string Query = "Select Id, Ad from Fakulte";

                    SqlCommand Cmd = ConnectAndRun.CreateQuery(Query);
                    SqlDataReader sqlDataReader = Cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (sqlDataReader.Read())
                    {
                        Fakulte fakulte = new Fakulte
                        {
                            Id = Convert.ToInt32(sqlDataReader["Id"]),
                            Ad = sqlDataReader["Ad"].ToString()
                        };
                        Fakulteler.Add(fakulte);
                    }
                    return Fakulteler;
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


