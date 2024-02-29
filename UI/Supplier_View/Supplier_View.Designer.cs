
namespace A__Auto_Care
{
    partial class Supplier_View
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
            this.btn_search = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_supID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_supplier = new System.Windows.Forms.DataGridView();
            this.btn_back = new Guna.UI2.WinForms.Guna2Button();
            this.btn_clear = new Guna.UI2.WinForms.Guna2Button();
            this.btn_searchall = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_err_id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_supplier)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.AutoRoundedCorners = true;
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_search.BorderRadius = 21;
            this.btn_search.BorderThickness = 1;
            this.btn_search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_search.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_search.Location = new System.Drawing.Point(798, 140);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(149, 45);
            this.btn_search.TabIndex = 54;
            this.btn_search.Text = "Search";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label8.Location = new System.Drawing.Point(68, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 38);
            this.label8.TabIndex = 53;
            this.label8.Text = "View Supplier";
            // 
            // txt_supID
            // 
            this.txt_supID.AutoRoundedCorners = true;
            this.txt_supID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.txt_supID.BorderRadius = 21;
            this.txt_supID.BorderThickness = 2;
            this.txt_supID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_supID.DefaultText = "";
            this.txt_supID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_supID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_supID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_supID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_supID.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_supID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_supID.Font = new System.Drawing.Font("Verdana", 12F);
            this.txt_supID.ForeColor = System.Drawing.Color.Black;
            this.txt_supID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_supID.Location = new System.Drawing.Point(425, 140);
            this.txt_supID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_supID.Name = "txt_supID";
            this.txt_supID.PasswordChar = '\0';
            this.txt_supID.PlaceholderText = "";
            this.txt_supID.SelectedText = "";
            this.txt_supID.Size = new System.Drawing.Size(366, 45);
            this.txt_supID.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(280, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 51;
            this.label1.Text = "Supplier ID";
            // 
            // dataGridView_supplier
            // 
            this.dataGridView_supplier.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_supplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_supplier.Location = new System.Drawing.Point(33, 233);
            this.dataGridView_supplier.Name = "dataGridView_supplier";
            this.dataGridView_supplier.RowHeadersWidth = 51;
            this.dataGridView_supplier.RowTemplate.Height = 24;
            this.dataGridView_supplier.Size = new System.Drawing.Size(1147, 420);
            this.dataGridView_supplier.TabIndex = 55;
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
            this.btn_back.Location = new System.Drawing.Point(954, 703);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(110, 45);
            this.btn_back.TabIndex = 57;
            this.btn_back.Text = "Back";
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.AutoRoundedCorners = true;
            this.btn_clear.BackColor = System.Drawing.Color.Transparent;
            this.btn_clear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_clear.BorderRadius = 21;
            this.btn_clear.BorderThickness = 1;
            this.btn_clear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_clear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_clear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_clear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_clear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_clear.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_clear.Location = new System.Drawing.Point(1070, 703);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(110, 45);
            this.btn_clear.TabIndex = 56;
            this.btn_clear.Text = "Clear";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
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
            this.btn_searchall.Location = new System.Drawing.Point(953, 140);
            this.btn_searchall.Name = "btn_searchall";
            this.btn_searchall.Size = new System.Drawing.Size(149, 45);
            this.btn_searchall.TabIndex = 58;
            this.btn_searchall.Text = "Search All";
            this.btn_searchall.Click += new System.EventHandler(this.btn_searchall_Click);
            // 
            // lbl_err_id
            // 
            this.lbl_err_id.AutoSize = true;
            this.lbl_err_id.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_err_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_err_id.Location = new System.Drawing.Point(437, 189);
            this.lbl_err_id.Name = "lbl_err_id";
            this.lbl_err_id.Size = new System.Drawing.Size(0, 20);
            this.lbl_err_id.TabIndex = 59;
            // 
            // Supplier_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1215, 789);
            this.Controls.Add(this.lbl_err_id);
            this.Controls.Add(this.btn_searchall);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.dataGridView_supplier);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_supID);
            this.Controls.Add(this.label1);
            this.Name = "Supplier_View";
            this.Text = "Supplier View";
            this.Load += new System.EventHandler(this.Supplier_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_supplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_search;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txt_supID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_supplier;
        private Guna.UI2.WinForms.Guna2Button btn_back;
        private Guna.UI2.WinForms.Guna2Button btn_clear;
        private Guna.UI2.WinForms.Guna2Button btn_searchall;
        private System.Windows.Forms.Label lbl_err_id;
    }
}