
namespace A__Auto_Care
{
    partial class Order_Parts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_order = new System.Windows.Forms.Panel();
            this.lbl_err_supplier = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_back = new Guna.UI2.WinForms.Guna2Button();
            this.btn_req_order = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_err_qty = new System.Windows.Forms.Label();
            this.lbl_err_pname = new System.Windows.Forms.Label();
            this.txt_pname = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_err_email = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_qty = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_err_cname = new System.Windows.Forms.Label();
            this.txt_cname = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_p_clear = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_search_sup = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView_supplier = new System.Windows.Forms.DataGridView();
            this.btn_check = new Guna.UI2.WinForms.Guna2Button();
            this.btn_searchall = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView_parts = new System.Windows.Forms.DataGridView();
            this.txt_partid = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel_order.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_supplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_parts)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_order
            // 
            this.panel_order.Controls.Add(this.txt_partid);
            this.panel_order.Controls.Add(this.lbl_err_supplier);
            this.panel_order.Controls.Add(this.panel2);
            this.panel_order.Controls.Add(this.label7);
            this.panel_order.Controls.Add(this.label6);
            this.panel_order.Controls.Add(this.label5);
            this.panel_order.Controls.Add(this.btn_search_sup);
            this.panel_order.Controls.Add(this.dataGridView_supplier);
            this.panel_order.Controls.Add(this.btn_check);
            this.panel_order.Controls.Add(this.btn_searchall);
            this.panel_order.Controls.Add(this.dataGridView_parts);
            this.panel_order.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_order.Location = new System.Drawing.Point(0, 0);
            this.panel_order.Name = "panel_order";
            this.panel_order.Size = new System.Drawing.Size(1215, 789);
            this.panel_order.TabIndex = 0;
            // 
            // lbl_err_supplier
            // 
            this.lbl_err_supplier.AutoSize = true;
            this.lbl_err_supplier.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_err_supplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_err_supplier.Location = new System.Drawing.Point(741, 243);
            this.lbl_err_supplier.Name = "lbl_err_supplier";
            this.lbl_err_supplier.Size = new System.Drawing.Size(0, 20);
            this.lbl_err_supplier.TabIndex = 130;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.btn_back);
            this.panel2.Controls.Add(this.btn_req_order);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lbl_err_qty);
            this.panel2.Controls.Add(this.lbl_err_pname);
            this.panel2.Controls.Add(this.txt_pname);
            this.panel2.Controls.Add(this.lbl_err_email);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txt_email);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_qty);
            this.panel2.Controls.Add(this.lbl_err_cname);
            this.panel2.Controls.Add(this.txt_cname);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btn_p_clear);
            this.panel2.Location = new System.Drawing.Point(22, 482);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1171, 287);
            this.panel2.TabIndex = 128;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btn_back
            // 
            this.btn_back.AutoRoundedCorners = true;
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_back.BorderRadius = 21;
            this.btn_back.BorderThickness = 1;
            this.btn_back.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_back.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_back.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_back.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_back.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_back.HoverState.ForeColor = System.Drawing.Color.Red;
            this.btn_back.Location = new System.Drawing.Point(929, 217);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(84, 45);
            this.btn_back.TabIndex = 129;
            this.btn_back.Text = "Back";
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click_1);
            // 
            // btn_req_order
            // 
            this.btn_req_order.AutoRoundedCorners = true;
            this.btn_req_order.BackColor = System.Drawing.Color.Transparent;
            this.btn_req_order.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_req_order.BorderRadius = 23;
            this.btn_req_order.BorderThickness = 1;
            this.btn_req_order.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_req_order.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_req_order.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_req_order.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_req_order.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_req_order.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_req_order.ForeColor = System.Drawing.Color.White;
            this.btn_req_order.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_req_order.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_req_order.Location = new System.Drawing.Point(1019, 217);
            this.btn_req_order.Name = "btn_req_order";
            this.btn_req_order.Size = new System.Drawing.Size(132, 48);
            this.btn_req_order.TabIndex = 120;
            this.btn_req_order.Text = "Request";
            this.btn_req_order.Click += new System.EventHandler(this.btn_req_order_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label8.Location = new System.Drawing.Point(439, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 38);
            this.label8.TabIndex = 128;
            this.label8.Text = "Order Details";
            // 
            // lbl_err_qty
            // 
            this.lbl_err_qty.AutoSize = true;
            this.lbl_err_qty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_err_qty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_err_qty.Location = new System.Drawing.Point(168, 217);
            this.lbl_err_qty.Name = "lbl_err_qty";
            this.lbl_err_qty.Size = new System.Drawing.Size(0, 20);
            this.lbl_err_qty.TabIndex = 127;
            // 
            // lbl_err_pname
            // 
            this.lbl_err_pname.AutoSize = true;
            this.lbl_err_pname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_err_pname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_err_pname.Location = new System.Drawing.Point(168, 136);
            this.lbl_err_pname.Name = "lbl_err_pname";
            this.lbl_err_pname.Size = new System.Drawing.Size(0, 20);
            this.lbl_err_pname.TabIndex = 126;
            // 
            // txt_pname
            // 
            this.txt_pname.AutoRoundedCorners = true;
            this.txt_pname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.txt_pname.BorderRadius = 18;
            this.txt_pname.BorderThickness = 2;
            this.txt_pname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pname.DefaultText = "";
            this.txt_pname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_pname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_pname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pname.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txt_pname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_pname.Font = new System.Drawing.Font("Verdana", 12F);
            this.txt_pname.ForeColor = System.Drawing.Color.White;
            this.txt_pname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_pname.Location = new System.Drawing.Point(147, 94);
            this.txt_pname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pname.Name = "txt_pname";
            this.txt_pname.PasswordChar = '\0';
            this.txt_pname.PlaceholderText = "";
            this.txt_pname.SelectedText = "";
            this.txt_pname.Size = new System.Drawing.Size(255, 39);
            this.txt_pname.TabIndex = 117;
            // 
            // lbl_err_email
            // 
            this.lbl_err_email.AutoSize = true;
            this.lbl_err_email.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_err_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_err_email.Location = new System.Drawing.Point(653, 217);
            this.lbl_err_email.Name = "lbl_err_email";
            this.lbl_err_email.Size = new System.Drawing.Size(0, 20);
            this.lbl_err_email.TabIndex = 125;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(25, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 23);
            this.label11.TabIndex = 119;
            this.label11.Text = "Order Qty";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(25, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 23);
            this.label10.TabIndex = 118;
            this.label10.Text = "Product Name";
            // 
            // txt_email
            // 
            this.txt_email.AutoRoundedCorners = true;
            this.txt_email.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.txt_email.BorderRadius = 18;
            this.txt_email.BorderThickness = 2;
            this.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_email.DefaultText = "";
            this.txt_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_email.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txt_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_email.Font = new System.Drawing.Font("Verdana", 12F);
            this.txt_email.ForeColor = System.Drawing.Color.White;
            this.txt_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_email.Location = new System.Drawing.Point(634, 174);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.PlaceholderText = "";
            this.txt_email.SelectedText = "";
            this.txt_email.Size = new System.Drawing.Size(255, 39);
            this.txt_email.TabIndex = 124;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(472, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 123;
            this.label1.Text = "Email Address";
            // 
            // txt_qty
            // 
            this.txt_qty.AutoRoundedCorners = true;
            this.txt_qty.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.txt_qty.BorderRadius = 18;
            this.txt_qty.BorderThickness = 2;
            this.txt_qty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_qty.DefaultText = "";
            this.txt_qty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_qty.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_qty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_qty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_qty.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txt_qty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_qty.Font = new System.Drawing.Font("Verdana", 12F);
            this.txt_qty.ForeColor = System.Drawing.Color.White;
            this.txt_qty.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_qty.Location = new System.Drawing.Point(147, 174);
            this.txt_qty.Margin = new System.Windows.Forms.Padding(4);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.PasswordChar = '\0';
            this.txt_qty.PlaceholderText = "";
            this.txt_qty.SelectedText = "";
            this.txt_qty.Size = new System.Drawing.Size(255, 39);
            this.txt_qty.TabIndex = 116;
            // 
            // lbl_err_cname
            // 
            this.lbl_err_cname.AutoSize = true;
            this.lbl_err_cname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_err_cname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_err_cname.Location = new System.Drawing.Point(653, 138);
            this.lbl_err_cname.Name = "lbl_err_cname";
            this.lbl_err_cname.Size = new System.Drawing.Size(0, 20);
            this.lbl_err_cname.TabIndex = 122;
            // 
            // txt_cname
            // 
            this.txt_cname.AutoRoundedCorners = true;
            this.txt_cname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.txt_cname.BorderRadius = 18;
            this.txt_cname.BorderThickness = 2;
            this.txt_cname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_cname.DefaultText = "";
            this.txt_cname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_cname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_cname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_cname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_cname.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txt_cname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_cname.Font = new System.Drawing.Font("Verdana", 12F);
            this.txt_cname.ForeColor = System.Drawing.Color.White;
            this.txt_cname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_cname.Location = new System.Drawing.Point(634, 94);
            this.txt_cname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cname.Name = "txt_cname";
            this.txt_cname.PasswordChar = '\0';
            this.txt_cname.PlaceholderText = "";
            this.txt_cname.SelectedText = "";
            this.txt_cname.Size = new System.Drawing.Size(255, 39);
            this.txt_cname.TabIndex = 121;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(472, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 23);
            this.label3.TabIndex = 120;
            this.label3.Text = "Company Name";
            // 
            // btn_p_clear
            // 
            this.btn_p_clear.AutoRoundedCorners = true;
            this.btn_p_clear.BackColor = System.Drawing.Color.Transparent;
            this.btn_p_clear.BorderRadius = 18;
            this.btn_p_clear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_p_clear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_p_clear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_p_clear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_p_clear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_p_clear.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_p_clear.ForeColor = System.Drawing.Color.White;
            this.btn_p_clear.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btn_p_clear.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_p_clear.Location = new System.Drawing.Point(1034, 14);
            this.btn_p_clear.Name = "btn_p_clear";
            this.btn_p_clear.Size = new System.Drawing.Size(117, 39);
            this.btn_p_clear.TabIndex = 73;
            this.btn_p_clear.Text = "Clear";
            this.btn_p_clear.Click += new System.EventHandler(this.btn_p_clear_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(586, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 23);
            this.label7.TabIndex = 127;
            this.label7.Text = "Search All Parts";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(200, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 23);
            this.label6.TabIndex = 126;
            this.label6.Text = "Check Low Qty Parts";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(32, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(275, 23);
            this.label5.TabIndex = 125;
            this.label5.Text = "Search Supplier according to PID";
            // 
            // btn_search_sup
            // 
            this.btn_search_sup.AutoRoundedCorners = true;
            this.btn_search_sup.BackColor = System.Drawing.Color.Transparent;
            this.btn_search_sup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_search_sup.BorderRadius = 23;
            this.btn_search_sup.BorderThickness = 1;
            this.btn_search_sup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_search_sup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_search_sup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_search_sup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_search_sup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_search_sup.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_search_sup.ForeColor = System.Drawing.Color.White;
            this.btn_search_sup.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_search_sup.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_search_sup.Location = new System.Drawing.Point(590, 220);
            this.btn_search_sup.Name = "btn_search_sup";
            this.btn_search_sup.Size = new System.Drawing.Size(180, 48);
            this.btn_search_sup.TabIndex = 120;
            this.btn_search_sup.Text = "Search Supplier";
            this.btn_search_sup.Click += new System.EventHandler(this.btn_search_sup_Click);
            // 
            // dataGridView_supplier
            // 
            this.dataGridView_supplier.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_supplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_supplier.Location = new System.Drawing.Point(22, 281);
            this.dataGridView_supplier.Name = "dataGridView_supplier";
            this.dataGridView_supplier.RowHeadersWidth = 51;
            this.dataGridView_supplier.RowTemplate.Height = 24;
            this.dataGridView_supplier.Size = new System.Drawing.Size(1171, 177);
            this.dataGridView_supplier.TabIndex = 124;
            this.dataGridView_supplier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_supplier_CellContentClick);
            // 
            // btn_check
            // 
            this.btn_check.AutoRoundedCorners = true;
            this.btn_check.BackColor = System.Drawing.Color.Transparent;
            this.btn_check.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_check.BorderRadius = 21;
            this.btn_check.BorderThickness = 1;
            this.btn_check.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_check.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_check.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_check.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_check.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_check.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_check.ForeColor = System.Drawing.Color.White;
            this.btn_check.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_check.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_check.Location = new System.Drawing.Point(399, 19);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(149, 45);
            this.btn_check.TabIndex = 123;
            this.btn_check.Text = "Check";
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // btn_searchall
            // 
            this.btn_searchall.AutoRoundedCorners = true;
            this.btn_searchall.BackColor = System.Drawing.Color.Transparent;
            this.btn_searchall.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_searchall.BorderRadius = 21;
            this.btn_searchall.BorderThickness = 1;
            this.btn_searchall.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_searchall.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_searchall.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_searchall.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_searchall.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_searchall.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_searchall.ForeColor = System.Drawing.Color.White;
            this.btn_searchall.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_searchall.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_searchall.Location = new System.Drawing.Point(741, 19);
            this.btn_searchall.Name = "btn_searchall";
            this.btn_searchall.Size = new System.Drawing.Size(149, 45);
            this.btn_searchall.TabIndex = 122;
            this.btn_searchall.Text = "Search All";
            this.btn_searchall.Click += new System.EventHandler(this.btn_searchall_Click);
            // 
            // dataGridView_parts
            // 
            this.dataGridView_parts.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_parts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_parts.Location = new System.Drawing.Point(22, 70);
            this.dataGridView_parts.Name = "dataGridView_parts";
            this.dataGridView_parts.RowHeadersWidth = 51;
            this.dataGridView_parts.RowTemplate.Height = 24;
            this.dataGridView_parts.Size = new System.Drawing.Size(1171, 144);
            this.dataGridView_parts.TabIndex = 121;
            this.dataGridView_parts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_parts_CellContentClick);
            // 
            // txt_partid
            // 
            this.txt_partid.AutoRoundedCorners = true;
            this.txt_partid.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.txt_partid.BorderRadius = 17;
            this.txt_partid.BorderThickness = 2;
            this.txt_partid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_partid.DefaultText = "";
            this.txt_partid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_partid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_partid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_partid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_partid.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_partid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_partid.Font = new System.Drawing.Font("Verdana", 12F);
            this.txt_partid.ForeColor = System.Drawing.Color.Black;
            this.txt_partid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_partid.Location = new System.Drawing.Point(374, 232);
            this.txt_partid.Margin = new System.Windows.Forms.Padding(4);
            this.txt_partid.Name = "txt_partid";
            this.txt_partid.PasswordChar = '\0';
            this.txt_partid.PlaceholderText = "";
            this.txt_partid.SelectedText = "";
            this.txt_partid.Size = new System.Drawing.Size(209, 36);
            this.txt_partid.TabIndex = 131;
            // 
            // Order_Parts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1215, 789);
            this.Controls.Add(this.panel_order);
            this.Name = "Order_Parts";
            this.Text = "Order_Parts";
            this.panel_order.ResumeLayout(false);
            this.panel_order.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_supplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_parts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_order;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btn_back;
        private Guna.UI2.WinForms.Guna2Button btn_req_order;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_err_qty;
        private System.Windows.Forms.Label lbl_err_pname;
        private Guna.UI2.WinForms.Guna2TextBox txt_pname;
        private System.Windows.Forms.Label lbl_err_email;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txt_email;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_qty;
        private System.Windows.Forms.Label lbl_err_cname;
        private Guna.UI2.WinForms.Guna2TextBox txt_cname;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btn_p_clear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btn_search_sup;
        private System.Windows.Forms.DataGridView dataGridView_supplier;
        private Guna.UI2.WinForms.Guna2Button btn_check;
        private Guna.UI2.WinForms.Guna2Button btn_searchall;
        private System.Windows.Forms.DataGridView dataGridView_parts;
        private System.Windows.Forms.Label lbl_err_supplier;
        private Guna.UI2.WinForms.Guna2TextBox txt_partid;
    }
}