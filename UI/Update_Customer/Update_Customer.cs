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
    public partial class Update_Customer : Form
    {
        public Update_Customer()
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
            txt_cusID.Text = "";
            dataGridView_customer.DataSource = null;
            txt_fname.Text = "";
            txt_lname.Text = "";
            txt_email.Text = "";
            txt_nic.Text = "";
            txt_address.Text = "";
            txt_tp.Text = "";

            lbl_err_id.Text = "";
            lbl_err_fname.Text = "";
            lbl_err_lname.Text = "";
            lbl_err_email.Text = "";
            lbl_err_nic.Text = "";
            lbl_err_addres.Text = "";
            lbl_err_tp.Text = "";
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            //1
            if (txt_cusID.Text.Length == 0)
            {
                lbl_err_id.Text = "Cutomer ID cannot be blank";
            }
            //2
            else if (txt_fname.Text.Length == 0)
            {
                lbl_err_id.Text = "";
                lbl_err_fname.Text = "Firt Name cannot be blank";
            }
            else if (!Regex.IsMatch(txt_fname.Text, @"^[a-zA-Z]+$"))
            {
                lbl_err_id.Text = "";
                lbl_err_fname.Text = "First name cannot have Digit or Symbol";
            }
            //3
            else if (txt_lname.Text.Length == 0)
            {
                lbl_err_id.Text = "";
                lbl_err_fname.Text = "";
                lbl_err_lname.Text = "Last Name cannot be blank";
            }
            else if (!Regex.IsMatch(txt_lname.Text, @"^[a-zA-Z]+$"))
            {
                lbl_err_id.Text = "";
                lbl_err_fname.Text = "";
                lbl_err_lname.Text = "Last name cannot have Digit or Symbol";
            }
            //4
            else if (txt_email.Text.Length == 0)
            {
                lbl_err_lname.Text = "";
                lbl_err_id.Text = "";
                lbl_err_fname.Text = "";
                lbl_err_email.Text = "Email cannot be blank";
            }
            else if (!Regex.IsMatch(txt_email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                lbl_err_lname.Text = "";
                lbl_err_id.Text = "";
                lbl_err_fname.Text = "";
                lbl_err_email.Text = "Email must be a valid one   Ex-dimuthu123@gmail.com";
            }
            //5
            else if (txt_nic.Text.Length == 0)
            {
                lbl_err_lname.Text = "";
                lbl_err_id.Text = "";
                lbl_err_fname.Text = "";
                lbl_err_email.Text = "";
                lbl_err_nic.Text = "NIC cannot be blank";
            }
            else if (!Regex.IsMatch(txt_nic.Text, @"^([0-9]{9}[x|X|v|V]|[0-9]{12})$"))
            {
                lbl_err_lname.Text = "";
                lbl_err_id.Text = "";
                lbl_err_fname.Text = "";
                lbl_err_email.Text = "";
                lbl_err_nic.Text = "Incorrect NIC format";
            }
            //6
            else if (txt_address.Text.Length == 0)
            {
                lbl_err_lname.Text = "";
                lbl_err_id.Text = "";
                lbl_err_fname.Text = "";
                lbl_err_email.Text = "";
                lbl_err_nic.Text = "";
                lbl_err_addres.Text = "Address cannot be blank";
            }
            //7
            else if (txt_tp.Text.Length == 0)
            {
                lbl_err_lname.Text = "";
                lbl_err_id.Text = "";
                lbl_err_fname.Text = "";
                lbl_err_email.Text = "";
                lbl_err_nic.Text = "";
                lbl_err_addres.Text = "";
                lbl_err_tp.Text = "Tp cannot be blank";
            }
            else if (!Regex.IsMatch(txt_tp.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
            {
                lbl_err_lname.Text = "";
                lbl_err_id.Text = "";
                lbl_err_fname.Text = "";
                lbl_err_email.Text = "";
                lbl_err_nic.Text = "";
                lbl_err_addres.Text = "";
                lbl_err_tp.Text = "Please enter a valid Telephone number";
            }
            else
            {
                lbl_err_id.Text = "";
                lbl_err_fname.Text = "";
                lbl_err_lname.Text = "";
                lbl_err_email.Text = "";
                lbl_err_nic.Text = "";
                lbl_err_addres.Text = "";
                lbl_err_tp.Text = "";

                try
                {
                    string query = "Update Customer set First_Name= '" + txt_fname.Text + "', Last_Name = '" + txt_lname.Text + "', Email=  '" + txt_email.Text + "', NIC= '" + txt_nic.Text + "', Address= '" + txt_address.Text + "',TP='"+txt_tp.Text+"' where Customer_Id = '" + txt_cusID.Text + "' ";
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

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                string query = " Select * from Customer where Customer_Id  = '" + txt_cusID.Text + "' ";
                dataGridView_customer.DataSource = obj.Display(query);
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

        private void dataGridView_customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_fname.Text = dataGridView_customer.CurrentRow.Cells["First_Name"].Value.ToString();
            txt_lname.Text = dataGridView_customer.CurrentRow.Cells["Last_Name"].Value.ToString();
            txt_email.Text = dataGridView_customer.CurrentRow.Cells["Email"].Value.ToString();
            txt_nic.Text = dataGridView_customer.CurrentRow.Cells["NIC"].Value.ToString();
            txt_address.Text = dataGridView_customer.CurrentRow.Cells["Address"].Value.ToString();
            txt_tp.Text = dataGridView_customer.CurrentRow.Cells["TP"].Value.ToString();


        }

        private void txt_fname_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txt_lname_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        private void txt_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txt_address_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txt_nic_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txt_tp_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Update_Customer_Load(object sender, EventArgs e)
        {

        }
    }
}
