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
    public partial class Parts_Update : Form
    {
        public Parts_Update()
        {
            InitializeComponent();
        }
        DBConection obj = new DBConection();
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_pcode.Text.Length == 0)
            {
                lbl_err_code.Text = "Parts Code cannot be blank";

            }
            else
            {
                lbl_err_code.Text = "";
                try
                {
                    string query = " Select * from Part where Part_Code = '" + txt_pcode.Text + "' ";
                    dataGridView_parts.DataSource = obj.Display(query);
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
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_pcode.Text = "";
            dataGridView_parts.DataSource = null;
            txt_name.Text = "";
            txt_uprice.Text = "";
            txt_qty.Text = "";

            lbl_err_code.Text = "";
            lbl_err_name.Text = "";
            lbl_err_uprice.Text = "";
            lbl_err_qty.Text = "";
        }

        private void btn_update_Click(object sender, EventArgs e)
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
                lbl_err_name.Text = "";
                lbl_err_uprice.Text = "Enter numbers only";

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
                    string query = "Update Part set  Part_Name= '" + txt_name.Text + "', Unit_Price = '" + txt_uprice.Text + "', Qty=  '" + txt_qty.Text + "' where Part_Code = '" + txt_pcode.Text + "' ";
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

        private void dataGridView_parts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_name.Text = dataGridView_parts.CurrentRow.Cells["Part_Name"].Value.ToString();
            txt_uprice.Text = dataGridView_parts.CurrentRow.Cells["Unit_Price"].Value.ToString();
            txt_qty.Text = dataGridView_parts.CurrentRow.Cells["Qty"].Value.ToString();
            
        }

        private void Parts_Update_Load(object sender, EventArgs e)
        {

        }
    }   
}
