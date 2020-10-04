using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class DataConnection
    {
        public static SqlConnection GetConnection()
        {
            string connstring = @"Data Source=56WRD1;Initial Catalog=Testing;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connstring);
            return conn;
        }
    }
}
