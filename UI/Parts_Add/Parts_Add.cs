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
    public partial class Parts_Add : Form
    {
        public Parts_Add()
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
            txt_pcode.Text = "";
            txt_name.Text = "";
            txt_uprice.Text = "";
            txt_qty.Text = "";

            lbl_err_code.Text="";
            lbl_err_name.Text="";
            lbl_err_uprice.Text="";
            lbl_err_qty.Text="";

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_pcode.Text.Length == 0)
            {
                lbl_err_code.Text = "Parts code cannot be blank";

            }
            //2
            else if (txt_name.Text.Length == 0)
            {
                lbl_err_code.Text = "";
                lbl_err_name.Text = "Name cannot be blank";

            }
            else if (!Regex.IsMatch(txt_name.Text, @"^[a-zA-Z]+$"))
            {
                lbl_err_code.Text = "";
                lbl_err_name.Text = "Name cannot have Digit or Symbol";

            }
            //3
            else if (txt_uprice.Text.Length == 0)
            {
                lbl_err_code.Text = "";
                lbl_err_name.Text = "";
                lbl_err_uprice.Text = "Unite price cannot be blank";

            }
            else if (!Regex.IsMatch(txt_uprice.Text, @"(^\d*\.?\d*[0-9]+\d*$)|(^[0-9]+\d*\.\d*$)"))
            {
                lbl_err_code.Text = "";
                lbl_err_name.Text ="";
                lbl_err_uprice.Text ="Enter numbers only";

            }
            //4
            else if (txt_qty.Text.Length == 0)
            {
                lbl_err_code.Text = "";
                lbl_err_name.Text = "";
                lbl_err_uprice.Text = "";
                lbl_err_qty.Text = "QTY cannot be blank";

            }
            else if (Regex.IsMatch(txt_qty.Text, "[^0-9]"))
            {
                lbl_err_code.Text = "";
                lbl_err_name.Text = "";
                lbl_err_uprice.Text = "";
                lbl_err_qty.Text = "Enter numbers only";

            }
            else
            {
                lbl_err_code.Text = "";
                lbl_err_name.Text = "";
                lbl_err_uprice.Text = "";
                lbl_err_qty.Text = "";
                try
                {
                    string query = "Insert Into Part values('" + txt_pcode.Text + "','" + txt_name.Text + "','" + txt_uprice.Text + "','" + txt_qty.Text + "')";
                    int line = obj.Save_Update_Delete(query);
                    if (line == 1)
                        MessageBox.Show("Data save successfully", "Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Data cannot save", "Error",
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
    }
}
