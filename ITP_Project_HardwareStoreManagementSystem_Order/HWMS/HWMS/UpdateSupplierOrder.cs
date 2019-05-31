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
    public partial class UpdateSupplierOrder : Form
    {
        public UpdateSupplierOrder()
        {
            InitializeComponent();
        }

        private void UpdateSupplierOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hWMSNDataSet17.SupplierOrder' table. You can move, or remove it, as needed.
            this.supplierOrderTableAdapter.Fill(this.hWMSNDataSet17.SupplierOrder);

        }

        

        private void SupplierOrderUpdateButton_Click(object sender, EventArgs e)
        {
            string conString = @"Data Source=DESKTOP-K75LPR3\MSSQL2014;Initial Catalog=HWMSN;Integrated Security=True;Pooling=False";
            string query = "update SupplierOrder set status = @val where orderID = @itemID";
            SqlConnection conDataBase = new SqlConnection(conString);
            SqlCommand cmdDataBase = new SqlCommand(query, conDataBase);
            int value = int.Parse(comboBox2.Text);
            String value2 = comboBox1.Text;
            //if (value2 == "Complete")
            //{
            cmdDataBase.Parameters.AddWithValue("@itemID", value);
            cmdDataBase.Parameters.AddWithValue("@val", value2);

            SqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                myReader.Close();
                MessageBox.Show("Add as Completed!");
                this.supplierOrderTableAdapter.Fill(this.hWMSNDataSet17.SupplierOrder);


            }
            catch (Exception ex)
            {
                MessageBox.Show("1: " + ex.Message);
            }
            //}
            //else {
            //    MessageBox.Show("There is no any changes to Update!");
            //}
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string conString = @"Data Source=DESKTOP-K75LPR3\MSSQL2014;Initial Catalog=HWMSN;Integrated Security=True;Pooling=False";
            string query = "Select * From SupplierOrder where orderID = @itemID";
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
                     
                    textBox2.Text = myReader.GetString(8).ToString();
                    textBox3.Text = myReader.GetInt32(9).ToString();
                    comboBox1.Text = myReader.GetString(11).ToString();
                }
                myReader.Close();
                myReader.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show("1: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CashierMenu cm1 = new CashierMenu();
            cm1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }
    }
}
