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
    public partial class Admin_User_Creat : Form
    {
        public Admin_User_Creat()
        {
            InitializeComponent();
        }
        DBConection obj = new DBConection();

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_name.Text = "";
            txt_nic.Text = "";
            
            txt_address.Text = "";
            
            txt_email.Text = "";
            txt_tp.Text = "";
            cmb_user_type.SelectedIndex=-1;
            txt_password.Text = "";
            txt_confirm_pass.Text = "";
            txt_username.Text = "";
           

            lbl_err_name.Text = "";
            lbl_err_nic.Text = "";
           
            lbl_err_address.Text = "";
            
            lbl_err_email.Text = "";
            lbl_err_tp.Text = "";
            lbl_err_usertype.Text = "";
            lbl_err_password.Text = "";
            lbl_err_conpassword.Text = "";
            lbl_err_username.Text = "";



        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            this.Hide();
            obj.Show();
        }

        private void btn_send_otp_Click(object sender, EventArgs e)
        {
            //1
            if (txt_name.Text.Length == 0)
            {
                lbl_err_name.Text = "Name cannot be blank";

            }
            else if (!Regex.IsMatch(txt_name.Text, @"^[a-zA-Z]+$"))
            {
                lbl_err_name.Text = "Name cannot have Digit or Symbol";

            }
            //2
            else if (txt_nic.Text.Length == 0)
            {
                lbl_err_name.Text = "";
                lbl_err_name.Text = "NIC cannot be blank";

            }
            else if (!Regex.IsMatch(txt_nic.Text, @"^([0-9]{9}[x|X|v|V]|[0-9]{12})$"))
            {
                lbl_err_name.Text = "";
                lbl_err_nic.Text = "Incorrect NIC format";

            }
            //3
            else if (cmb_user_type.Text.Length == 0)
            {
                lbl_err_name.Text = "";
                lbl_err_nic.Text = "";
                lbl_err_usertype.Text = "Select user type";

            }
            //4
            else if (txt_address.Text.Length == 0)
            {
                lbl_err_name.Text = "";
                lbl_err_nic.Text = "";
                lbl_err_usertype.Text = "";
                lbl_err_address.Text = "Address cannot be blank";

            }
            //5
            
            //6
            else if (txt_email.Text.Length == 0)
            {
                lbl_err_name.Text = "";
                lbl_err_nic.Text = "";
                lbl_err_usertype.Text = "";
                lbl_err_address.Text = "";
                
                lbl_err_email.Text = "Email cannot be blank";


            }
            else if (!Regex.IsMatch(txt_email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {

                lbl_err_name.Text = "";
                lbl_err_nic.Text = "";
                lbl_err_usertype.Text = "";
                lbl_err_address.Text = "";

                lbl_err_email.Text = "Email must be a valid one  Ex-name123@gmail.com";

            }
            //7
            else if (txt_tp.Text.Length == 0)
            {
                lbl_err_name.Text = "";
                lbl_err_nic.Text = "";
                lbl_err_usertype.Text = "";
                lbl_err_address.Text = "";
              
                lbl_err_email.Text = "";
                lbl_err_tp.Text = "Tp cannot be blank";

            }
            else if (!Regex.IsMatch(txt_tp.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
            {
                lbl_err_name.Text = "";
                lbl_err_nic.Text = "";
                lbl_err_usertype.Text = "";
                lbl_err_address.Text = "";
                
                lbl_err_email.Text = "";
                lbl_err_tp.Text = "Please enter a valid Telephone number";
            }
            //8
            else if (txt_username.Text.Length == 0)
            {
                lbl_err_name.Text = "";
                lbl_err_nic.Text = "";
                lbl_err_usertype.Text = "";
                lbl_err_address.Text = "";
               
                lbl_err_email.Text = "";
                lbl_err_tp.Text = "";
                lbl_err_email.Text = "";
                lbl_err_username.Text = "cannot be blank";

            }
            //9
            else if (txt_password.Text.Length == 0)
            {
                lbl_err_name.Text = "";
                lbl_err_nic.Text = "";
                lbl_err_usertype.Text = "";
                lbl_err_address.Text = "";
                
                lbl_err_email.Text = "";
                lbl_err_tp.Text = "";
                lbl_err_email.Text = "";
                lbl_err_username.Text = "";
                lbl_err_password.Text = "Password cannot be blank";

            }
            //10
            else if (txt_confirm_pass.Text.Length == 0)
            {
                lbl_err_name.Text = "";
                lbl_err_nic.Text = "";
                lbl_err_usertype.Text = "";
                lbl_err_address.Text = "";
              
                lbl_err_email.Text = "";
                lbl_err_tp.Text = "";
                lbl_err_email.Text = "";
                lbl_err_password.Text = "";
                lbl_err_username.Text = "";
                lbl_err_conpassword.Text = "Confirm password cannot be blank";

            }
            else if (txt_password.Text != txt_confirm_pass.Text)
            {
                lbl_err_name.Text = "";
                lbl_err_nic.Text = "";
                lbl_err_usertype.Text = "";
                lbl_err_address.Text = "";
               
                lbl_err_email.Text = "";
                lbl_err_tp.Text = "";
                lbl_err_email.Text = "";
                lbl_err_password.Text = "";
                lbl_err_conpassword.Text = "Confirm password must be same as password";
            }
            else
            {
                lbl_err_name.Text = "";
                lbl_err_nic.Text = "";
  
                lbl_err_address.Text = "";
                lbl_err_username.Text = "";
              
                lbl_err_email.Text = "";
                lbl_err_tp.Text = "";
                lbl_err_usertype.Text = "";
                lbl_err_password.Text = "";
                lbl_err_conpassword.Text = "";


                try
                {
                    if (cmb_user_type.SelectedIndex == 0)//admin
                    {
                        string query = "Insert Into Admin values('" + txt_name.Text + "','" + txt_nic.Text + "','" + txt_address.Text + "','" + txt_email.Text + "','" + txt_tp.Text + "','" + txt_username.Text + "','"+txt_confirm_pass.Text+"')";
                        int line = obj.Save_Update_Delete(query);
                        if (line == 1)
                            MessageBox.Show("Data save successfully", "Info",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Data cannot save", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);



                    }
                    else if (cmb_user_type.SelectedIndex == 1)//reception
                    {
                        string query = "Insert Into Receptionist values('" + txt_name.Text + "','" + txt_nic.Text + "','" + txt_address.Text + "','" + txt_email.Text + "','" + txt_tp.Text + "','" + txt_username.Text + "','" + txt_confirm_pass.Text + "')";
                        int line = obj.Save_Update_Delete(query);
                        if (line == 1)
                            MessageBox.Show("Data save successfully", "Info",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Data cannot save", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }
                    else if (cmb_user_type.SelectedIndex == 2)//accounted
                    {

                        string query = "Insert Into Accountant values('" + txt_name.Text + "','" + txt_nic.Text + "','" + txt_address.Text + "','" + txt_email.Text + "','" + txt_tp.Text + "','" + txt_username.Text + "','" + txt_confirm_pass.Text + "')";
                        int line = obj.Save_Update_Delete(query);
                        if (line == 1)
                            MessageBox.Show("Data save successfully", "Info",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Data cannot save", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }
                    else
                    {
                        MessageBox.Show("Select user type", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

       

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void cmb_gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Admin_User_Creat_Load(object sender, EventArgs e)
        {

        }

        private void txt_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_err_password_Click(object sender, EventArgs e)
        {

        }

        private void lbl_err_conpassword_Click(object sender, EventArgs e)
        {

        }

        private void lbl_err_address_Click(object sender, EventArgs e)
        {

        }

        private void lbl_err_email_Click(object sender, EventArgs e)
        {

        }

        private void lbl_err_tp_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txt_confirm_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_tp_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_err_username_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_err_name_Click(object sender, EventArgs e)
        {

        }
    }
}
