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
    public partial class Customer_Registration : Form
    {
        public Customer_Registration()
        {
            InitializeComponent();
        }
        public SqlConnection getconnection()
        {
            return new SqlConnection("Data Source=LAPTOP-B79T3VMQ;Initial Catalog=AutoCare;Integrated Security=True");
        }
        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_register.Controls.Add(childForm);
            panel_register.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void Customer_Registration_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = getconnection())
                {
                    cn.Open();

                    SqlCommand cmd3 = cn.CreateCommand();
                    cmd3.CommandText = "SELECT IDENT_CURRENT('Customer') +1";
                    SqlDataReader sr = cmd3.ExecuteReader();
                    if (sr.Read())
                    {
                        txt_cusID.Text = sr[0].ToString();
                    }
                    cn.Close();
                    cmd3.Dispose();
                }

            }
            catch (SqlException)
            {
                MessageBox.Show("customer id cannot show", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("check again", "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        DBConection obj = new DBConection();
        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void btn_reg_Click_1(object sender, EventArgs e)
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
                try
                {
                    int cid = Convert.ToInt32(txt_cusID.Text);

                    string query = "Insert Into Customer values('" + txt_fname.Text + "','" + txt_lname.Text + "','" + txt_email.Text + "','" + txt_nic.Text + "','" + txt_address.Text + "','"+txt_tp.Text+"')";
                    int line = obj.Save_Update_Delete(query);
                    if (line == 1)
                        MessageBox.Show("Data save successfully", "Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Data cannot save", "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);

                    lbl_err_id.Text = "";
                    lbl_err_fname.Text = "";
                    lbl_err_lname.Text = "";
                    lbl_err_email.Text = "";
                    lbl_err_nic.Text = "";
                    lbl_err_addres.Text = "";
                    lbl_err_tp.Text = "";

                   

                    QRCode_Gen form1 = new QRCode_Gen();
                    form1.cusID = txt_cusID.Text;
                    form1.email = txt_email.Text;
                    form1.ShowDialog();

                }
                catch(SqlException)
                {
                    MessageBox.Show("Data cannot save", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch(Exception)
                {
                    MessageBox.Show(" Check Again", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btn_clear_Click_1(object sender, EventArgs e)
        {
            txt_cusID.Text = "";
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

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel_register_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_tp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
