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
    public partial class Supplier_Update : Form
    {
        public Supplier_Update()
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
            txt_supID.Text = "";
            dataGridView_supplier.DataSource = null;
            txt_name.Text = "";
            txt_cname.Text = "";
            txt_email.Text = "";
            txt_nic.Text = "";
            txt_tp.Text = "";
            txt_parts.Text = "";

            lbl_err_id.Text = "";
            lbl_err_fname.Text = "";
            lbl_err_cname.Text = "";
            lbl_err_email.Text = "";
            lbl_err_nic.Text = "";
            lbl_err_tp.Text = "";
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //1
            if (txt_supID.Text.Length == 0)
            {
                lbl_err_id.Text = "Supplier ID cannot be blank";

            }
            else if(dataGridView_supplier.DataSource==null)
            {
                lbl_err_id.Text = "Enter valid Supplier ID";
            }
            //2
            else if (txt_name.Text.Length == 0)
            {
                lbl_err_id.Text = "";
                lbl_err_fname.Text = "Name cannot be blank";

            }
            else if (!Regex.IsMatch(txt_name.Text, @"^[a-zA-Z]+$"))
            {
                lbl_err_id.Text = "";
                lbl_err_fname.Text = "Name cannot have Digit or Symbol";

            }
            //3
            else if (txt_cname.Text.Length == 0)
            {
                lbl_err_id.Text = "";
                lbl_err_fname.Text = "";
                lbl_err_cname.Text = "Company Name cannot be blank";

            }
            //4
            else if (txt_email.Text.Length == 0)
            {
                lbl_err_cname.Text = "";
                lbl_err_id.Text = "";
                lbl_err_fname.Text = "";
                lbl_err_email.Text = "Email cannot be blank";

            }
            else if (!Regex.IsMatch(txt_email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                lbl_err_cname.Text = "";
                lbl_err_id.Text = "";
                lbl_err_fname.Text = "";
                lbl_err_email.Text = "Email must be a valid one   Ex-dimuthu123@gmail.com";

            }
            //5
            else if (txt_nic.Text.Length == 0)
            {
                lbl_err_cname.Text = "";
                lbl_err_id.Text = "";
                lbl_err_fname.Text = "";
                lbl_err_email.Text = "";
                lbl_err_nic.Text = "NIC cannot be blank";

            }
            else if (!Regex.IsMatch(txt_nic.Text, @"^([0-9]{9}[x|X|v|V]|[0-9]{12})$"))
            {
                lbl_err_cname.Text = "";
                lbl_err_id.Text = "";
                lbl_err_fname.Text = "";
                lbl_err_email.Text = "";
                lbl_err_nic.Text = "Incorrect NIC format";

            }
            //6
            else if (txt_tp.Text.Length == 0)
            {
                lbl_err_cname.Text = "";
                lbl_err_id.Text = "";
                lbl_err_fname.Text = "";
                lbl_err_email.Text = "";
                lbl_err_nic.Text = "";
                lbl_err_tp.Text = "Tp cannot be blank";

            }
            else if (!Regex.IsMatch(txt_tp.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
            {
                lbl_err_cname.Text = "";
                lbl_err_id.Text = "";
                lbl_err_fname.Text = "";
                lbl_err_email.Text = "";
                lbl_err_nic.Text = "";
                lbl_err_tp.Text = "Please enter a valid Telephone number";
            }
            else if (txt_parts.Text.Length == 0)
            {
                lbl_err_cname.Text = "";
                lbl_err_id.Text = "";
                lbl_err_fname.Text = "";
                lbl_err_email.Text = "";
                lbl_err_nic.Text = "";
                lbl_err_tp.Text = "";
                lbl_err_partsid.Text = "Partid cannot be blank";

            }
            else
            {
                lbl_err_id.Text = "";
                lbl_err_fname.Text = "";
                lbl_err_cname.Text = "";
                lbl_err_email.Text = "";
                lbl_err_nic.Text = "";
                lbl_err_tp.Text = "";
                lbl_err_partsid.Text = "";

                try
                {
                    string query = "Update Supplier set  Supplier_Name= '" + txt_name.Text + "', Company_Name = '" + txt_cname.Text + "', Email=  '" + txt_email.Text + "', NIC= '" + txt_nic.Text + "', TP= '" + txt_tp.Text + "',part_id= '" + txt_parts.Text + "' where Supplier_Id = '" + txt_supID.Text + "' ";
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
                    MessageBox.Show("Data cannot save", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show(" Check Again", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
                try
                {
                    string query = " Select * from Supplier where Supplier_Id = '" + txt_supID.Text + "' ";
                    dataGridView_supplier.DataSource = obj.Display(query);
                }
                catch (SqlException)
                {
                    MessageBox.Show("Data cannot Update", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show(" Check Again", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView_supplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_name.Text = dataGridView_supplier.CurrentRow.Cells["Supplier_Name"].Value.ToString();
            txt_cname.Text = dataGridView_supplier.CurrentRow.Cells["Company_Name"].Value.ToString();
            txt_email.Text = dataGridView_supplier.CurrentRow.Cells["Email"].Value.ToString();
            txt_nic.Text = dataGridView_supplier.CurrentRow.Cells["NIC"].Value.ToString();
            txt_tp.Text = dataGridView_supplier.CurrentRow.Cells["TP"].Value.ToString();
            txt_parts.Text = dataGridView_supplier.CurrentRow.Cells["part_id"].Value.ToString();
        }
    }
}
