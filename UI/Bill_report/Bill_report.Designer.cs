
namespace A__Auto_Care
{
    partial class Bill_report
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.label8 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_back = new Guna.UI2.WinForms.Guna2Button();
            this.BillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet_Report = new A__Auto_Care.DataSet_Report();
            this.BillTableAdapter = new A__Auto_Care.DataSet_ReportTableAdapters.BillTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BillBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Report)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label8.Location = new System.Drawing.Point(69, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 38);
            this.label8.TabIndex = 18;
            this.label8.Text = "Bill Report";
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.BillBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "A__Auto_Care.Report_bill.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(97, 193);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1035, 457);
            this.reportViewer1.TabIndex = 19;
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
            this.btn_back.Location = new System.Drawing.Point(1022, 713);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(110, 45);
            this.btn_back.TabIndex = 30;
            this.btn_back.Text = "Back";
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // BillBindingSource
            // 
            this.BillBindingSource.DataMember = "Bill";
            this.BillBindingSource.DataSource = this.DataSet_Report;
            // 
            // DataSet_Report
            // 
            this.DataSet_Report.DataSetName = "DataSet_Report";
            this.DataSet_Report.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BillTableAdapter
            // 
            this.BillTableAdapter.ClearBeforeFill = true;
            // 
            // Bill_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1215, 789);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label8);
            this.Name = "Bill_report";
            this.Text = "Bill_report";
            this.Load += new System.EventHandler(this.Bill_report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BillBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Report)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Guna.UI2.WinForms.Guna2Button btn_back;
        private System.Windows.Forms.BindingSource BillBindingSource;
        private DataSet_Report DataSet_Report;
        private DataSet_ReportTableAdapters.BillTableAdapter BillTableAdapter;
    }
}