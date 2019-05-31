namespace HWMS
{
    partial class Form7
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
            this.billPanel = new System.Windows.Forms.Panel();
            this.BillPrintButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hWMSNDataSet8 = new HWMS.HWMSNDataSet8();
            this.billTempBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billTempTableAdapter = new HWMS.HWMSNDataSet8TableAdapters.billTempTableAdapter();
            this.billPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hWMSNDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billTempBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // billPanel
            // 
            this.billPanel.Controls.Add(this.BillPrintButton);
            this.billPanel.Controls.Add(this.textBox1);
            this.billPanel.Controls.Add(this.label14);
            this.billPanel.Controls.Add(this.label13);
            this.billPanel.Controls.Add(this.label12);
            this.billPanel.Controls.Add(this.label11);
            this.billPanel.Controls.Add(this.label10);
            this.billPanel.Controls.Add(this.label7);
            this.billPanel.Controls.Add(this.label6);
            this.billPanel.Controls.Add(this.label5);
            this.billPanel.Controls.Add(this.label4);
            this.billPanel.Controls.Add(this.label3);
            this.billPanel.Controls.Add(this.label2);
            this.billPanel.Controls.Add(this.label1);
            this.billPanel.Location = new System.Drawing.Point(9, 26);
            this.billPanel.Name = "billPanel";
            this.billPanel.Size = new System.Drawing.Size(775, 751);
            this.billPanel.TabIndex = 18;
            // 
            // BillPrintButton
            // 
            this.BillPrintButton.BackColor = System.Drawing.Color.Silver;
            this.BillPrintButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillPrintButton.Location = new System.Drawing.Point(343, 692);
            this.BillPrintButton.Name = "BillPrintButton";
            this.BillPrintButton.Size = new System.Drawing.Size(136, 49);
            this.BillPrintButton.TabIndex = 31;
            this.BillPrintButton.Text = "Print";
            this.BillPrintButton.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(466, 582);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 22);
            this.textBox1.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.Control;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(463, 648);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(90, 0, 90, 0);
            this.label14.Size = new System.Drawing.Size(182, 19);
            this.label14.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(148, 648);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 25);
            this.label13.TabIndex = 28;
            this.label13.Text = "Balance";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(148, 582);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 25);
            this.label12.TabIndex = 27;
            this.label12.Text = "Cash";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(463, 521);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(90, 0, 90, 0);
            this.label11.Size = new System.Drawing.Size(182, 19);
            this.label11.TabIndex = 26;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(148, 521);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 25);
            this.label10.TabIndex = 25;
            this.label10.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(463, 222);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(90, 0, 90, 0);
            this.label7.Size = new System.Drawing.Size(182, 19);
            this.label7.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(463, 158);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(90, 0, 90, 0);
            this.label6.Size = new System.Drawing.Size(182, 19);
            this.label6.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(463, 108);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(90, 0, 90, 0);
            this.label5.Size = new System.Drawing.Size(182, 19);
            this.label5.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(148, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Bill Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Bill Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Bill ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 38);
            this.label1.TabIndex = 17;
            this.label1.Text = "Bill";
            // 
            // hWMSNDataSet8
            // 
            this.hWMSNDataSet8.DataSetName = "HWMSNDataSet8";
            this.hWMSNDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billTempBindingSource
            // 
            this.billTempBindingSource.DataMember = "billTemp";
            this.billTempBindingSource.DataSource = this.hWMSNDataSet8;
            // 
            // billTempTableAdapter
            // 
            this.billTempTableAdapter.ClearBeforeFill = true;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(792, 803);
            this.Controls.Add(this.billPanel);
            this.Name = "Form7";
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.billPanel.ResumeLayout(false);
            this.billPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hWMSNDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billTempBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel billPanel;
        private System.Windows.Forms.Button BillPrintButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private HWMSNDataSet8 hWMSNDataSet8;
        private System.Windows.Forms.BindingSource billTempBindingSource;
        private HWMSNDataSet8TableAdapters.billTempTableAdapter billTempTableAdapter;
    }
}