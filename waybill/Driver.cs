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
        public int tab_num { get; set; }
        public string name { get; set; }
        public DateTime med { get; set; }
        public DateTime cert_for { get; set; }
        private Int64 cert_num { get; set; }
        public Int64 cert_seria
        {
            get
            {
                return cert_num / 1000000;
            }
        }
        public Int64 cert_number
        {
            get
            {
                return cert_num % 1000000;
            }
        }

        public Driver(int tab_num, string name, DateTime med, DateTime cert_for, Int64 cert_num)
        {
            this.tab_num = tab_num;
            this.name = name;
            this.med = med;
            this.cert_for = cert_for;
            this.cert_num = cert_num;
        }

        public Driver(string tab_num, string name, string med, string cert_for, string cert_num)
        {
                this.tab_num = int.Parse(tab_num);
                this.name = name;
                this.med = DateTime.Parse(med);
                this.cert_for = DateTime.Parse(cert_for);
                this.cert_num = Int64.Parse(cert_num);
        }

        public static Driver findByTabNum(string s)
        {
            int tab_num;
            if (int.TryParse(s, out tab_num))
            {
                StateDatabaseDataSetTableAdapters.DriversTableAdapter adapter = new StateDatabaseDataSetTableAdapters.DriversTableAdapter();

                StateDatabaseDataSet.DriversDataTable drivers = new StateDatabaseDataSet.DriversDataTable();
                adapter.Fill(drivers);

                StateDatabaseDataSet.DriversRow driver = drivers.Where(x => x.tab_num == tab_num).FirstOrDefault();

                if (driver == null)
                {
                    return null;
                }
                return new Driver(driver.Id, driver.name, driver.med, driver.cert_for, driver.cert_num);
            } else
            {
                return null;
            }
        }

        public static void updateOrCreate(Driver driver)
        {
            int tab_num = driver.tab_num;
            StateDatabaseDataSetTableAdapters.DriversTableAdapter adapter = new StateDatabaseDataSetTableAdapters.DriversTableAdapter();

            StateDatabaseDataSet.DriversDataTable drivers = new StateDatabaseDataSet.DriversDataTable();
            adapter.Fill(drivers);
            StateDatabaseDataSet.DriversRow driverRow = drivers.Where(x => x.tab_num == tab_num).FirstOrDefault();
            if (driverRow == null)
            {
                drivers.AddDriversRow(driver.name, driver.med, driver.cert_num, driver.cert_for, driver.tab_num);
            } else
            {
                driverRow.name = driver.name;
                driverRow.med = driver.med;
                driverRow.cert_num = driver.cert_num;
                driverRow.cert_for = driver.cert_for;
            }
            adapter.Update(drivers);
        }
    }
}
