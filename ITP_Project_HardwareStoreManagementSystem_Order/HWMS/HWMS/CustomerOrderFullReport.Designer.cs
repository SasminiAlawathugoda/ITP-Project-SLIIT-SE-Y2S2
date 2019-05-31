namespace HWMS
{
    partial class CustomerOrderFullReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerOrderFullReport));
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.HWMSNDataSet14 = new HWMS.HWMSNDataSet14();
            this.CustomerOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CustomerOrderTableAdapter = new HWMS.HWMSNDataSet14TableAdapters.CustomerOrderTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HWMSNDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerOrderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1123, 739);
            this.panel1.TabIndex = 0;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CustomerOrderBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HWMS.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(25, 80);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1077, 620);
            this.reportViewer1.TabIndex = 0;
            // 
            // HWMSNDataSet14
            // 
            this.HWMSNDataSet14.DataSetName = "HWMSNDataSet14";
            this.HWMSNDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CustomerOrderBindingSource
            // 
            this.CustomerOrderBindingSource.DataMember = "CustomerOrder";
            this.CustomerOrderBindingSource.DataSource = this.HWMSNDataSet14;
            // 
            // CustomerOrderTableAdapter
            // 
            this.CustomerOrderTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(73, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 46);
            this.button3.TabIndex = 39;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(18, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 46);
            this.button4.TabIndex = 41;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // CustomerOrderFullReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 738);
            this.Controls.Add(this.panel1);
            this.Name = "CustomerOrderFullReport";
            this.Text = "CustomerOrderFullReport";
            this.Load += new System.EventHandler(this.CustomerOrderFullReport_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HWMSNDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerOrderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CustomerOrderBindingSource;
        private HWMSNDataSet14 HWMSNDataSet14;
        private HWMSNDataSet14TableAdapters.CustomerOrderTableAdapter CustomerOrderTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}