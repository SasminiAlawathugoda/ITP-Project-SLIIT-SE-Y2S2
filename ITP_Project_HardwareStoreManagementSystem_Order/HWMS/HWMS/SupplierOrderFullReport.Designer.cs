namespace HWMS
{
    partial class SupplierOrderFullReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierOrderFullReport));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.HWMSNDataSet16 = new HWMS.HWMSNDataSet16();
            this.SupplierOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SupplierOrderTableAdapter = new HWMS.HWMSNDataSet16TableAdapters.SupplierOrderTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HWMSNDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierOrderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1114, 738);
            this.panel1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(15, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 46);
            this.button4.TabIndex = 44;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(70, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 46);
            this.button3.TabIndex = 43;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SupplierOrderBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HWMS.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(15, 92);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1089, 632);
            this.reportViewer1.TabIndex = 45;
            // 
            // HWMSNDataSet16
            // 
            this.HWMSNDataSet16.DataSetName = "HWMSNDataSet16";
            this.HWMSNDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SupplierOrderBindingSource
            // 
            this.SupplierOrderBindingSource.DataMember = "SupplierOrder";
            this.SupplierOrderBindingSource.DataSource = this.HWMSNDataSet16;
            // 
            // SupplierOrderTableAdapter
            // 
            this.SupplierOrderTableAdapter.ClearBeforeFill = true;
            // 
            // SupplierOrderFullReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 738);
            this.Controls.Add(this.panel1);
            this.Name = "SupplierOrderFullReport";
            this.Text = "SupplierOrderFullReport";
            this.Load += new System.EventHandler(this.SupplierOrderFullReport_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HWMSNDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierOrderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SupplierOrderBindingSource;
        private HWMSNDataSet16 HWMSNDataSet16;
        private HWMSNDataSet16TableAdapters.SupplierOrderTableAdapter SupplierOrderTableAdapter;
    }
}