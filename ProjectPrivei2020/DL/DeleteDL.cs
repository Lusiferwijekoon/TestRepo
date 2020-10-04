using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class DeleteDL
    {
        SqlConnection conn = new SqlConnection();
        //DataTable dt = new DataTable();

        public void deleteTableData()
        {
            conn = DataConnection.GetConnection();
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand cmd = new SqlCommand("DeleteSensorValue", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();

        }
    }
}
