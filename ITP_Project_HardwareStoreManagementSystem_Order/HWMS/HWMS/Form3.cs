using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWMS
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hWMSNDataSet7.SupplierOrder' table. You can move, or remove it, as needed.
            this.supplierOrderTableAdapter1.Fill(this.hWMSNDataSet7.SupplierOrder);
            // TODO: This line of code loads data into the 'hWMSNDataSet6.SupplierOrder' table. You can move, or remove it, as needed.
            this.supplierOrderTableAdapter.Fill(this.hWMSNDataSet6.SupplierOrder);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            supplierOrder so1 = new  supplierOrder();
            so1.removeSupplierOrder(int.Parse(comboBox2.Text));
            this.supplierOrderTableAdapter.Fill(this.hWMSNDataSet6.SupplierOrder);
            this.supplierOrderTableAdapter1.Fill(this.hWMSNDataSet7.SupplierOrder);


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SupplierOrderUpdateButton_Click(object sender, EventArgs e)
        {
            UpdateSupplierOrder uso1 = new UpdateSupplierOrder();
            uso1.Show();
            this.Hide();
        }

        private void SupplierOrderAddButton_Click(object sender, EventArgs e)
        {
            Boolean empty = false;


            if (textBox3.Text == "")
            {
                textBox3.BackColor = Color.Red;
                empty = true;

            }
            else
            {
                textBox3.BackColor = Color.White;
            }

            if (textBox4.Text == "")
            {
                textBox4.BackColor = Color.Red;
                empty = true;
            }
            else
            {
                textBox4.BackColor = Color.White;
            }
            if (textBox5.Text == "")
            {
                textBox5.BackColor = Color.Red;
                empty = true;
            }
            else
            {
                textBox5.BackColor = Color.White;
            }
            if (textBox6.Text == "")
            {
                textBox6.BackColor = Color.Red;
                empty = true;
            }
            else
            {
                textBox6.BackColor = Color.White;
            }
            if (textBox7.Text == "")
            {
                textBox7.BackColor = Color.Red;
                empty = true;
            }
            else
            {
                textBox7.BackColor = Color.White;
            }
            if (textBox8.Text == "")
            {
                textBox8.BackColor = Color.Red;
                empty = true;
            }
            else
            {
                textBox8.BackColor = Color.White;
            }
            


            if (empty == true) { MessageBox.Show("Red Colored areas cannot keep as Empty!"); }
            else
            {

                supplierOrder newSupOrderOb1 = new supplierOrder(int.Parse(textBox3.Text), double.Parse(textBox4.Text), int.Parse(textBox5.Text), textBox6.Text, int.Parse(textBox7.Text), double.Parse(textBox8.Text));
                newSupOrderOb1.addSupplierOrder();
                this.supplierOrderTableAdapter.Fill(this.hWMSNDataSet6.SupplierOrder);
                this.supplierOrderTableAdapter1.Fill(this.hWMSNDataSet7.SupplierOrder);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f1 = new Form5();
            f1.Show();
            this.Hide();
        }

        private void SearchOrdersButton_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection;
            SqlCommand sqlcommand;
            string ConnectionString = @"Data Source=DESKTOP-K75LPR3\MSSQL2014;Initial Catalog=HWMSN;Integrated Security=True;Pooling=False";
            string query;
            DataTable datatable;
            SqlDataAdapter sqladapter;


            //Load_Event
            sqlconnection = new SqlConnection(ConnectionString);
            query = "select * from SupplierOrder where orderID = " + int.Parse(textBox1.Text) + "";
            sqlcommand = new SqlCommand(query, sqlconnection);
            sqladapter = new SqlDataAdapter();
            datatable = new DataTable();
            sqladapter.SelectCommand = sqlcommand;
            sqladapter.Fill(datatable);
            dataGridView1.DataSource = datatable;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlConnection sqlconnection;
            SqlCommand sqlcommand;
            string ConnectionString = @"Data Source=DESKTOP-K75LPR3\MSSQL2014;Initial Catalog=HWMSN;Integrated Security=True;Pooling=False";
            string query;
            DataTable datatable;
            SqlDataAdapter sqladapter;


            //Load_Event
            sqlconnection = new SqlConnection(ConnectionString);
            query = "select * from SupplierOrder ";
            sqlcommand = new SqlCommand(query, sqlconnection);
            sqladapter = new SqlDataAdapter();
            datatable = new DataTable();
            sqladapter.SelectCommand = sqlcommand;
            sqladapter.Fill(datatable);
            dataGridView1.DataSource = datatable;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CashierMenu cm1 = new CashierMenu();
            cm1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CashierMenu cm1 = new CashierMenu();
            cm1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SupplierOrderReport sor1 = new SupplierOrderReport();
            sor1.Show();
            this.Hide();
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                if (e.KeyChar != (char)8)
                {
                    MessageBox.Show("You pressed " + e.KeyChar + "\nPlease enter numbers only..");

                    e.KeyChar = (char)0;
                }


            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                if (e.KeyChar != (char)8)
                {
                    MessageBox.Show("You pressed " + e.KeyChar + "\nPlease enter numbers only..");

                    e.KeyChar = (char)0;
                }


            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                if (e.KeyChar != (char)8)
                {
                    MessageBox.Show("You pressed " + e.KeyChar + "\nPlease enter numbers only..");

                    e.KeyChar = (char)0;
                }


            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                if (e.KeyChar != (char)8)
                {
                    MessageBox.Show("You pressed " + e.KeyChar + "\nPlease enter numbers only..");

                    e.KeyChar = (char)0;
                }


            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 8) || (e.KeyChar == 32))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                if (e.KeyChar != (char)8)
                {
                    MessageBox.Show("You pressed " + e.KeyChar + "\nPlease enter numbers only..");

                    e.KeyChar = (char)0;
                }


            }
        }
    }
}
