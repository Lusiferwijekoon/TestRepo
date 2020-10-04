using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class InsertBL
    {

        public void AddSensorData(String id, double sensorvalue, string status, double lat, double lng)
        {
            try
            {
                DL.InsertDL object1 = new DL.InsertDL();
                object1.AddSensorData(id, sensorvalue, status, lat, lng);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR");
                //MessageBox.show("Error in Insert BL");
            }
        }


        public void inertalertdetails(string hazardlevel, int noofrecipients, string confirmesstatus, string generatedtime, string confirmedtime, string confirmedid, string sensorvalueid)
        {
            try
            {
                DL.InsertDL object1 = new DL.InsertDL();
                object1.addAlertdetails(hazardlevel, noofrecipients, confirmesstatus, generatedtime, confirmedtime, confirmedid, sensorvalueid);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR");
                //MessageBox.show("Error in Insert BL");
            }
        }


        public void AddSensorMetDat(float lat, float longi, string status, string area)
        {
            try
            {
                DL.InsertDL insertDL = new DL.InsertDL();
                insertDL.AddSensorMetDat(lat, longi, status, area);
            }catch(Exception e)
            {
                Console.WriteLine("ERROR  :- "+e);
            }
        }

        public void ADDDailySync(string id, double sensorvalue, string status, double lat, double lng, string date)
        {
            try
            {
                DL.InsertDL insertDL = new DL.InsertDL();
                insertDL.ADDDailySync(id,sensorvalue,status,lat,lng,date);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR  :- " + e);
            }
        }



        }
}
