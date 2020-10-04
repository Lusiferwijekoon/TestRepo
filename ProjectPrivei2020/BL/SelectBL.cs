using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class SelectBL
    {
        DataTable dt = new DataTable();


        public DataTable selectthreatdetails()
        {
            try
            {
                DL.SelectDL object1 = new DL.SelectDL();
                dt = object1.SelectthreatData();
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR");
            }
            return null;

        }

        public DataTable selectthreatlevel1details()
        {
            try
            {
                DL.SelectDL object1 = new DL.SelectDL();
                dt = object1.selectlevel1threat();
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR");
            }
            return null;
        }

        public DataTable selectthreatlevel2details()
        {
            try
            {
                DL.SelectDL object1 = new DL.SelectDL();
                dt = object1.selectlevel2threat();
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR");
            }
            return null;

        }

        public DataTable selectthreatlevel3details()
        {
            try
            {
                DL.SelectDL object1 = new DL.SelectDL();
                dt = object1.selectlevel3threat();
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR");
            }
            return null;

        }

        public Boolean valiedadminid(String adminid)
        {
            DL.SelectDL object1 = new DL.SelectDL();
            return object1.valiedadminid(adminid);
        }

        public Object[,] getLatLngOfSensors()
        {
            DL.SelectDL onject1 = new DL.SelectDL();
            DataTable dt = onject1.SelectSensorDetails();
            int rows = dt.Rows.Count;
            int columns = dt.Columns.Count;
            Object[,] array = new object[rows,columns];
            for(int i = 0; i<rows; i++)
            {
                for(int j = 0; j<columns; j++)
                {
                    array[i, j] = dt.Rows[i][j];
                }
            }
            return array;
        }

        public DataTable fetchDataToGraphs()
        {
            DL.SelectDL obj1 = new DL.SelectDL();
            return obj1.fetchDataToGraphs();
        }

        

    }
}