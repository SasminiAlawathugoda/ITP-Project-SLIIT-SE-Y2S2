namespace HWMS
{
    partial class UpdateCustomerOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateCustomerOrder));
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.CustomerOrderUpdateButton = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.customerOrderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hWMSNDataSet12 = new HWMS.HWMSNDataSet12();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDestinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hWMSNDataSet10 = new HWMS.HWMSNDataSet10();
            this.customerOrderTableAdapter = new HWMS.HWMSNDataSet10TableAdapters.CustomerOrderTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.customerOrderTableAdapter1 = new HWMS.HWMSNDataSet12TableAdapters.CustomerOrderTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hWMSNDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hWMSNDataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Status";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(102, 351);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 25);
            this.label11.TabIndex = 31;
            this.label11.Text = "Contact No.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(102, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 25);
            this.label10.TabIndex = 30;
            this.label10.Text = "Customer Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(102, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 25);
            this.label8.TabIndex = 28;
            this.label8.Text = "Order Destination";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(102, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "Order ID";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 38);
            this.label1.TabIndex = 33;
            this.label1.Text = "Update Customer Order";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(335, 347);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(198, 22);
            this.textBox8.TabIndex = 39;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(334, 279);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(198, 22);
            this.textBox7.TabIndex = 38;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(335, 209);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(198, 22);
            this.textBox5.TabIndex = 36;
            // 
            // CustomerOrderUpdateButton
            // 
            this.CustomerOrderUpdateButton.BackColor = System.Drawing.Color.Silver;
            this.CustomerOrderUpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerOrderUpdateButton.Location = new System.Drawing.Point(251, 602);
            this.CustomerOrderUpdateButton.Name = "CustomerOrderUpdateButton";
            this.CustomerOrderUpdateButton.Size = new System.Drawing.Size(126, 49);
            this.CustomerOrderUpdateButton.TabIndex = 42;
            this.CustomerOrderUpdateButton.Text = "Update";
            this.CustomerOrderUpdateButton.UseVisualStyleBackColor = false;
            this.CustomerOrderUpdateButton.Click += new System.EventHandler(this.CustomerOrderUpdateButton_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.customerOrderBindingSource1;
            this.comboBox2.DisplayMember = "orderID";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(335, 144);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(197, 24);
            this.comboBox2.TabIndex = 43;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // customerOrderBindingSource1
            // 
            this.customerOrderBindingSource1.DataMember = "CustomerOrder";
            this.customerOrderBindingSource1.DataSource = this.hWMSNDataSet12;
            // 
            // hWMSNDataSet12
            // 
            this.hWMSNDataSet12.DataSetName = "HWMSNDataSet12";
            this.hWMSNDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.dateOfOrderDataGridViewTextBoxColumn,
            this.orderDestinationDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.contactNoDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerOrderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(611, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(651, 222);
            this.dataGridView1.TabIndex = 44;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "orderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "Order ID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            // 
            // dateOfOrderDataGridViewTextBoxColumn
            // 
            this.dateOfOrderDataGridViewTextBoxColumn.DataPropertyName = "dateOfOrder";
            this.dateOfOrderDataGridViewTextBoxColumn.HeaderText = "Date Of Order";
            this.dateOfOrderDataGridViewTextBoxColumn.Name = "dateOfOrderDataGridViewTextBoxColumn";
            // 
            // orderDestinationDataGridViewTextBoxColumn
            // 
            this.orderDestinationDataGridViewTextBoxColumn.DataPropertyName = "orderDestination";
            this.orderDestinationDataGridViewTextBoxColumn.HeaderText = "Order Destination";
            this.orderDestinationDataGridViewTextBoxColumn.Name = "orderDestinationDataGridViewTextBoxColumn";
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "customerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "Customer Name";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            // 
            // contactNoDataGridViewTextBoxColumn
            // 
            this.contactNoDataGridViewTextBoxColumn.DataPropertyName = "contactNo";
            this.contactNoDataGridViewTextBoxColumn.HeaderText = "Contact No";
            this.contactNoDataGridViewTextBoxColumn.Name = "contactNoDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // customerOrderBindingSource
            // 
            this.customerOrderBindingSource.DataMember = "CustomerOrder";
            this.customerOrderBindingSource.DataSource = this.hWMSNDataSet10;
            // 
            // hWMSNDataSet10
            // 
            this.hWMSNDataSet10.DataSetName = "HWMSNDataSet10";
            this.hWMSNDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerOrderTableAdapter
            // 
            this.customerOrderTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Incomplete",
            "Complete"});
            this.comboBox1.Location = new System.Drawing.Point(334, 418);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 24);
            this.comboBox1.TabIndex = 45;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // customerOrderTableAdapter1
            // 
            this.customerOrderTableAdapter1.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(12, 25);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 46);
            this.button4.TabIndex = 47;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(67, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 46);
            this.button3.TabIndex = 46;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // UpdateCustomerOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 726);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.CustomerOrderUpdateButton);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Name = "UpdateCustomerOrder";
            this.Text = "UpdateCustomerOrder";
            this.Load += new System.EventHandler(this.UpdateCustomerOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hWMSNDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hWMSNDataSet10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button CustomerOrderUpdateButton;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HWMSNDataSet10 hWMSNDataSet10;
        private System.Windows.Forms.BindingSource customerOrderBindingSource;
        private HWMSNDataSet10TableAdapters.CustomerOrderTableAdapter customerOrderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDestinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
        private HWMSNDataSet12 hWMSNDataSet12;
        private System.Windows.Forms.BindingSource customerOrderBindingSource1;
        private HWMSNDataSet12TableAdapters.CustomerOrderTableAdapter customerOrderTableAdapter1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}