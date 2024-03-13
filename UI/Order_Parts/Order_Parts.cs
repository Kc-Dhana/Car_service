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
    public partial class Order_Parts : Form
    {
        public Order_Parts()
        {
            InitializeComponent();
        }
        DBConection obj = new DBConection();
        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_order.Controls.Add(childForm);
            panel_order.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void btn_req_order_Click_1(object sender, EventArgs e)
        {
            Send_Email form = new Send_Email();
            form.email=txt_email.Text;
            form.cname = txt_cname.Text;
            form.pname = txt_pname.Text;
            form.qty = txt_qty.Text;
            form.ShowDialog();

            if (txt_pname.Text.Length == 0)
            {
                lbl_err_pname.Text = "Name cannot be blank";
            }
            else if (!Regex.IsMatch(txt_pname.Text, @"^[a-zA-Z]+$"))
            {
                lbl_err_pname.Text = "Name cannot have Digit or Symbol";

            }
            //2
            else if (txt_qty.Text.Length == 0)
            {
                lbl_err_pname.Text = "";
                lbl_err_qty.Text = "QTY cannot be blank";

            }
            else if (Regex.IsMatch(txt_qty.Text, "[^0-9]"))
            {
                lbl_err_pname.Text = "";
                lbl_err_qty.Text = "Enter numbers only";
            }
            //3
            else if (txt_cname.Text.Length == 0)
            {
                lbl_err_pname.Text = "";
                lbl_err_qty.Text = "";
                lbl_err_cname.Text = "Name cannot be blank";
            }
            else if (!Regex.IsMatch(txt_cname.Text, @"^[a-zA-Z]+$"))
            {
                lbl_err_pname.Text = "";
                lbl_err_qty.Text = "";
                lbl_err_cname.Text = "Name cannot have Digit or Symbol";

            }
            //4
            else if (txt_email.Text.Length == 0)
            {
                lbl_err_cname.Text = "";
                lbl_err_pname.Text = "";
                lbl_err_qty.Text = "";
                lbl_err_email.Text = "Email cannot be blank";

            }
            else if (!Regex.IsMatch(txt_email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                lbl_err_cname.Text = "";
                lbl_err_pname.Text = "";
                lbl_err_qty.Text = "";
                lbl_err_email.Text = "Email must be a valid one   Ex-dimuthu123@gmail.com";

            }
            else
            {
                lbl_err_supplier.Text = "";
                lbl_err_pname.Text = "";
                lbl_err_qty.Text = "";
                lbl_err_cname.Text = "";
                lbl_err_email.Text = "";
                OpenChildForm(new Send_Email());
            }

        }

        private void btn_p_clear_Click_1(object sender, EventArgs e)
        {
            dataGridView_parts.DataSource = null;
            dataGridView_supplier.DataSource = null;
            txt_pname.Text = "";
            txt_qty.Text = "";
            txt_cname.Text = "";
            txt_email.Text = "";
            txt_partid.Text = "";

            lbl_err_supplier.Text = "";
            lbl_err_pname.Text = "";
            lbl_err_qty.Text = "";
            lbl_err_cname.Text = "";
            lbl_err_email.Text = "";
        }

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_search_sup_Click(object sender, EventArgs e)
        {
            if (dataGridView_parts.DataSource == null)
            {
                lbl_err_supplier.Text = "please Select Parts";
            }
            else 
            {
                string query = "Select * from Supplier where part_id='" + txt_partid.Text + "'";
                dataGridView_supplier.DataSource = obj.Display(query);
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "Select * from Part where Qty<10";
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

        private void btn_searchall_Click(object sender, EventArgs e)
        {
            try
            {
                string query = " Select * from Part";
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

        private void dataGridView_parts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_partid.Text = dataGridView_parts.CurrentRow.Cells["Part_Code"].Value.ToString();
            txt_pname.Text = dataGridView_parts.CurrentRow.Cells["Part_Name"].Value.ToString();
            
        }

        private void dataGridView_supplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_cname.Text = dataGridView_supplier.CurrentRow.Cells["Company_Name"].Value.ToString();
            txt_email.Text = dataGridView_supplier.CurrentRow.Cells["Email"].Value.ToString();
        }
    }
}
