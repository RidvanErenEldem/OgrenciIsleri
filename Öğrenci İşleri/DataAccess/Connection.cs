using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Connection
    {
        public SqlConnection OpenConnection()
        {
            SqlConnection Connection = new SqlConnection("Data Source = HP-PAVILION-GAM; Initial Catalog = OgrenciIsleri; Integrated Security = True");
            Connection.Open();
            return Connection;
        }
        public SqlCommand CreateQuery(string Query)
        {
            SqlCommand Cmd = new SqlCommand(Query, OpenConnection());
            return Cmd;
        }
    }
}
