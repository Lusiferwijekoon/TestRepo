using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class InsertDL
    {
        SqlConnection conn = new SqlConnection();
        DataTable dt = new DataTable();
        private int c = 2;

        public void AddSensorData(String id, double sensorvalue, string status, double lat, double lng)
        {
            conn = DataConnection.GetConnection();
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            int id1 = Convert.ToInt32(id.ToString().Trim());

            String time = DateTime.Now.ToString("HH:mm:ss tt");

            SqlCommand cmd = new SqlCommand("InsertSensorValues", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@sid", id1));
            cmd.Parameters.Add(new SqlParameter("@time", time));
            cmd.Parameters.Add(new SqlParameter("@senval", sensorvalue));
            cmd.Parameters.Add(new SqlParameter("@status", status));
            cmd.Parameters.Add(new SqlParameter("@lat", lat));
            cmd.Parameters.Add(new SqlParameter("@lng", lng));
            cmd.ExecuteNonQuery();

        }

        public void ADDDailySync(string id, double sensorvalue, string status, double lat, double lng,string date)
        {
            conn = DataConnection.GetConnection();
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string currentdate = DateTime.Now.ToString("YY-MM-DD");
            string time = DateTime.Now.ToString("HH:mm:ss tt");

            SqlCommand cmd = new SqlCommand("DailySync", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@senid", id));
            cmd.Parameters.Add(new SqlParameter("@time", time));
            cmd.Parameters.Add(new SqlParameter("@date", currentdate));
            cmd.Parameters.Add(new SqlParameter("@value", sensorvalue));
            cmd.Parameters.Add(new SqlParameter("@status", status));
            cmd.Parameters.Add(new SqlParameter("@lat", lat));
            cmd.Parameters.Add(new SqlParameter("@long", lng));
            cmd.ExecuteNonQuery();
        }

        public void addAlertdetails(string hazardlevel, int noofrecipients, string confirmesstatus, string generatedtime, string confirmedtime, string confirmedid, string sensorvalueid)
        {
            c++;
            conn = DataConnection.GetConnection();
            if (conn.State == ConnectionState.Closed)
                conn.Open();


            SqlCommand cmdgetid = new SqlCommand("SELECT TOP 1 alert_ID FROM alerts ORDER BY alert_ID DESC", conn);
            cmdgetid.ExecuteNonQuery();
            // cmdgetid.CommandType = CommandType.Text;
            DataTable dt = new DataTable();

            SqlDataReader rd = cmdgetid.ExecuteReader();
            dt.Load(rd);
            String id = dt.Rows[0][0].ToString();

            string[] substrings = id.Split('_');
            int id_No = Convert.ToInt32(substrings[1]) + 1;
            string alertid = "al_" + id_No.ToString();


            SqlCommand cmd = new SqlCommand("insertalertdetails", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", alertid));
            cmd.Parameters.Add(new SqlParameter("@h_lvl", hazardlevel));
            cmd.Parameters.Add(new SqlParameter("@norecipients", noofrecipients));
            cmd.Parameters.Add(new SqlParameter("@confirmedstatus", confirmesstatus));
            cmd.Parameters.Add(new SqlParameter("@generatedtime", generatedtime));
            cmd.Parameters.Add(new SqlParameter("@confirmedtime", confirmedtime));
            cmd.Parameters.Add(new SqlParameter("@confirmedid", confirmedid));
            cmd.Parameters.Add(new SqlParameter("@sensorvalueid", sensorvalueid));
            cmd.ExecuteNonQuery();
        }


        public void AddSensorMetDat(float lat, float longi, string status, string area)
        {
            conn = DataConnection.GetConnection();
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand cmd = new SqlCommand("InsertSensorMetaData", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@latitude", lat));
            cmd.Parameters.Add(new SqlParameter("@longitude", longi));
            cmd.Parameters.Add(new SqlParameter("@status", status));
            cmd.Parameters.Add(new SqlParameter("@area", area));
            cmd.ExecuteNonQuery();
        }
    }

    
}
