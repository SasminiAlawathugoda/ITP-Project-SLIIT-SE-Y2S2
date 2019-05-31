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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customerOrderIDS.CustomerOrder' table. You can move, or remove it, as needed.
            this.customerOrderTableAdapter3.Fill(this.customerOrderIDS.CustomerOrder);
            // TODO: This line of code loads data into the 'hWMSNDataSet3.CustomerOrder' table. You can move, or remove it, as needed.
            this.customerOrderTableAdapter2.Fill(this.hWMSNDataSet3.CustomerOrder);

            // TODO: This line of code loads data into the 'hWMSNDataSet.CustomerOrder' table. You can move, or remove it, as needed.
            this.customerOrderTableAdapter.Fill(this.hWMSNDataSet.CustomerOrder);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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
            if (textBox9.Text == "")
            {
                textBox9.BackColor = Color.Red;
                empty = true;
            }
            else
            {
                textBox9.BackColor = Color.White;
            }
            


            if (empty == true) { MessageBox.Show("Red Colored areas cannot keep as Empty!"); } else { 

            customerOrder newCusOrderOb1 = new customerOrder(int.Parse(textBox3.Text), double.Parse(textBox4.Text), textBox5.Text,int.Parse(textBox6.Text), textBox7.Text, int.Parse(textBox8.Text), double.Parse(textBox9.Text)) ;
            newCusOrderOb1.addCustomerOrder();
            this.customerOrderTableAdapter2.Fill(this.hWMSNDataSet3.CustomerOrder);
            this.customerOrderTableAdapter3.Fill(this.customerOrderIDS.CustomerOrder);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateCustomerOrder uco1 = new UpdateCustomerOrder();
            uco1.Show();
            this.Hide();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form4 f1 = new Form4();
            f1.Show();
            this.Hide();
        }

        private void CustomerOrderDeleteButton_Click(object sender, EventArgs e)
        {
            customerOrder co1 = new customerOrder();
            co1.removeCustomerOrder(int.Parse(comboBox2.Text));
            this.customerOrderTableAdapter3.Fill(this.customerOrderIDS.CustomerOrder);
            this.customerOrderTableAdapter.Fill(this.hWMSNDataSet.CustomerOrder);
            this.customerOrderTableAdapter3.Fill(this.customerOrderIDS.CustomerOrder);
            this.customerOrderTableAdapter2.Fill(this.hWMSNDataSet3.CustomerOrder);

        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            query = "select * from CustomerOrder where orderID = " + int.Parse(textBox1.Text) + "";
            sqlcommand = new SqlCommand(query, sqlconnection);
            sqladapter = new SqlDataAdapter();
            datatable = new DataTable();
            sqladapter.SelectCommand = sqlcommand;
            sqladapter.Fill(datatable);
            dataGridView1.DataSource = datatable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection;
            SqlCommand sqlcommand;
            string ConnectionString = @"Data Source=DESKTOP-K75LPR3\MSSQL2014;Initial Catalog=HWMSN;Integrated Security=True;Pooling=False";
            string query;
            DataTable datatable;
            SqlDataAdapter sqladapter;


            //Load_Event
            sqlconnection = new SqlConnection(ConnectionString);
            query = "select * from CustomerOrder ";
            sqlcommand = new SqlCommand(query, sqlconnection);
            sqladapter = new SqlDataAdapter();
            datatable = new DataTable();
            sqladapter.SelectCommand = sqlcommand;
            sqladapter.Fill(datatable);
            dataGridView1.DataSource = datatable;

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
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
            CustomerOrderReport cor1 = new CustomerOrderReport();
            cor1.Show();
            this.Hide();
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                if(e.KeyChar != (char)8)
                {
                    MessageBox.Show("You pressed "+e.KeyChar+"\nPlease enter numbers only..");

                    e.KeyChar = (char)0;
                }
                
                   
            }

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 8)|| (e.KeyChar == 32))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
