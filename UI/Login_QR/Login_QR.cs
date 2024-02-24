using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using System.Data.SqlClient;

namespace A__Auto_Care
{
    public partial class Login_QR : Form
    {
        
        public Login_QR()
        {
            InitializeComponent();
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;
        DBConection obj = new DBConection();
        
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_cusID.Text.Length == 0)
            {
                lbl_err_id.Text = "Please enter customer ID";

            }
            else if (txt_cusID.Text.Length >= 5)
            {
                lbl_err_id.Text = "too long!";
            }
            else if(!txt_cusID.Text.Any(char.IsDigit))
            {
                lbl_err_id.Text = "Please enter numbers only";
            }
            else
            {
                lbl_err_id.Text = "";
                try
                {
                    string query = "Select Count(*) from Customer where Customer_Id= '" + txt_cusID.Text + "'";
                    DataTable dt = obj.Display(query);

                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Billing form = new Billing();
                        form.cusid = txt_cusID.Text;
                        form.ShowDialog();
                    }
                    else
                    {
                  
                        MessageBox.Show("Enter valid Customer Id !", "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch(NullReferenceException)
                {

                }
                catch(SqlException)
                {

                }
                catch(Exception)
                {

                }

            }


        }

        private void Login_QR_Load(object sender, EventArgs e)
        {
            txt_cusID.ReadOnly = true;
            try
            {
                filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                foreach (FilterInfo filterInfo in filterInfoCollection)
                    cboDevice.Items.Add(filterInfo.Name);
                cboDevice.SelectedIndex = 0;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please check again", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception)
            {
                MessageBox.Show("Please check again", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void RadioButton_QR_CheckedChanged(object sender, EventArgs e)
        {
            txt_cusID.ReadOnly = true;
            try
            {
                captureDevice = new VideoCaptureDevice(filterInfoCollection[cboDevice.SelectedIndex].MonikerString);
                captureDevice.NewFrame += CaptureDevice_NewFrame;
                captureDevice.Start();
                timer1.Start();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please check again", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception)
            {
                MessageBox.Show("Please check again", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                picbox_qrscan.Image = (Bitmap)eventArgs.Frame.Clone();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please check again", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception)
            {
                MessageBox.Show("Please check again", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_QR_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (captureDevice.IsRunning)
                    captureDevice.Stop();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please check again", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception)
            {
                MessageBox.Show("Please check again", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try { 

            if (picbox_qrscan != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)picbox_qrscan.Image);
                if (result != null)
                {
                    txt_cusID.Text = result.ToString();
                    timer1.Stop();
                    if (captureDevice.IsRunning)
                        captureDevice.Stop();
                }
            }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please check again", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception)
            {
                MessageBox.Show("Please check again", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RadioButton_ID_CheckedChanged(object sender, EventArgs e)
        {
            txt_cusID.ReadOnly = false;
        }

        private void txt_cusID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
