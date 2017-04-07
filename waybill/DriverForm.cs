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
    public partial class DriverForm : Form
    {
        public DriverForm()
        {
            InitializeComponent();
        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {
            Driver driver = Driver.findByTabNum(textBoxId.Text);
            if (driver != null)
            {
                textBoxName.Text = driver.name;
                textBoxCertFor.Text = driver.cert_for.ToShortDateString();
                textBoxCertNum.Text = driver.cert_number.ToString();
                textBoxCertSer.Text = driver.cert_seria.ToString();
                textBoxMedFor.Text = driver.med.ToShortDateString();
            } else
            {
                this.clean();
            }
        }

        private void clean()
        {
            textBoxCertFor.Text = "";
            textBoxCertNum.Text = "";
            textBoxCertSer.Text = "";
            textBoxMedFor.Text = "";
            textBoxName.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Driver d1 = new Driver(textBoxId.Text, textBoxName.Text,
                    textBoxMedFor.Text, textBoxCertFor.Text, textBoxCertSer.Text + textBoxCertNum.Text);
                Driver.updateOrCreate(d1);
                
            } catch (FormatException fe)
            {
                this.clean();
            }
        }
    }
}
