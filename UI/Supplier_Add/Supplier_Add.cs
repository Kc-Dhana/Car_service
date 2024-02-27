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
    public partial class Supplier_Add : Form
    {
        public Supplier_Add()
        {
            InitializeComponent();
        }
        

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_supID.Text ="";
            txt_name.Text = "";
            txt_cname.Text = "";
            txt_email.Text = "";
            txt_nic.Text = "";
            txt_tp.Text = "";
            txt_partsID.Text = "";

            lbl_err_id.Text = "";
            lbl_err_fname.Text = "";
            lbl_err_cname.Text = "";
            lbl_err_email.Text = "";
            lbl_err_nic.Text = "";
            lbl_err_tp.Text = "";
            lbl_err_partsid.Text = "";

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //1
            if (txt_supID.Text.Length == 0)
            {
                lbl_err_id.Text = "Supplier ID cannot be blank";

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
            else if (txt_partsID.Text.Length == 0)
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
                    //int cid = Convert.ToInt32(txt_supID.Text);
                    
                    string query = "Insert Into Supplier values('" + txt_supID.Text + "','" + txt_name.Text + "','" + txt_cname.Text + "','" + txt_email.Text + "','" + txt_nic.Text + "','" + txt_tp.Text + "','"+txt_partsID.Text+"')";
                    int line = obj.Save_Update_Delete(query);
                    if (line == 1)
                        MessageBox.Show("Data Add successfully", "Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Data cannot Add", "Error",
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

        private void Supplier_Add_Load(object sender, EventArgs e)
        {

        }
        DBConection obj = new DBConection();
    }
}
