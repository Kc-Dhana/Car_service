using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace A__Auto_Care
{
    public partial class Service_Update : Form
    {
        public Service_Update()
        {
            InitializeComponent();
        }
        DBConection obj = new DBConection();

        private void Service_Update_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_sid.Text = "";
            dataGridView_service.DataSource = null;
            txt_name.Text = "";
            txt_price.Text = "";

            lbl_err_sid.Text = "";
            lbl_err_name.Text = "";
            lbl_err_uprice.Text = "";
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

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_sid.Text.Length == 0)
            {
                lbl_err_sid.Text = "Service code cannot be blank";

            }
            //2
            else if (txt_name.Text.Length == 0)
            {
                lbl_err_sid.Text = "";
                lbl_err_name.Text = "Name cannot be blank";

            }
            //3
            else if (txt_price.Text.Length == 0)
            {
                lbl_err_sid.Text = "";
                lbl_err_name.Text = "";
                lbl_err_uprice.Text = "Unite price cannot be blank";

            }
            else if (!Regex.IsMatch(txt_price.Text, @"(^\d*\.?\d*[0-9]+\d*$)|(^[0-9]+\d*\.\d*$)"))
            {
                lbl_err_sid.Text = "";
                lbl_err_name.Text = "";
                lbl_err_uprice.Text = "Enter numbers only";

            }
            else
            {
                lbl_err_sid.Text = "";
                lbl_err_name.Text = "";
                lbl_err_uprice.Text = "";

                try
                {
                    string query = "Update Service set  Service_Name= '" + txt_name.Text + "', Unit_Price=  '" + txt_price.Text + "' where Service_Id = '" + txt_sid.Text + "' ";
                    int line = obj.Save_Update_Delete(query);
                    if (line == 1)
                        MessageBox.Show("Data update successfully", "Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Data cannot update", "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (SqlException)
                {
                    MessageBox.Show("Data cannot update", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show(" Check Again", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void dataGridView_service_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_name.Text = dataGridView_service.CurrentRow.Cells["Service_Name"].Value.ToString();
            txt_price.Text = dataGridView_service.CurrentRow.Cells["Unit_Price"].Value.ToString();
        }
    }
}
