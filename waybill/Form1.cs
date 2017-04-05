using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace waybill
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static SqlConnection sc = new SqlConnection(Properties.Settings.Default.StateDatabaseConnectionString);

        private void Form1_Load(object sender, EventArgs e)
        {
            sc.Open();
        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {
            Driver driver = Driver.findById(idTextBox.Text);
            if (driver != null)
            {
                nameTextBox.Text = driver.name;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            sc.Close();
        }
    }
}
