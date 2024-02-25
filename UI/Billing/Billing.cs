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
    public partial class Billing : Form
    {
        public string cusid { get; set; }
        public Billing()
        {
            InitializeComponent();
        }
        DBConection obj = new DBConection();

        public SqlConnection getconnection()
        {
            return new SqlConnection("Data Source=LAPTOP-B79T3VMQ;Initial Catalog=AutoCare;Integrated Security=True");
        }

        public void clearDetails()
        {
            cmb_pmethod.Text = "";
            txt_cash.Text = "";
            txt_sub_total.Text = "";
            txt_tax.Text = "";
            txt_discount.Text = "";
            txt_balance.Text = "";
            txt_total.Text = "";

            txt_product_id.Text = "";
            txt_product_name.Text = "";
            txt_qty.Text = "";
            txt_price.Text = "";
            txt_p_amount.Text = "";

            txt_service_no.Text = "";
            txt_service_name.Text = "";
            txt_s_amount.Text = "";

            txt_Invoice_no.Text = "";
            txt_cusID.Text = "";
            DateTimePicker1.Text = "";

            dataGridView1.DataSource = null;

        }

        private void btn_bill_clear_Click(object sender, EventArgs e)
        {
           
            cmb_pmethod.Text = "";
            txt_cash.Text = "";
            
            txt_tax.Text = "";
            txt_discount.Text = "";
            txt_balance.Text = "";
            txt_total.Text = "";

            lbl_err_pmethod.Text = "";
            lbl_err_cash.Text = "";
            lbl_err_subtotal.Text = "";
            lbl_err_tax.Text = "";
            lbl_err_discount.Text = "";
            
        }

        private void Billing_Load(object sender, EventArgs e)
        {
            txt_cusID.Text =cusid;

            try
            {
                using (SqlConnection cn = getconnection())
                {
                    cn.Open();

                    SqlCommand cmd3 = cn.CreateCommand();
                    cmd3.CommandText = "SELECT IDENT_CURRENT('Bill') +1";
                    SqlDataReader sr = cmd3.ExecuteReader();
                    if (sr.Read())
                    {
                        txt_Invoice_no.Text = sr[0].ToString();
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

        private void txt_product_id_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                txt_product_name.Text = "";
                txt_qty.Text = "";
                txt_price.Text = "";
                txt_p_amount.Text = "";
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-B79T3VMQ;Initial Catalog=AutoCare;Integrated Security=True");
            con.Open();
            string id = Convert.ToString(txt_product_id.Text);
            txt_product_id.Text = id;
            SqlCommand cmd = new SqlCommand("Select Part_Name, Unit_Price from Part where Part_Code  ='" + id + "' ", con);
            SqlDataReader da = cmd.ExecuteReader();
            while(da.Read())
            {
                    txt_product_name.Text = da.GetValue(0).ToString();
                    txt_price.Text = da.GetValue(1).ToString();
            }
            con.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Data cannot show", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(IndexOutOfRangeException)
            {
                MessageBox.Show("IndexOutOfRange", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show(" Check Again", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_qty.Text != "")
                {
                    txt_p_amount.Text = (Int64.Parse(txt_price.Text) * Int64.Parse(txt_qty.Text)).ToString();
                }
                else
                {
                    txt_p_amount.Clear();
                }
            }
            catch(OverflowException)
            {
                MessageBox.Show(" Check Again", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show(" Check Again", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected int n, totalAmount = 0;
        protected Int64 quantity, issueqty;
        string valueId;
        protected Int64 qty;
        int valueAmount;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valueAmount = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                valueId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                qty = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Select item first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
               
                    string query2 = "Insert into Bill(Cus_Id,Payment_Method,Sub_Total,Tax,Discount,Total,Order_Date)values('" + txt_cusID.Text + "','" +cmb_pmethod.SelectedItem+ "','" +txt_sub_total.Text + "','" + txt_tax.Text + "','" + txt_discount.Text + "','"+txt_total.Text+ "','"+ DateTimePicker1.Value.ToString()+ "')";
                    int line2 = obj.Save_Update_Delete(query2);
                    if (line2 == 1)
                    {
                        MessageBox.Show("Bill Saved", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Can't Save", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        string query1 = "Insert into Order_Bill(PS_no,Name,price,Qty,Amount) values('" + dataGridView1.Rows[n].Cells[0].Value + "','" + dataGridView1.Rows[n].Cells[1].Value + "','" + dataGridView1.Rows[n].Cells[2].Value + "','" + dataGridView1.Rows[n].Cells[3].Value + "','" + dataGridView1.Rows[n].Cells[4].Value + "')";
                        int line3 = obj.Save_Update_Delete(query1);
                        if (line3 == 1)
                        {
                            MessageBox.Show("Order Bill Saved", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Can't Save", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                clearDetails();
                    //LoadBillNo();
                    dataGridView1.ClearSelection();
                    dataGridView1.DataSource = null;



            }
            catch (Exception)
            {
                MessageBox.Show("Check again", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_p_clear_Click(object sender, EventArgs e)
        {
            txt_product_id.Text = "";
            txt_product_name.Text = "";
            txt_qty.Text = "";
            txt_price.Text = "";
            txt_p_amount.Text = "";
        }

        private void btn_s_clear_Click(object sender, EventArgs e)
        {
            txt_service_no.Text = "";
            txt_service_name.Text = "";
            txt_s_amount.Text = "";
        }

        private void btn_s_add_Click(object sender, EventArgs e)
        {
            if (txt_service_no.Text.Length == 0)
            {
                lbl_err_sid.Text = "cannot be blank";

            }
            else if (txt_service_name.Text.Length == 0)
            {
                lbl_err_sid.Text = "";
                lbl_err_sname.Text = "cannot be blank";

            }
            else if (txt_s_amount.Text.Length == 0)
            {
                lbl_err_sid.Text = "";
                lbl_err_sname.Text = "";
                lbl_err_samount.Text = "cannot be blank";

            }
            else
            {
                lbl_err_sid.Text = "";
                lbl_err_sname.Text = "";
                lbl_err_samount.Text = "";

                n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = txt_service_no.Text;
                dataGridView1.Rows[n].Cells[1].Value = txt_service_name.Text;
                dataGridView1.Rows[n].Cells[4].Value = txt_s_amount.Text;

                totalAmount = totalAmount + int.Parse(txt_s_amount.Text);
                txt_sub_total.Text = totalAmount.ToString();

                {
                    MessageBox.Show("Added Successfuly", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                lbl_err_sid.Text = "";
                lbl_err_sname.Text = "";
                lbl_err_samount.Text = "";
            }
        }
        public double total,tax,dicount,balance,cash;

        private void txt_service_no_TextChanged(object sender, EventArgs e)
        {
            try
            {
              
                txt_service_name.Text = "";
                txt_s_amount.Text = "";

                SqlConnection con = new SqlConnection("Data Source=LAPTOP-B79T3VMQ;Initial Catalog=AutoCare;Integrated Security=True");
                con.Open();
                string id = Convert.ToString(txt_service_no.Text);
                txt_service_no.Text = id;
                SqlCommand cmd = new SqlCommand("Select Service_Name, Unit_Price from Service where Service_Id  ='" + id + "' ", con);
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    txt_service_name.Text = da.GetValue(0).ToString();
                    txt_s_amount.Text = da.GetValue(1).ToString();
                }
                con.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Data cannot show", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("IndexOutOfRange", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show(" Check Again", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_s_delete_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                {
                    MessageBox.Show(" Removed from Bill.", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        private void btn_home_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btn_total_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(cmb_pmethod.Text))
            {
                lbl_err_pmethod.Text = "cannot be blank";

            }
            else if(!txt_cash.Text.Any(char.IsDigit))
            {

                lbl_err_pmethod.Text = "";
                lbl_err_cash.Text = "Enter numbers only";

            }
            else if (txt_sub_total.Text.Length == 0)
            {

                lbl_err_pmethod.Text = "";
                lbl_err_cash.Text = "";
                lbl_err_subtotal.Text = "cannot be blank";

            }
            else if (txt_tax.Text.Length == 0)
            {
                lbl_err_pmethod.Text = "";
                lbl_err_cash.Text = "";
                lbl_err_subtotal.Text = "";
                lbl_err_tax.Text = "cannot be blank";

            }
            else if (txt_discount.Text.Length == 0)
            {

                lbl_err_pmethod.Text = "";
                lbl_err_cash.Text = "";
                lbl_err_subtotal.Text = "";
                lbl_err_tax.Text = "";
                lbl_err_discount.Text = "cannot be blank";

            }
            else
            {
                lbl_err_pmethod.Text = "";
                lbl_err_cash.Text = "";
                lbl_err_subtotal.Text = "";
                lbl_err_tax.Text = "";
                lbl_err_discount.Text = "";
                

                dicount = Convert.ToDouble(txt_discount.Text);
                tax = Convert.ToDouble(txt_tax.Text);
                cash = Convert.ToDouble(txt_cash.Text);

                total = (totalAmount - dicount) + tax;

                txt_total.Text = total.ToString();
                if (cmb_pmethod.Text == "Cash")
                {
                    balance = cash - total;
                    txt_balance.Text = balance.ToString();
                }
                else
                {
                   
                }

                

                
            }
        }

        private void txt_qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void cmb_pmethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_pmethod.Text == "Cash")
            {
                txt_cash.Enabled = true;
                txt_cash.Text = "";
                txt_cash.Focus();
            }
            else
            {
                txt_cash.Enabled = false;
                txt_cash.Text = "0";
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_p_delete_Click(object sender, EventArgs e)
        {
            if (valueId != null)
            {
                try
                {
                    dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                    string query = "select Qty from Part where Part_Code = '" + valueId + "'";
                    DataSet ds = obj.getData(query);
                    quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    issueqty = quantity + qty;

                    string query3 = "update Part set Qty = '" + issueqty + "' where Part_Code = '" + valueId + "' ";
                    int line = obj.Save_Update_Delete(query3);
                    if (line == 1)
                    {
                        MessageBox.Show("Part Removed from Bill.", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Can't Remove ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    totalAmount = totalAmount - valueAmount;
                    txt_sub_total.Text = totalAmount.ToString();
                }
                catch(NullReferenceException)
                {
                    MessageBox.Show("Can't Remove ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (SqlException)
                {
                    MessageBox.Show("Can't Remove ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Can't Remove ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {

                   
                }
              
            }
        }

        private void btn_p_add_Click(object sender, EventArgs e)
        {
            if (txt_product_id.Text.Length == 0)
            {
                lbl_err_pid.Text = "cannot be blank";

            }
            else if(txt_product_name.Text.Length == 0)
            {
                lbl_err_pid.Text = "";
                lbl_err_pname.Text = "cannot be blank";

            }
            else if (txt_price.Text.Length == 0)
            {
                lbl_err_pid.Text = "";
                lbl_err_pname.Text = "";
                lbl_err_price.Text = "cannot be blank";

            }
            else if (txt_qty.Text.Length == 0)
            {
                lbl_err_pid.Text = "";
                lbl_err_pname.Text = "";
                lbl_err_price.Text = "";
                lbl_err_qty.Text = "cannot be blank";

            }
            else if (txt_p_amount.Text.Length == 0)
            {
                lbl_err_pid.Text = "";
                lbl_err_pname.Text = "";
                lbl_err_price.Text = "";
                lbl_err_qty.Text = "";
                lbl_err_pamount.Text = "cannot be blank";

            }


            else
            {
                try
                {
                    lbl_err_pid.Text = "";
                    lbl_err_pname.Text = "";
                    lbl_err_price.Text = "";
                    lbl_err_qty.Text = "";
                    lbl_err_pamount.Text = "";

                    string query = "select Qty from Part where Part_Code = '" + txt_product_id.Text + "'";
                    DataSet ds = obj.getData(query);
                    quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    issueqty = quantity - Int64.Parse(txt_qty.Text);

                    if (issueqty >= 0)
                    {
                        n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = txt_product_id.Text;
                        dataGridView1.Rows[n].Cells[1].Value = txt_product_name.Text;
                        dataGridView1.Rows[n].Cells[2].Value = txt_price.Text;
                        dataGridView1.Rows[n].Cells[3].Value = txt_qty.Text;
                        dataGridView1.Rows[n].Cells[4].Value = txt_p_amount.Text;

                        totalAmount = totalAmount + int.Parse(txt_p_amount.Text);
                        txt_sub_total.Text = totalAmount.ToString();

                        string query1 = "update Part set Qty = '" + issueqty + "' where Part_Code = '" + txt_product_id.Text + "' ";
                        int line = obj.Save_Update_Delete(query1);
                        if (line == 1)
                        {
                            MessageBox.Show("Added Successfuly", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Can't Add ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Part is Out of Stock.\n Only " + quantity + " Left ", "Warning !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    dataGridView1.Refresh();
                    txt_product_id.Focus();
                    txt_product_id.Text = "";
                    txt_product_name.Text = "";
                    txt_qty.Text = "";
                    txt_price.Text = "";
                    txt_p_amount.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }  
}
