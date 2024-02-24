
namespace A__Auto_Care
{
    partial class Login_QR
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
            this.components = new System.ComponentModel.Container();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_back = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Login = new Guna.UI2.WinForms.Guna2Button();
            this.picbox_qrscan = new System.Windows.Forms.PictureBox();
            this.lbl_err_id = new System.Windows.Forms.Label();
            this.txt_cusID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RadioButton_QR = new Guna.UI2.WinForms.Guna2RadioButton();
            this.RadioButton_ID = new Guna.UI2.WinForms.Guna2RadioButton();
            this.cboDevice = new Guna.UI2.WinForms.Guna2ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_qrscan)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label8.Location = new System.Drawing.Point(69, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(224, 38);
            this.label8.TabIndex = 34;
            this.label8.Text = "Login Customer";
            // 
            // btn_back
            // 
            this.btn_back.AutoRoundedCorners = true;
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.BorderRadius = 21;
            this.btn_back.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_back.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_back.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_back.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_back.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_back.HoverState.ForeColor = System.Drawing.Color.Red;
            this.btn_back.Location = new System.Drawing.Point(863, 665);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(110, 45);
            this.btn_back.TabIndex = 40;
            this.btn_back.Text = "Back";
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.AutoRoundedCorners = true;
            this.btn_Login.BackColor = System.Drawing.Color.Transparent;
            this.btn_Login.BorderRadius = 21;
            this.btn_Login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_Login.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_Login.Location = new System.Drawing.Point(979, 665);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(180, 45);
            this.btn_Login.TabIndex = 41;
            this.btn_Login.Text = "Login";
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // picbox_qrscan
            // 
            this.picbox_qrscan.BackColor = System.Drawing.Color.White;
            this.picbox_qrscan.Location = new System.Drawing.Point(426, 138);
            this.picbox_qrscan.Name = "picbox_qrscan";
            this.picbox_qrscan.Size = new System.Drawing.Size(310, 271);
            this.picbox_qrscan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox_qrscan.TabIndex = 42;
            this.picbox_qrscan.TabStop = false;
            // 
            // lbl_err_id
            // 
            this.lbl_err_id.AutoSize = true;
            this.lbl_err_id.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_err_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_err_id.Location = new System.Drawing.Point(396, 580);
            this.lbl_err_id.Name = "lbl_err_id";
            this.lbl_err_id.Size = new System.Drawing.Size(0, 20);
            this.lbl_err_id.TabIndex = 45;
            // 
            // txt_cusID
            // 
            this.txt_cusID.AutoRoundedCorners = true;
            this.txt_cusID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.txt_cusID.BorderRadius = 23;
            this.txt_cusID.BorderThickness = 2;
            this.txt_cusID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_cusID.DefaultText = "";
            this.txt_cusID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_cusID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_cusID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_cusID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_cusID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_cusID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_cusID.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cusID.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_cusID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_cusID.Location = new System.Drawing.Point(387, 516);
            this.txt_cusID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cusID.Name = "txt_cusID";
            this.txt_cusID.PasswordChar = '\0';
            this.txt_cusID.PlaceholderText = "";
            this.txt_cusID.SelectedText = "";
            this.txt_cusID.Size = new System.Drawing.Size(385, 49);
            this.txt_cusID.TabIndex = 44;
            this.txt_cusID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cusID_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(250, 530);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 23);
            this.label1.TabIndex = 43;
            this.label1.Text = "Customer ID";
            // 
            // RadioButton_QR
            // 
            this.RadioButton_QR.AutoSize = true;
            this.RadioButton_QR.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RadioButton_QR.CheckedState.BorderThickness = 0;
            this.RadioButton_QR.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RadioButton_QR.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RadioButton_QR.CheckedState.InnerOffset = -4;
            this.RadioButton_QR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButton_QR.ForeColor = System.Drawing.Color.White;
            this.RadioButton_QR.Location = new System.Drawing.Point(61, 138);
            this.RadioButton_QR.Name = "RadioButton_QR";
            this.RadioButton_QR.Size = new System.Drawing.Size(171, 32);
            this.RadioButton_QR.TabIndex = 46;
            this.RadioButton_QR.Text = "Login With QR";
            this.RadioButton_QR.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RadioButton_QR.UncheckedState.BorderThickness = 2;
            this.RadioButton_QR.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RadioButton_QR.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RadioButton_QR.CheckedChanged += new System.EventHandler(this.RadioButton_QR_CheckedChanged);
            // 
            // RadioButton_ID
            // 
            this.RadioButton_ID.AutoSize = true;
            this.RadioButton_ID.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RadioButton_ID.CheckedState.BorderThickness = 0;
            this.RadioButton_ID.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RadioButton_ID.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RadioButton_ID.CheckedState.InnerOffset = -4;
            this.RadioButton_ID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButton_ID.ForeColor = System.Drawing.Color.White;
            this.RadioButton_ID.Location = new System.Drawing.Point(61, 431);
            this.RadioButton_ID.Name = "RadioButton_ID";
            this.RadioButton_ID.Size = new System.Drawing.Size(260, 32);
            this.RadioButton_ID.TabIndex = 47;
            this.RadioButton_ID.Text = "Login With Customer ID";
            this.RadioButton_ID.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RadioButton_ID.UncheckedState.BorderThickness = 2;
            this.RadioButton_ID.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RadioButton_ID.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RadioButton_ID.CheckedChanged += new System.EventHandler(this.RadioButton_ID_CheckedChanged);
            // 
            // cboDevice
            // 
            this.cboDevice.BackColor = System.Drawing.Color.Transparent;
            this.cboDevice.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDevice.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboDevice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboDevice.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDevice.ForeColor = System.Drawing.Color.Black;
            this.cboDevice.ItemHeight = 30;
            this.cboDevice.Location = new System.Drawing.Point(426, 82);
            this.cboDevice.Name = "cboDevice";
            this.cboDevice.Size = new System.Drawing.Size(310, 36);
            this.cboDevice.TabIndex = 48;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Login_QR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1216, 751);
            this.Controls.Add(this.cboDevice);
            this.Controls.Add(this.RadioButton_ID);
            this.Controls.Add(this.RadioButton_QR);
            this.Controls.Add(this.lbl_err_id);
            this.Controls.Add(this.txt_cusID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picbox_qrscan);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label8);
            this.Name = "Login_QR";
            this.Text = "Login_QR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_QR_FormClosing);
            this.Load += new System.EventHandler(this.Login_QR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_qrscan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button btn_back;
        private Guna.UI2.WinForms.Guna2Button btn_Login;
        private System.Windows.Forms.PictureBox picbox_qrscan;
        private System.Windows.Forms.Label lbl_err_id;
        private Guna.UI2.WinForms.Guna2TextBox txt_cusID;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2RadioButton RadioButton_QR;
        private Guna.UI2.WinForms.Guna2RadioButton RadioButton_ID;
        private Guna.UI2.WinForms.Guna2ComboBox cboDevice;
        private System.Windows.Forms.Timer timer1;
    }
}