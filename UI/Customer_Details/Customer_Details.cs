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

namespace A__Auto_Care
{
    public partial class Customer_Details : Form
    {
        public Customer_Details()
        {
            InitializeComponent();
        }
        DBConection obj = new DBConection();
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            lbl_err_id.Text = "";
            txt_cusID.Text = "";
            dataGridView_customer.DataSource = null;
          
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {

                if (txt_cusID.Text.Length == 0)
                {
                    lbl_err_id.Text = "Please enter customer ID";

                }

                else
                {
                    lbl_err_id.Text = "";
                    string query = " Select * from Customer where Customer_Id  = '" + txt_cusID.Text + "' ";
                    dataGridView_customer.DataSource = obj.Display(query);

                }


            }
            catch (SqlException)
            {
                MessageBox.Show("Data cannot view", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show(" Check Again", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_serch_all_Click(object sender, EventArgs e)
        {
            try
            {
                string query = " Select * from Customer";
                dataGridView_customer.DataSource = obj.Display(query);
            }
            catch (SqlException)
            {
                MessageBox.Show("Data cannot view", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show(" Check Again", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Customer_Details_Load(object sender, EventArgs e)
        {

        }
    }
}
