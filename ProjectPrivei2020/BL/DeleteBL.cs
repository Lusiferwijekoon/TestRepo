using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class DeleteBL
    {
        public void DeleteSensorData()
        {
            try
            {
                DL.DeleteDL object1 = new DL.DeleteDL();
                object1.deleteTableData();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR");
                //MessageBox.show("Error in Insert BL");
            }

        }
    }
}
