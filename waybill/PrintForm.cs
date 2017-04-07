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
    public partial class PrintForm : Form
    {
        public Form1 help;

        public PrintForm()
        {
            InitializeComponent();
        }


        private void PrintForm_Load(object sender, EventArgs e)
        {

            Dictionary<string, string> map = help.getMap();
            foreach (var pair in map)
            {
                if (pair.Value != "")
                    reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter(pair.Key, pair.Value));
                else reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter(pair.Key, " "));
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
