
namespace A__Auto_Care
{
    partial class QRCode_Gen
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
            this.label8 = new System.Windows.Forms.Label();
            this.txt_genID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picbox_qr = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btn_send = new Guna.UI2.WinForms.Guna2Button();
            this.btn_back = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_err_id = new System.Windows.Forms.Label();
            this.lbl_err_pic = new System.Windows.Forms.Label();
            this.btn_generate = new System.Windows.Forms.Button();
            this.lbl_err_email = new System.Windows.Forms.Label();
            this.txt_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_qr)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label8.Location = new System.Drawing.Point(69, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(257, 38);
            this.label8.TabIndex = 17;
            this.label8.Text = "QR Code Generate";
            // 
            // txt_genID
            // 
            this.txt_genID.AutoRoundedCorners = true;
            this.txt_genID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.txt_genID.BorderRadius = 21;
            this.txt_genID.BorderThickness = 2;
            this.txt_genID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_genID.DefaultText = "";
            this.txt_genID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_genID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_genID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_genID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_genID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_genID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_genID.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_genID.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_genID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_genID.Location = new System.Drawing.Point(203, 137);
            this.txt_genID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_genID.Name = "txt_genID";
            this.txt_genID.PasswordChar = '\0';
            this.txt_genID.PlaceholderText = "";
            this.txt_genID.ReadOnly = true;
            this.txt_genID.SelectedText = "";
            this.txt_genID.Size = new System.Drawing.Size(386, 45);
            this.txt_genID.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Customer ID";
            // 
            // picbox_qr
            // 
            this.picbox_qr.ImageRotate = 0F;
            this.picbox_qr.Location = new System.Drawing.Point(386, 279);
            this.picbox_qr.Name = "picbox_qr";
            this.picbox_qr.Size = new System.Drawing.Size(418, 337);
            this.picbox_qr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox_qr.TabIndex = 21;
            this.picbox_qr.TabStop = false;
            // 
            // btn_send
            // 
            this.btn_send.AutoRoundedCorners = true;
            this.btn_send.BackColor = System.Drawing.Color.Transparent;
            this.btn_send.BorderRadius = 21;
            this.btn_send.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_send.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_send.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_send.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_send.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_send.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.ForeColor = System.Drawing.Color.White;
            this.btn_send.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_send.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_send.Location = new System.Drawing.Point(679, 645);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(180, 45);
            this.btn_send.TabIndex = 22;
            this.btn_send.Text = "Send";
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_back
            // 
            this.btn_back.AutoRoundedCorners = true;
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.BorderRadius = 30;
            this.btn_back.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_back.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_back.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_back.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_back.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_back.HoverState.ForeColor = System.Drawing.Color.Red;
            this.btn_back.Location = new System.Drawing.Point(1040, 703);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(119, 63);
            this.btn_back.TabIndex = 23;
            this.btn_back.Text = "Back to Home";
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_err_id
            // 
            this.lbl_err_id.AutoSize = true;
            this.lbl_err_id.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_err_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_err_id.Location = new System.Drawing.Point(212, 186);
            this.lbl_err_id.Name = "lbl_err_id";
            this.lbl_err_id.Size = new System.Drawing.Size(0, 20);
            this.lbl_err_id.TabIndex = 46;
            // 
            // lbl_err_pic
            // 
            this.lbl_err_pic.AutoSize = true;
            this.lbl_err_pic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_err_pic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_err_pic.Location = new System.Drawing.Point(382, 610);
            this.lbl_err_pic.Name = "lbl_err_pic";
            this.lbl_err_pic.Size = new System.Drawing.Size(0, 20);
            this.lbl_err_pic.TabIndex = 58;
            // 
            // btn_generate
            // 
            this.btn_generate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_generate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generate.ForeColor = System.Drawing.Color.White;
            this.btn_generate.Location = new System.Drawing.Point(661, 137);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(143, 45);
            this.btn_generate.TabIndex = 62;
            this.btn_generate.Text = "Generate";
            this.btn_generate.UseVisualStyleBackColor = false;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // lbl_err_email
            // 
            this.lbl_err_email.AutoSize = true;
            this.lbl_err_email.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_err_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_err_email.Location = new System.Drawing.Point(210, 253);
            this.lbl_err_email.Name = "lbl_err_email";
            this.lbl_err_email.Size = new System.Drawing.Size(0, 20);
            this.lbl_err_email.TabIndex = 65;
            this.lbl_err_email.Click += new System.EventHandler(this.lbl_err_email_Click);
            // 
            // txt_email
            // 
            this.txt_email.AutoRoundedCorners = true;
            this.txt_email.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.txt_email.BorderRadius = 23;
            this.txt_email.BorderThickness = 2;
            this.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_email.DefaultText = "";
            this.txt_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_email.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_email.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_email.Location = new System.Drawing.Point(203, 200);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.PlaceholderText = "";
            this.txt_email.ReadOnly = true;
            this.txt_email.SelectedText = "";
            this.txt_email.Size = new System.Drawing.Size(386, 49);
            this.txt_email.TabIndex = 64;
            this.txt_email.TextChanged += new System.EventHandler(this.txt_email_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(47, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 23);
            this.label7.TabIndex = 63;
            this.label7.Text = "Email Address";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // QRCode_Gen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1215, 789);
            this.Controls.Add(this.lbl_err_email);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.lbl_err_pic);
            this.Controls.Add(this.lbl_err_id);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.picbox_qr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_genID);
            this.Controls.Add(this.label8);
            this.Name = "QRCode_Gen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Code Generate";
            this.Load += new System.EventHandler(this.QRCode_Gen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_qr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txt_genID;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox picbox_qr;
        private Guna.UI2.WinForms.Guna2Button btn_send;
        private Guna.UI2.WinForms.Guna2Button btn_back;
        private System.Windows.Forms.Label lbl_err_id;
        private System.Windows.Forms.Label lbl_err_pic;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.Label lbl_err_email;
        private Guna.UI2.WinForms.Guna2TextBox txt_email;
        private System.Windows.Forms.Label label7;
    }
}