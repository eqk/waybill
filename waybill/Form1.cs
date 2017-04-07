using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace waybill
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public Dictionary<string,string> getMap()
        {
            var map = new Dictionary<string, string>();
            map.Add("Number", textBox1.Text);
            map.Add("dayDate", label35.Text);
            map.Add("monthDate", label36.Text);
            map.Add("fromDay", textBox2.Text);
            map.Add("fromMonth", textBox3.Text);
            map.Add("toDay", textBox5.Text);
            map.Add("toMonth", textBox4.Text);
            map.Add("carModel", textBox6.Text);
            map.Add("numberSign", textBox8.Text);
            map.Add("driver", textBox7.Text);
            map.Add("garageNumber", textBox9.Text);
            map.Add("policy", textBox11.Text);
            map.Add("driverNumber", textBox10.Text);
            map.Add("rate", textBox14.Text);
            map.Add("validUntil", textBox13.Text);
            map.Add("hospital", textBox12.Text);
            map.Add("driverLicense", textBox16.Text);
            map.Add("licNumber", textBox15.Text);
            map.Add("until", textBox17.Text);
            map.Add("consumRate", textBox18.Text);
            map.Add("odometrBefore", textBox19.Text);
            map.Add("odometrAfter", textBox20.Text);
            map.Add("feedAddress", textBox23.Text);
            map.Add("num", textBox27.Text);
            map.Add("mon", textBox26.Text);
            map.Add("hours", textBox25.Text);
            map.Add("mins", textBox24.Text);
            map.Add("countPetrol", textBox28.Text);
            map.Add("odometrAfter2", textBox29.Text);
            map.Add("remainPetrol", textBox30.Text);
            map.Add("num1", textBox31.Text);
            map.Add("mon1", textBox32.Text);
            map.Add("hours1", textBox33.Text);
            map.Add("mins1", textBox34.Text);
            map.Add("salary", textBox39.Text);
            map.Add("KTU", textBox38.Text);
            map.Add("totalSum", textBox37.Text);
            map.Add("mileAge", textBox44.Text);
            map.Add("fuelCons", textBox43.Text);
            map.Add("fuelFact", textBox41.Text);
            map.Add("fuelNorm", textBox45.Text);
            map.Add("econOver", textBox46.Text);
            map.Add("workTime", textBox47.Text);
            return map;
     
        }


        private void PrintButton_Click(object sender, EventArgs e)
        {
            //this.T
            PrintForm frm = new PrintForm();
            {
                frm.help = this;
                frm.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //  DateTimePicker dateTimePicker1 = new DateTimePicker();
            //  dateTimePicker1.CustomFormat = "d";
            //  dateTimePicker1.Format = DateTimePickerFormat.Custom;
           // label35.Text = DateTime.Now.Day.ToString();
            label36.Text = DateTime.Now.ToLongDateString();
        }

        
    }

}