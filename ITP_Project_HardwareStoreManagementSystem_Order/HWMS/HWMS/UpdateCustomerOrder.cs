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
    public partial class UpdateCustomerOrder : Form
    {
        public UpdateCustomerOrder()
        {
            InitializeComponent();
        }

        private void CustomerOrderUpdateButton_Click(object sender, EventArgs e)
        {
            string conString = @"Data Source=DESKTOP-K75LPR3\MSSQL2014;Initial Catalog=HWMSN;Integrated Security=True;Pooling=False";
            string query = "update CustomerOrder set status = @val where orderID = @itemID";
            SqlConnection conDataBase = new SqlConnection(conString);
            SqlCommand cmdDataBase = new SqlCommand(query, conDataBase);
            int value = int.Parse(comboBox2.Text);
            String value2 = comboBox1.Text;
           // if (value2 == "Complete")
           // {
            cmdDataBase.Parameters.AddWithValue("@itemID", value);
            cmdDataBase.Parameters.AddWithValue("@val", value2);
             
            SqlDataReader myReader;
                try
                {
                    conDataBase.Open();
                    myReader = cmdDataBase.ExecuteReader();
                    myReader.Close();
                    MessageBox.Show("Add as Completed!");
                    this.customerOrderTableAdapter1.Fill(this.hWMSNDataSet12.CustomerOrder);
                    this.customerOrderTableAdapter.Fill(this.hWMSNDataSet10.CustomerOrder);


            }
                catch (Exception ex)
                {
                    MessageBox.Show("1: " + ex.Message);
                }
         
           // }
           // else {
           //     MessageBox.Show("There is no any changes to Update!");
           // }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string conString = @"Data Source=DESKTOP-K75LPR3\MSSQL2014;Initial Catalog=HWMSN;Integrated Security=True;Pooling=False";
            string query = "Select * From CustomerOrder where orderID = @itemID";
            SqlConnection conDataBase = new SqlConnection(conString);
            SqlCommand cmdDataBase = new SqlCommand(query, conDataBase);
            String value1 = comboBox2.Text;
           // int value = int.Parse(value1);
            cmdDataBase.Parameters.AddWithValue("@itemID", value1);
            SqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {
                    textBox5.Text = myReader.GetString(7).ToString();
                    textBox7.Text = myReader.GetString(9).ToString();
                    textBox8.Text = myReader.GetInt32(10).ToString();
                    comboBox1.Text = myReader.GetString(12).ToString();
                }
                myReader.Close();
                myReader.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show("1: " + ex.Message);
            }
        }

        private void UpdateCustomerOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hWMSNDataSet12.CustomerOrder' table. You can move, or remove it, as needed.
            this.customerOrderTableAdapter1.Fill(this.hWMSNDataSet12.CustomerOrder);
            // TODO: This line of code loads data into the 'hWMSNDataSet10.CustomerOrder' table. You can move, or remove it, as needed.
            this.customerOrderTableAdapter.Fill(this.hWMSNDataSet10.CustomerOrder);

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CashierMenu cm1 = new CashierMenu();
            cm1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
