namespace HWMS
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CustomerOrderUpdateButton = new System.Windows.Forms.Button();
            this.CustomerOrderDeleteButton = new System.Windows.Forms.Button();
            this.CustomerOrderAddButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.customerOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hWMSNDataSet = new HWMS.HWMSNDataSet();
            this.customerOrderTableAdapter = new HWMS.HWMSNDataSetTableAdapters.CustomerOrderTableAdapter();
            this.CustomerOrderPayButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CustomerOrderSearchOrdersButton = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.customerOrderBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.customerOrderIDS = new HWMS.CustomerOrderIDS();
            this.hWMSNDataSet1 = new HWMS.HWMSNDataSet1();
            this.customerOrderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerOrderTableAdapter1 = new HWMS.HWMSNDataSet1TableAdapters.CustomerOrderTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDestinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerOrderBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.hWMSNDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hWMSNDataSet3 = new HWMS.HWMSNDataSet3();
            this.customerOrderBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.customerOrderTableAdapter2 = new HWMS.HWMSNDataSet3TableAdapters.CustomerOrderTableAdapter();
            this.customerOrderTableAdapter3 = new HWMS.CustomerOrderIDSTableAdapters.CustomerOrderTableAdapter();
            this.CustomerOrderViewCustomerOrdersButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.CustomerOrderCustomerOrderReportsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hWMSNDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderIDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hWMSNDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hWMSNDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hWMSNDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Order";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(114, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Item ID";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(114, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(114, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Order Destination";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(114, 348);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Customer ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(114, 424);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 25);
            this.label10.TabIndex = 9;
            this.label10.Text = "Customer Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(114, 492);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 25);
            this.label11.TabIndex = 10;
            this.label11.Text = "Contact No.";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(347, 152);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(199, 22);
            this.textBox3.TabIndex = 15;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(347, 223);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(85, 22);
            this.textBox4.TabIndex = 16;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(348, 284);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(198, 22);
            this.textBox5.TabIndex = 17;
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(348, 352);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(198, 22);
            this.textBox6.TabIndex = 18;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(347, 424);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(198, 22);
            this.textBox7.TabIndex = 19;
            this.textBox7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_KeyPress);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(348, 492);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(198, 22);
            this.textBox8.TabIndex = 20;
            this.textBox8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox8_KeyPress);
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
            this.comboBox1.Location = new System.Drawing.Point(455, 223);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(91, 24);
            this.comboBox1.TabIndex = 21;
            // 
            // CustomerOrderUpdateButton
            // 
            this.CustomerOrderUpdateButton.BackColor = System.Drawing.Color.Silver;
            this.CustomerOrderUpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerOrderUpdateButton.Location = new System.Drawing.Point(762, 509);
            this.CustomerOrderUpdateButton.Name = "CustomerOrderUpdateButton";
            this.CustomerOrderUpdateButton.Size = new System.Drawing.Size(126, 49);
            this.CustomerOrderUpdateButton.TabIndex = 22;
            this.CustomerOrderUpdateButton.Text = "Update";
            this.CustomerOrderUpdateButton.UseVisualStyleBackColor = false;
            this.CustomerOrderUpdateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomerOrderDeleteButton
            // 
            this.CustomerOrderDeleteButton.BackColor = System.Drawing.Color.Silver;
            this.CustomerOrderDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerOrderDeleteButton.Location = new System.Drawing.Point(928, 509);
            this.CustomerOrderDeleteButton.Name = "CustomerOrderDeleteButton";
            this.CustomerOrderDeleteButton.Size = new System.Drawing.Size(126, 49);
            this.CustomerOrderDeleteButton.TabIndex = 23;
            this.CustomerOrderDeleteButton.Text = "Delete";
            this.CustomerOrderDeleteButton.UseVisualStyleBackColor = false;
            this.CustomerOrderDeleteButton.Click += new System.EventHandler(this.CustomerOrderDeleteButton_Click);
            // 
            // CustomerOrderAddButton
            // 
            this.CustomerOrderAddButton.BackColor = System.Drawing.Color.Silver;
            this.CustomerOrderAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerOrderAddButton.Location = new System.Drawing.Point(250, 655);
            this.CustomerOrderAddButton.Name = "CustomerOrderAddButton";
            this.CustomerOrderAddButton.Size = new System.Drawing.Size(135, 49);
            this.CustomerOrderAddButton.TabIndex = 24;
            this.CustomerOrderAddButton.Text = "Add";
            this.CustomerOrderAddButton.UseVisualStyleBackColor = false;
            this.CustomerOrderAddButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 565);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Weight";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(347, 565);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(198, 22);
            this.textBox9.TabIndex = 26;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            this.textBox9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox9_KeyPress);
            // 
            // customerOrderBindingSource
            // 
            this.customerOrderBindingSource.DataMember = "CustomerOrder";
            this.customerOrderBindingSource.DataSource = this.hWMSNDataSet;
            // 
            // hWMSNDataSet
            // 
            this.hWMSNDataSet.DataSetName = "HWMSNDataSet";
            this.hWMSNDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerOrderTableAdapter
            // 
            this.customerOrderTableAdapter.ClearBeforeFill = true;
            // 
            // CustomerOrderPayButton
            // 
            this.CustomerOrderPayButton.BackColor = System.Drawing.Color.Silver;
            this.CustomerOrderPayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerOrderPayButton.Location = new System.Drawing.Point(420, 655);
            this.CustomerOrderPayButton.Name = "CustomerOrderPayButton";
            this.CustomerOrderPayButton.Size = new System.Drawing.Size(126, 49);
            this.CustomerOrderPayButton.TabIndex = 28;
            this.CustomerOrderPayButton.Text = "Pay";
            this.CustomerOrderPayButton.UseVisualStyleBackColor = false;
            this.CustomerOrderPayButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(643, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(331, 22);
            this.textBox1.TabIndex = 29;
            // 
            // CustomerOrderSearchOrdersButton
            // 
            this.CustomerOrderSearchOrdersButton.BackColor = System.Drawing.Color.Silver;
            this.CustomerOrderSearchOrdersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerOrderSearchOrdersButton.Location = new System.Drawing.Point(993, 43);
            this.CustomerOrderSearchOrdersButton.Name = "CustomerOrderSearchOrdersButton";
            this.CustomerOrderSearchOrdersButton.Size = new System.Drawing.Size(144, 40);
            this.CustomerOrderSearchOrdersButton.TabIndex = 30;
            this.CustomerOrderSearchOrdersButton.Text = "Search Orders";
            this.CustomerOrderSearchOrdersButton.UseVisualStyleBackColor = false;
            this.CustomerOrderSearchOrdersButton.Click += new System.EventHandler(this.SearchOrdersButton_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.customerOrderBindingSource4;
            this.comboBox2.DisplayMember = "orderID";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(762, 450);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(281, 24);
            this.comboBox2.TabIndex = 31;
            // 
            // customerOrderBindingSource4
            // 
            this.customerOrderBindingSource4.DataMember = "CustomerOrder";
            this.customerOrderBindingSource4.DataSource = this.customerOrderIDS;
            // 
            // customerOrderIDS
            // 
            this.customerOrderIDS.DataSetName = "CustomerOrderIDS";
            this.customerOrderIDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hWMSNDataSet1
            // 
            this.hWMSNDataSet1.DataSetName = "HWMSNDataSet1";
            this.hWMSNDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerOrderBindingSource1
            // 
            this.customerOrderBindingSource1.DataMember = "CustomerOrder";
            this.customerOrderBindingSource1.DataSource = this.hWMSNDataSet1;
            // 
            // customerOrderTableAdapter1
            // 
            this.customerOrderTableAdapter1.ClearBeforeFill = true;
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
            this.orderDestinationDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.contactNoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerOrderBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(619, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(548, 248);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // orderDestinationDataGridViewTextBoxColumn
            // 
            this.orderDestinationDataGridViewTextBoxColumn.DataPropertyName = "orderDestination";
            this.orderDestinationDataGridViewTextBoxColumn.HeaderText = "orderDestination";
            this.orderDestinationDataGridViewTextBoxColumn.Name = "orderDestinationDataGridViewTextBoxColumn";
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "customerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "customerName";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            // 
            // contactNoDataGridViewTextBoxColumn
            // 
            this.contactNoDataGridViewTextBoxColumn.DataPropertyName = "contactNo";
            this.contactNoDataGridViewTextBoxColumn.HeaderText = "contactNo";
            this.contactNoDataGridViewTextBoxColumn.Name = "contactNoDataGridViewTextBoxColumn";
            // 
            // customerOrderBindingSource3
            // 
            this.customerOrderBindingSource3.DataMember = "CustomerOrder";
            this.customerOrderBindingSource3.DataSource = this.hWMSNDataSet3BindingSource;
            // 
            // hWMSNDataSet3BindingSource
            // 
            this.hWMSNDataSet3BindingSource.DataSource = this.hWMSNDataSet3;
            this.hWMSNDataSet3BindingSource.Position = 0;
            // 
            // hWMSNDataSet3
            // 
            this.hWMSNDataSet3.DataSetName = "HWMSNDataSet3";
            this.hWMSNDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerOrderBindingSource2
            // 
            this.customerOrderBindingSource2.DataMember = "CustomerOrder";
            this.customerOrderBindingSource2.DataSource = this.hWMSNDataSet3;
            // 
            // customerOrderTableAdapter2
            // 
            this.customerOrderTableAdapter2.ClearBeforeFill = true;
            // 
            // customerOrderTableAdapter3
            // 
            this.customerOrderTableAdapter3.ClearBeforeFill = true;
            // 
            // CustomerOrderViewCustomerOrdersButton
            // 
            this.CustomerOrderViewCustomerOrdersButton.BackColor = System.Drawing.Color.Silver;
            this.CustomerOrderViewCustomerOrdersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerOrderViewCustomerOrdersButton.Location = new System.Drawing.Point(690, 581);
            this.CustomerOrderViewCustomerOrdersButton.Name = "CustomerOrderViewCustomerOrdersButton";
            this.CustomerOrderViewCustomerOrdersButton.Size = new System.Drawing.Size(207, 73);
            this.CustomerOrderViewCustomerOrdersButton.TabIndex = 32;
            this.CustomerOrderViewCustomerOrdersButton.Text = "View Customer Orders";
            this.CustomerOrderViewCustomerOrdersButton.UseVisualStyleBackColor = false;
            this.CustomerOrderViewCustomerOrdersButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(89, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 46);
            this.button3.TabIndex = 36;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(34, 30);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 46);
            this.button4.TabIndex = 37;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // CustomerOrderCustomerOrderReportsButton
            // 
            this.CustomerOrderCustomerOrderReportsButton.BackColor = System.Drawing.Color.Silver;
            this.CustomerOrderCustomerOrderReportsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerOrderCustomerOrderReportsButton.Location = new System.Drawing.Point(916, 581);
            this.CustomerOrderCustomerOrderReportsButton.Name = "CustomerOrderCustomerOrderReportsButton";
            this.CustomerOrderCustomerOrderReportsButton.Size = new System.Drawing.Size(207, 73);
            this.CustomerOrderCustomerOrderReportsButton.TabIndex = 38;
            this.CustomerOrderCustomerOrderReportsButton.Text = "Customer Order Reports";
            this.CustomerOrderCustomerOrderReportsButton.UseVisualStyleBackColor = false;
            this.CustomerOrderCustomerOrderReportsButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1199, 801);
            this.Controls.Add(this.CustomerOrderCustomerOrderReportsButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.CustomerOrderViewCustomerOrdersButton);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.CustomerOrderSearchOrdersButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CustomerOrderPayButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CustomerOrderAddButton);
            this.Controls.Add(this.CustomerOrderDeleteButton);
            this.Controls.Add(this.CustomerOrderUpdateButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Customer Order";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hWMSNDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderIDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hWMSNDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hWMSNDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hWMSNDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderBindingSource2)).EndInit();
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button CustomerOrderUpdateButton;
        private System.Windows.Forms.Button CustomerOrderDeleteButton;
        private System.Windows.Forms.Button CustomerOrderAddButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox9;
        private HWMSNDataSet hWMSNDataSet;
        private System.Windows.Forms.BindingSource customerOrderBindingSource;
        private HWMSNDataSetTableAdapters.CustomerOrderTableAdapter customerOrderTableAdapter;
        private System.Windows.Forms.Button CustomerOrderPayButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button CustomerOrderSearchOrdersButton;
        private System.Windows.Forms.ComboBox comboBox2;
        private HWMSNDataSet1 hWMSNDataSet1;
        private System.Windows.Forms.BindingSource customerOrderBindingSource1;
        private HWMSNDataSet1TableAdapters.CustomerOrderTableAdapter customerOrderTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HWMSNDataSet3 hWMSNDataSet3;
        private System.Windows.Forms.BindingSource customerOrderBindingSource2;
        private HWMSNDataSet3TableAdapters.CustomerOrderTableAdapter customerOrderTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDestinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource customerOrderBindingSource3;
        private System.Windows.Forms.BindingSource hWMSNDataSet3BindingSource;
        private CustomerOrderIDS customerOrderIDS;
        private System.Windows.Forms.BindingSource customerOrderBindingSource4;
        private CustomerOrderIDSTableAdapters.CustomerOrderTableAdapter customerOrderTableAdapter3;
        private System.Windows.Forms.Button CustomerOrderViewCustomerOrdersButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button CustomerOrderCustomerOrderReportsButton;
    }
}