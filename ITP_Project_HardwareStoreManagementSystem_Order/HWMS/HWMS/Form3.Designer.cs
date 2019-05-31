namespace HWMS
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.SupplierOrderUpdateButton = new System.Windows.Forms.Button();
            this.SupplierOrderDeleteButton = new System.Windows.Forms.Button();
            this.SupplierOrderAddButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.SupplierOrderPayButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SupplierOrderSearchOrdersButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hWMSNDataSet6 = new HWMS.HWMSNDataSet6();
            this.supplierOrderTableAdapter = new HWMS.HWMSNDataSet6TableAdapters.SupplierOrderTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.supplierOrderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hWMSNDataSet7 = new HWMS.HWMSNDataSet7();
            this.supplierOrderTableAdapter1 = new HWMS.HWMSNDataSet7TableAdapters.SupplierOrderTableAdapter();
            this.SupplierOrderViewSupplierOrdersButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SupplierOrderSupplierOrderReportsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hWMSNDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierOrderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hWMSNDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier Order";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(83, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Item ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(83, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Quantity";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(83, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Supplier ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(83, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Supplier Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(83, 420);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 25);
            this.label10.TabIndex = 9;
            this.label10.Text = "Contact No.";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(287, 134);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(199, 22);
            this.textBox3.TabIndex = 14;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(287, 203);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(94, 22);
            this.textBox4.TabIndex = 15;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(287, 274);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(199, 22);
            this.textBox5.TabIndex = 16;
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(287, 350);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(199, 22);
            this.textBox6.TabIndex = 17;
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(287, 423);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(199, 22);
            this.textBox7.TabIndex = 18;
            this.textBox7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_KeyPress);
            // 
            // SupplierOrderUpdateButton
            // 
            this.SupplierOrderUpdateButton.BackColor = System.Drawing.Color.Silver;
            this.SupplierOrderUpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierOrderUpdateButton.Location = new System.Drawing.Point(651, 458);
            this.SupplierOrderUpdateButton.Name = "SupplierOrderUpdateButton";
            this.SupplierOrderUpdateButton.Size = new System.Drawing.Size(134, 44);
            this.SupplierOrderUpdateButton.TabIndex = 19;
            this.SupplierOrderUpdateButton.Text = "Update";
            this.SupplierOrderUpdateButton.UseVisualStyleBackColor = false;
            this.SupplierOrderUpdateButton.Click += new System.EventHandler(this.SupplierOrderUpdateButton_Click);
            // 
            // SupplierOrderDeleteButton
            // 
            this.SupplierOrderDeleteButton.BackColor = System.Drawing.Color.Silver;
            this.SupplierOrderDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierOrderDeleteButton.Location = new System.Drawing.Point(806, 458);
            this.SupplierOrderDeleteButton.Name = "SupplierOrderDeleteButton";
            this.SupplierOrderDeleteButton.Size = new System.Drawing.Size(126, 44);
            this.SupplierOrderDeleteButton.TabIndex = 20;
            this.SupplierOrderDeleteButton.Text = "Delete";
            this.SupplierOrderDeleteButton.UseVisualStyleBackColor = false;
            this.SupplierOrderDeleteButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // SupplierOrderAddButton
            // 
            this.SupplierOrderAddButton.BackColor = System.Drawing.Color.Silver;
            this.SupplierOrderAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierOrderAddButton.Location = new System.Drawing.Point(139, 597);
            this.SupplierOrderAddButton.Name = "SupplierOrderAddButton";
            this.SupplierOrderAddButton.Size = new System.Drawing.Size(130, 41);
            this.SupplierOrderAddButton.TabIndex = 21;
            this.SupplierOrderAddButton.Text = "Add";
            this.SupplierOrderAddButton.UseVisualStyleBackColor = false;
            this.SupplierOrderAddButton.Click += new System.EventHandler(this.SupplierOrderAddButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cube",
            "Meters",
            "kilograms",
            "grams",
            "liters",
            "Units"});
            this.comboBox1.Location = new System.Drawing.Point(409, 203);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(77, 24);
            this.comboBox1.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 509);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Weight";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(287, 509);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(199, 22);
            this.textBox8.TabIndex = 24;
            this.textBox8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox8_KeyPress);
            // 
            // SupplierOrderPayButton
            // 
            this.SupplierOrderPayButton.BackColor = System.Drawing.Color.Silver;
            this.SupplierOrderPayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierOrderPayButton.Location = new System.Drawing.Point(307, 597);
            this.SupplierOrderPayButton.Name = "SupplierOrderPayButton";
            this.SupplierOrderPayButton.Size = new System.Drawing.Size(130, 41);
            this.SupplierOrderPayButton.TabIndex = 25;
            this.SupplierOrderPayButton.Text = "Pay";
            this.SupplierOrderPayButton.UseVisualStyleBackColor = false;
            this.SupplierOrderPayButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(586, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(331, 22);
            this.textBox1.TabIndex = 30;
            // 
            // SupplierOrderSearchOrdersButton
            // 
            this.SupplierOrderSearchOrdersButton.BackColor = System.Drawing.Color.Silver;
            this.SupplierOrderSearchOrdersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierOrderSearchOrdersButton.Location = new System.Drawing.Point(935, 43);
            this.SupplierOrderSearchOrdersButton.Name = "SupplierOrderSearchOrdersButton";
            this.SupplierOrderSearchOrdersButton.Size = new System.Drawing.Size(144, 40);
            this.SupplierOrderSearchOrdersButton.TabIndex = 31;
            this.SupplierOrderSearchOrdersButton.Text = "Search Orders";
            this.SupplierOrderSearchOrdersButton.UseVisualStyleBackColor = false;
            this.SupplierOrderSearchOrdersButton.Click += new System.EventHandler(this.SearchOrdersButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.dateOfOrderDataGridViewTextBoxColumn,
            this.itemIDDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.supplierNameDataGridViewTextBoxColumn,
            this.contactNoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.supplierOrderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(547, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(549, 220);
            this.dataGridView1.TabIndex = 32;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "orderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "orderID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            // 
            // dateOfOrderDataGridViewTextBoxColumn
            // 
            this.dateOfOrderDataGridViewTextBoxColumn.DataPropertyName = "dateOfOrder";
            this.dateOfOrderDataGridViewTextBoxColumn.HeaderText = "dateOfOrder";
            this.dateOfOrderDataGridViewTextBoxColumn.Name = "dateOfOrderDataGridViewTextBoxColumn";
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            this.itemIDDataGridViewTextBoxColumn.DataPropertyName = "itemID";
            this.itemIDDataGridViewTextBoxColumn.HeaderText = "itemID";
            this.itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // supplierNameDataGridViewTextBoxColumn
            // 
            this.supplierNameDataGridViewTextBoxColumn.DataPropertyName = "supplierName";
            this.supplierNameDataGridViewTextBoxColumn.HeaderText = "supplierName";
            this.supplierNameDataGridViewTextBoxColumn.Name = "supplierNameDataGridViewTextBoxColumn";
            // 
            // contactNoDataGridViewTextBoxColumn
            // 
            this.contactNoDataGridViewTextBoxColumn.DataPropertyName = "contactNo";
            this.contactNoDataGridViewTextBoxColumn.HeaderText = "contactNo";
            this.contactNoDataGridViewTextBoxColumn.Name = "contactNoDataGridViewTextBoxColumn";
            // 
            // supplierOrderBindingSource
            // 
            this.supplierOrderBindingSource.DataMember = "SupplierOrder";
            this.supplierOrderBindingSource.DataSource = this.hWMSNDataSet6;
            // 
            // hWMSNDataSet6
            // 
            this.hWMSNDataSet6.DataSetName = "HWMSNDataSet6";
            this.hWMSNDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplierOrderTableAdapter
            // 
            this.supplierOrderTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.supplierOrderBindingSource1;
            this.comboBox2.DisplayMember = "orderID";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(651, 409);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(281, 24);
            this.comboBox2.TabIndex = 33;
            // 
            // supplierOrderBindingSource1
            // 
            this.supplierOrderBindingSource1.DataMember = "SupplierOrder";
            this.supplierOrderBindingSource1.DataSource = this.hWMSNDataSet7;
            // 
            // hWMSNDataSet7
            // 
            this.hWMSNDataSet7.DataSetName = "HWMSNDataSet7";
            this.hWMSNDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplierOrderTableAdapter1
            // 
            this.supplierOrderTableAdapter1.ClearBeforeFill = true;
            // 
            // SupplierOrderViewSupplierOrdersButton
            // 
            this.SupplierOrderViewSupplierOrdersButton.BackColor = System.Drawing.Color.Silver;
            this.SupplierOrderViewSupplierOrdersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierOrderViewSupplierOrdersButton.Location = new System.Drawing.Point(578, 521);
            this.SupplierOrderViewSupplierOrdersButton.Name = "SupplierOrderViewSupplierOrdersButton";
            this.SupplierOrderViewSupplierOrdersButton.Size = new System.Drawing.Size(207, 73);
            this.SupplierOrderViewSupplierOrdersButton.TabIndex = 34;
            this.SupplierOrderViewSupplierOrdersButton.Text = "View Supplier Orders";
            this.SupplierOrderViewSupplierOrdersButton.UseVisualStyleBackColor = false;
            this.SupplierOrderViewSupplierOrdersButton.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(76, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 46);
            this.button3.TabIndex = 35;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(21, 29);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 46);
            this.button4.TabIndex = 36;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // SupplierOrderSupplierOrderReportsButton
            // 
            this.SupplierOrderSupplierOrderReportsButton.BackColor = System.Drawing.Color.Silver;
            this.SupplierOrderSupplierOrderReportsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierOrderSupplierOrderReportsButton.Location = new System.Drawing.Point(806, 521);
            this.SupplierOrderSupplierOrderReportsButton.Name = "SupplierOrderSupplierOrderReportsButton";
            this.SupplierOrderSupplierOrderReportsButton.Size = new System.Drawing.Size(207, 73);
            this.SupplierOrderSupplierOrderReportsButton.TabIndex = 37;
            this.SupplierOrderSupplierOrderReportsButton.Text = "Supplier Order Reports";
            this.SupplierOrderSupplierOrderReportsButton.UseVisualStyleBackColor = false;
            this.SupplierOrderSupplierOrderReportsButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1158, 784);
            this.Controls.Add(this.SupplierOrderSupplierOrderReportsButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.SupplierOrderViewSupplierOrdersButton);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SupplierOrderSearchOrdersButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SupplierOrderPayButton);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.SupplierOrderAddButton);
            this.Controls.Add(this.SupplierOrderDeleteButton);
            this.Controls.Add(this.SupplierOrderUpdateButton);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Supplier Order";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hWMSNDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierOrderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hWMSNDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button SupplierOrderUpdateButton;
        private System.Windows.Forms.Button SupplierOrderDeleteButton;
        private System.Windows.Forms.Button SupplierOrderAddButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button SupplierOrderPayButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SupplierOrderSearchOrdersButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HWMSNDataSet6 hWMSNDataSet6;
        private System.Windows.Forms.BindingSource supplierOrderBindingSource;
        private HWMSNDataSet6TableAdapters.SupplierOrderTableAdapter supplierOrderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox2;
        private HWMSNDataSet7 hWMSNDataSet7;
        private System.Windows.Forms.BindingSource supplierOrderBindingSource1;
        private HWMSNDataSet7TableAdapters.SupplierOrderTableAdapter supplierOrderTableAdapter1;
        private System.Windows.Forms.Button SupplierOrderViewSupplierOrdersButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button SupplierOrderSupplierOrderReportsButton;
    }
}