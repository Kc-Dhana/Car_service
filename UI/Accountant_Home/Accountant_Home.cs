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
    public partial class Accountant_Home : Form
    {
        public Accountant_Home()
        {
            InitializeComponent();
            CustomeDesing();
        }
        private void CustomeDesing()
        {
            panel_Suuplier.Visible = false;
            panel_parts.Visible = false;
            panel_service.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panel_Suuplier.Visible == true)
                panel_Suuplier.Visible = false;
            if (panel_parts.Visible == true)
                panel_parts.Visible = false;
            if (panel_service.Visible == true)
                panel_service.Visible = false;
        }
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

        private void Accountant_Home_Load(object sender, EventArgs e)
        {

        }

        private void btn_Supplier_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panel_Suuplier);
        }

        private void btn_parts_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panel_parts);
        }

        private void btn_service_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panel_service);
        }

        private void btn_add_sup_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Supplier_Add());
            hideSubMenu();
        }

        private void btn_update_sup_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Supplier_Update());
            hideSubMenu();
        }

        private void btn_view_supplier_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Supplier_View());
            hideSubMenu();
        }

        private void btn_delete_sup_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Supplier_Delete());
            hideSubMenu();
        }

        private void btn_add_parts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Parts_Add());
            hideSubMenu();
        }

        private void btn_update_parts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Parts_Update());
            hideSubMenu();
        }

        private void btn_view_parts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Parts_View());
            hideSubMenu();
        }

        private void btn_delete_parts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Parts_Delete());
            hideSubMenu();
        }

        private void btn_check_qty_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Check_Qty());
            hideSubMenu();
        }

        private void btn_add_service_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Service_Add());
            hideSubMenu();
        }

        private void btn_update_service_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Service_Update());
            hideSubMenu();
        }

        private void btn_view_service_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Service_View());
            hideSubMenu();
        }

        private void btn_delete_service_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Service_Delete());
            hideSubMenu();
        }

        private Form activeForm = null;

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

        private void btn_order_parts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Order_Parts());
            hideSubMenu();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            this.Hide();
            obj.Show();
        }
    }
}
