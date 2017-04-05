using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace waybill
{
    class Driver
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime med { get; set; }
        public DateTime cert_for { get; set; }
        private Int64 cert_num { get; set; }
        public Int64 cert_seria
        {
            get
            {
                return cert_num % 1000000;
            }
        }
        public Int64 cert_number
        {
            get
            {
                return cert_num / 1000000;
            }
        }

        public static Driver findById(string s)
        {
            int id;
            if (int.TryParse(s, out id))
            {
                string queryString = string.Format("SELECT * FROM dbo.Drivers WHERE id = {0}", id);
                SqlDataAdapter adapter = new SqlDataAdapter(queryString, Form1.sc);

                StateDataSet drivers = new StateDataSet();
                adapter.Fill(drivers, "Drivers");

                var driver = drivers.Drivers.FindById(id);
                
                if (driver == null)
                {
                    return null;
                }
                return new Driver { name = driver.name, med = driver.med, cert_for = driver.cert_for,
                cert_num = driver.cert_num, id = driver.Id};
            } else
            {
                return null;
            }
        }

        public static void updateOrCreate(Driver driver)
        {
            int id = driver.id;
            string queryString = string.Format("SELECT * FROM dbo.Drivers WHERE id = {0}", id);
            SqlDataAdapter adapter = new SqlDataAdapter(queryString, Form1.sc);

            StateDataSet drivers = new StateDataSet();
            adapter.Fill(drivers, "Drivers");

            var driverRow = drivers.Drivers.FindById(id);

            if (driverRow == null)
            {
                drivers.Drivers.AddDriversRow(driver.name, driver.med, driver.cert_num, driver.cert_for);
            } else
            {
                driverRow.name = driver.name;
                driverRow.med = driver.med;
                driverRow.cert_num = driver.cert_num;
                driverRow.cert_for = driver.cert_for;
            }
            drivers.AcceptChanges();
        }
    }
}
