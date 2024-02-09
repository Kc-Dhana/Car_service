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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        DBConection obj = new DBConection();

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void txt_password_Click(object sender, EventArgs e)
        {
            panel5.BackColor = Color.White;
            txt_password.BackColor = Color.White;
            cmb_usertype.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
            panel4.BackColor = SystemColors.Control;
            txt_username.BackColor = SystemColors.Control;

        }

        private void txt_username_Click_1(object sender, EventArgs e)
        {
            panel4.BackColor = Color.White;
            txt_username.BackColor = Color.White;
            cmb_usertype.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
            panel5.BackColor = SystemColors.Control;
            txt_password.BackColor = SystemColors.Control;
        }

        private void cmb_usertype_Click_1(object sender, EventArgs e)
        {
            cmb_usertype.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            txt_username.BackColor = SystemColors.Control;
            panel5.BackColor = SystemColors.Control;
            txt_password.BackColor = SystemColors.Control;

        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            txt_password.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            txt_password.UseSystemPasswordChar = true;
        }

        private void btn_login_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cmb_usertype.SelectedIndex == 0)//admin login
                {
                    string query= "Select Count(*) from Admin where user_name= '" + txt_username.Text + "' and password='" + txt_password.Text + "'";
                    DataTable dt = obj.Display(query);
                    
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Admin_User_Creat pag = new Admin_User_Creat();
                        this.Hide();
                        pag.Show();
                    }
                    else
                    {
                        MessageBox.Show("Please Check your username and password !");

                    }
                }
                else if (cmb_usertype.SelectedIndex == 1)//reception login
                {
                    string query = "Select Count(*) from Receptionist where user_name= '" + txt_username.Text + "' and password='" + txt_password.Text + "'";
                    DataTable dt = obj.Display(query);
        

                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Reception_home pag = new Reception_home();
                        this.Hide();
                        pag.Show();
                    }
                    else
                    {
                        MessageBox.Show("Please Check your username and password !");

                    }
                }
                else if (cmb_usertype.SelectedIndex == 2)//Accountant login
                {
                    string query = "Select Count(*) from Accountant where user_name= '" + txt_username.Text + "' and password='" + txt_password.Text + "'";
                    DataTable dt = obj.Display(query);
                 

                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Accountant_Home pag = new Accountant_Home();
                        this.Hide();
                        pag.Show();
                    }
                    else
                    {
                        MessageBox.Show("Please Check your username and password !");

                    }
                }
                else
                {
                    MessageBox.Show("Select user type", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Check again1", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show(" Check Again2", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

    
    }
}
