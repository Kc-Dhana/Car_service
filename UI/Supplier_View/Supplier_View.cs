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
    public partial class Supplier_View : Form
    {
        public Supplier_View()
        {
            InitializeComponent();
        }
        DBConection obj = new DBConection();

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Supplier_View_Load(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            lbl_err_id.Text = "";
            txt_supID.Text = "";
            dataGridView_supplier.DataSource = null;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //1
            if (txt_supID.Text.Length == 0)
            {
                lbl_err_id.Text = "Supplier ID cannot be blank";

            }
            else
            {
                lbl_err_id.Text = "";
                try
                {
                        
                        string query = " Select * from Supplier where Supplier_Id  = '" + txt_supID.Text + "' ";
                        dataGridView_supplier.DataSource = obj.Display(query);
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
        }

        private void btn_searchall_Click(object sender, EventArgs e)
        {
            try
            {
                string query = " Select * from Supplier";
                dataGridView_supplier.DataSource = obj.Display(query);
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
    }
}
