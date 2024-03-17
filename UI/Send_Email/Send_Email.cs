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
using System.Net;
using System.Net.Mail;


namespace A__Auto_Care
{
    public partial class Send_Email : Form
    {
        public string email { get; set; }
        public string cname { get; set; }
        public string pname { get; set; }
        public string qty { get; set; }
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;

       // public string message = ("We need " + qty );
       
        public Send_Email()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (txt_username.Text.Length == 0)
            {
                lbl_err_username.Text = "User name cannot be blank";
            }
            else if (!Regex.IsMatch(txt_username.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                lbl_err_username.Text = "Email must be a valid one   Ex-name123@gmail.com";

            }
            //2
            else if (txt_password.Text.Length == 0)
            {
                lbl_err_username.Text= "";
                lbl_err_password.Text = "Password cannot be blank";
            }
            //3
            else if (txt_to.Text.Length == 0)
            {
                lbl_err_username.Text = "";
                lbl_err_password.Text = "";
                lbl_err_to.Text = "cannot be blank";
            }
            else if (!Regex.IsMatch(txt_to.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                lbl_err_username.Text = "";
                lbl_err_password.Text = "";
                lbl_err_to.Text = "Email must be a valid one   Ex-name123@gmail.com";

            }
            else if (txt_message.Text.Length == 0)
            {
                lbl_err_username.Text = "";
                lbl_err_password.Text = "";
                lbl_err_to.Text = "";
                lbl_err_message.Text="Message Box cannot be blank";

            }
            else
            {
                lbl_err_username.Text = "";
                lbl_err_password.Text = "";
                lbl_err_to.Text = "";
                lbl_err_message.Text = "";
               // try
               // {
                    MailMessage msg = new MailMessage();
                    msg.From = new MailAddress("pharmacyatom@gmail.com");
                    msg.To.Add(txt_to.Text);
                    msg.CC.Add(txt_cc.Text);
                    msg.Subject = (txt_subject.Text);
                    msg.Body = (txt_message.Text);

                    SmtpClient smt = new SmtpClient();
                    smt.Host = "smtp.gmail.com";
                    System.Net.NetworkCredential ntcd = new NetworkCredential();
                    ntcd.UserName = (txt_username.Text);
                    ntcd.Password = (txt_password.Text);
                    smt.Credentials = ntcd;
                    smt.EnableSsl = true;
                    smt.Port =587;
                    smt.Send(msg);


                    MessageBox.Show("Your mail is sended", "info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
               // }
                /*catch (FormatException)
                {
                    MessageBox.Show("Cannot send Email", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Cannot send Email", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/


                /*try
               {
                    login = new NetworkCredential(txt_username.Text, txt_password.Text);
                    client = new SmtpClient(txt_smtp.Text);
                    client.Port = Convert.ToInt32(txt_port.Text);
                    client.EnableSsl = chkSSL.Checked;
                    client.Credentials = login;
                    msg = new MailMessage { From = new MailAddress(txt_username.Text + txt_smtp.Text.Replace("smtp.", "@"), "Lucy", Encoding.UTF8) };
                    msg.To.Add(new MailAddress(txt_to.Text));
                    if (!String.IsNullOrEmpty(txt_cc.Text))
                        msg.To.Add(new MailAddress(txt_cc.Text));
                    msg.Subject = txt_subject.Text;
                    msg.Body = txt_message.Text;
                    msg.BodyEncoding = Encoding.UTF8;
                    msg.IsBodyHtml = true;
                    msg.Priority = MailPriority.Normal;
                    msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                    client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
                    string userstate = "Sending...";
                    client.SendAsync(msg, userstate);
                }
                catch(FormatException)
                {
                    MessageBox.Show("Cannot send Email", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch(Exception)
                {
                    MessageBox.Show("Cannot send Email", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/
            }

        }

        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
                MessageBox.Show(string.Format("{0} send cancelled.", e.UserState), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (e.Error != null)
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Your message has been successfully sent", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            

         }
        public string message;
        

        private void Send_Email_Load(object sender, EventArgs e)
        {

            message = "We need "+qty+" quantity of "+ pname+" Form "+cname;
            txt_to.Text = email;
            txt_message.Text = message;
        }

        private void Setting_Enter(object sender, EventArgs e)
        {

        }

        private void lbl_err_username_Click(object sender, EventArgs e)
        {

        }

        private void lbl_err_message_Click(object sender, EventArgs e)
        {

        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_err_password_Click(object sender, EventArgs e)
        {

        }

        private void txt_to_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_subject_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
