using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class SelectDL
    {
        SqlConnection conn = new SqlConnection();
        DataTable dt = new DataTable();


        public DataTable SelectthreatData()
        {
            conn = DataConnection.GetConnection();
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand cmd = new SqlCommand("getthreatdetails", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch
            {
                throw;
            }

        }

        public DataTable selectlevel1threat()
        {
            conn = DataConnection.GetConnection();
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand cmd = new SqlCommand("gettlevel1threat", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch
            {
                throw;
            }

        }

        public DataTable selectlevel2threat()
        {
            conn = DataConnection.GetConnection();
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand cmd = new SqlCommand("gettlevel2threat", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch
            {
                throw;
            }

        }

        public DataTable selectlevel3threat()
        {
            conn = DataConnection.GetConnection();
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand cmd = new SqlCommand("gettlevel3threat", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch
            {
                throw;
            }

        }

        public Boolean valiedadminid(String adminid)
        {

            conn = DataConnection.GetConnection();
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand cmd = new SqlCommand("validateadminid", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", adminid));
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            int value = Convert.ToInt32(dt.Rows[0][0].ToString().Trim());

        
            if (value == 1)
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable SelectSensorDetails()
        {
            conn = DataConnection.GetConnection();
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand cmd = new SqlCommand("getSensorValues", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            if(dataTable != null)
            {
                return dataTable;
            }
            else
            {
                Console.WriteLine("Data Not Comming From the DataBase");
                return null;
            }
        }


        public DataTable fetchDataToGraphs()
        {
            try
            {
                conn = DataConnection.GetConnection();
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
               // SqlCommand cmd = new SqlCommand("fetchforGraphs", conn);
                SqlCommand cmd = new SqlCommand("testGraphs", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(sqlDataReader);
                return dataTable;
            }catch(Exception ex)
            {
                return null;
            }           
        }



    }
}