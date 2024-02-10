using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A__Auto_Care
{
    public partial class Reception_home : Form
    {
        public Reception_home()
        {
            InitializeComponent();
            CustomeDesing();
        }
        
        private void CustomeDesing()
        {
            panel_customer.Visible = false;
            panel_details.Visible = false;
            panel_bill.Visible = false;
        }
        private void hideSubMenu()
        {
            if(panel_customer.Visible == true)
                panel_customer.Visible = false;
            if (panel_details.Visible == true)
                panel_details.Visible = false;
            if (panel_bill.Visible == true)
                panel_bill.Visible = false;
        }
        //
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;


        }

        private void Reception_home_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_cus_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panel_customer);
        }

        private void btn_cus_reg_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Customer_Registration());
            hideSubMenu();
        }

        private void btn_cus_details_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Customer_Details());
            hideSubMenu();
        }

        private void btn_cus_update_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Update_Customer());
            hideSubMenu();
        }

        private void btn_details_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panel_details);
        }

        private void btn_pro_details_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Product_Details());
            hideSubMenu();
        }

        private void btn_service_details_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Service_Details());
            hideSubMenu();
        }

        private void btn_bill_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panel_bill);
        }

        //
        private Form activeForm = null;
        //
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_child_form.Controls.Add(childForm);
            panel_child_form.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void panel_child_form_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            this.Hide();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Login_QR());
            hideSubMenu();
        }

        private void btn_bill_report_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Bill_report());
            hideSubMenu();
        }
    }
}
