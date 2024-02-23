using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A__Auto_Care
{
    public partial class Bill_report : Form
    {
        public Bill_report()
        {
            InitializeComponent();
        }

        private void Bill_report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet_Report.Bill' table. You can move, or remove it, as needed.
            this.BillTableAdapter.Fill(this.DataSet_Report.Bill);

            this.reportViewer1.RefreshReport();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
