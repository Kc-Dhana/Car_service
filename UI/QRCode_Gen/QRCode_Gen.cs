using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;


namespace A__Auto_Care
{
    public partial class QRCode_Gen : Form
    {
        public string cusID { get; set; }
        public string email { get; set; }
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;
        public QRCode_Gen()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void btn_send_Click(object sender, EventArgs e)
        {
            if(picbox_qr.Image==null)
            {
                lbl_err_pic.Text = "please genarate QR code first";
;           }
            else
            {
                lbl_err_pic.Text = "";

                 try
                {
                    MailMessage msg = new MailMessage();
                    msg.From = new MailAddress("pharmacyatom@gmail.com");
                    msg.To.Add(txt_email.Text);
                   
                    msg.Subject = ("Customer ID");
                    msg.Body = (txt_genID.Text);

                    SmtpClient smt = new SmtpClient();
                    smt.Host = "smtp.gmail.com";
                    System.Net.NetworkCredential ntcd = new NetworkCredential();
                    ntcd.UserName = "aplusautocarenibm@gmail.com";
                    ntcd.Password = "bjpbagfhudhdcvsy";
                    smt.Credentials = ntcd;
                    smt.EnableSsl = true;
                    smt.Port =587;
                    smt.Send(msg);


                    MessageBox.Show("Your mail is sended", "info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Cannot send Email", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Cannot send Email", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void QRCode_Gen_Load(object sender, EventArgs e)
        {
            txt_genID.Text = cusID;
            txt_email.Text = email;

        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
            var MyData = QG.CreateQrCode(txt_genID.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(MyData);
            picbox_qr.Image = code.GetGraphic(50);
             if (txt_genID.Text.Length == 0)
             {
                lbl_err_id.Text = "please enter Customer ID";

             }
             else
             {
                 lbl_err_id.Text = "";

             }
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_err_email_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
