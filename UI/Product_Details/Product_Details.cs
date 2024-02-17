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
    public partial class Product_Details : Form
    {
        public Product_Details()
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
            lbl_err_pno.Text = "";
            txt_pno.Text = "";
            dataGridView_parts.DataSource = null;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_pno.Text.Length == 0)
            {
                lbl_err_pno.Text = "Please enter Parts No";

            }
            else
            {
                lbl_err_pno.Text = "";
                try
                {
                    string query = " Select * from Part where Part_Code  = '" + txt_pno.Text + "' ";
                    dataGridView_parts.DataSource = obj.Display(query);
                }
                catch (SqlException)
                {
                    MessageBox.Show("Data cannot View", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show(" Check Again", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_search_all_Click(object sender, EventArgs e)
        {
            try
            {
                string query = " Select * from Part";
                dataGridView_parts.DataSource = obj.Display(query);
            }
            catch (SqlException)
            {
                MessageBox.Show("Data cannot View", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show(" Check Again", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
