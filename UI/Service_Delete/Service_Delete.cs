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
    public partial class Service_Delete : Form
    {
        public Service_Delete()
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
            lbl_err_sid.Text = "";
            txt_sid.Text = "";
            dataGridView_service.DataSource = null;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_sid.Text.Length == 0)
            {
                lbl_err_sid.Text = "Parts Code cannot be blank";

            }
            else
            {
                lbl_err_sid.Text = "";
                try
                {
                    string query = " Select * from Service where Service_Id  = '" + txt_sid.Text + "' ";
                    dataGridView_service.DataSource = obj.Display(query);
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
                string query = " Select * from Service";
                dataGridView_service.DataSource = obj.Display(query);
            }
            catch (SqlException)
            {
                MessageBox.Show("Data cannot Show", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show(" Check Again", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "Delete Service where Service_Id='" + txt_sid.Text + "'";
                int line = obj.Save_Update_Delete(query);
                if (line == 1)
                    MessageBox.Show("Data Delete successfully", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Data cannot Delete", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException)
            {
                MessageBox.Show("Data cannot Delete", "Error",
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
