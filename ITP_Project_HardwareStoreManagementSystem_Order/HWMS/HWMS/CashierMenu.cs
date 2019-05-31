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
    public partial class CashierMenu : Form
    {
        public CashierMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 f1 = new Form6();
            f1.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f1 = new Form3();
            f1.Show();
            this.Hide();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hWMSNDataSet9.billTemp' table. You can move, or remove it, as needed.
            this.billTempTableAdapter3.Fill(this.hWMSNDataSet9.billTemp);
            // TODO: This line of code loads data into the 'permanentCustomerDrop.PermanentCustomer' table. You can move, or remove it, as needed.
            //Customer id Drop down
            this.permanentCustomerTableAdapter.Fill(this.permanentCustomerDrop.PermanentCustomer);
            // TODO: This line of code loads data into the 'tempBill.billTemp' table. You can move, or remove it, as needed.
            //data table generate
            this.billTempTableAdapter2.Fill(this.tempBill.billTemp);
            // TODO: This line of code loads data into the 'tempBillDisplya.billTemp' table. You can move, or remove it, as needed.
            this.billTempTableAdapter1.Fill(this.tempBillDisplya.billTemp);
            // TODO: This line of code loads data into the 'hWMSNDataSet5.billTemp' table. You can move, or remove it, as needed.
            this.billTempTableAdapter.Fill(this.hWMSNDataSet5.billTemp);
            // TODO: This line of code loads data into the 'hWMSNDataSet4.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.hWMSNDataSet4.Stock);

        }

        private void CustomerOrdersButton_Click_1(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            f1.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BillButton_Click(object sender, EventArgs e)
        {
            billPanel.Visible = false;
        }

        private void BillAddButton_Click(object sender, EventArgs e)
        {
            double total = 0;
            String quantityType = "";

            bool discount = false;
            if (discountCheck.Checked)
            {
                discount = true;
            }

            string conString = @"Data Source=DESKTOP-K75LPR3\MSSQL2014;Initial Catalog=HWMSN;Integrated Security=True;Pooling=False";
            string query = "Select * From Stock where itemID = @itemID";
            SqlConnection conDataBase = new SqlConnection(conString);
            SqlCommand cmdDataBase = new SqlCommand(query, conDataBase);
            int value = int.Parse(itemIDcbox.Text);
            cmdDataBase.Parameters.AddWithValue("@itemID", value);
            SqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {
                    quantityType = myReader.GetString(2);
                    total = double.Parse(myReader.GetValue(3).ToString());
                }
                myReader.Close();
                myReader.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show("2: " + ex.Message);
            }

            int quantity = int.Parse(quntityNMD.Value.ToString());
            total = total * quantity;
            Bill billob = new Bill(int.Parse(itemIDcbox.Text),itemNameT.Text,int.Parse(quntityNMD.Value.ToString()),int.Parse(customerIdcbox.Text), quantityType, discount,total);
            billob.addTemporyBill();
            this.billTempTableAdapter2.Fill(this.tempBill.billTemp);
        }

        private void itemIDcbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string conString = @"Data Source=DESKTOP-K75LPR3\MSSQL2014;Initial Catalog=HWMSN;Integrated Security=True;Pooling=False";
            string query = "Select * From Stock where itemID = @itemID";
            SqlConnection conDataBase = new SqlConnection(conString);
            SqlCommand cmdDataBase = new SqlCommand(query, conDataBase);
            int value = int.Parse(itemIDcbox.Text);
            cmdDataBase.Parameters.AddWithValue("@itemID", value);
            SqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {
                    itemNameT.Text = myReader.GetString(1).ToString();
                }
                myReader.Close();
                myReader.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show("1: " + ex.Message);
            }
        }

        private void BillDeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 1)
            {
                MessageBox.Show("There is no any bill do Discard!");
            }
            else { 
            DialogResult result1 = MessageBox.Show("Do you want to Discard bill?", "Confirmation",MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes) { 
            Bill billob2 = new Bill();
            billob2.removeTemporyBill();
            this.billTempTableAdapter2.Fill(this.tempBill.billTemp);
            }
            }
        }

        private void SupplierOrdersButton_Click(object sender, EventArgs e)
        {
            Form3 f1 = new Form3();
            f1.Show();
            this.Hide();
        }

        private void pay_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 1) {
                MessageBox.Show("You need to add entries to Bill!");
            }
            else { 
            billPanel.Visible = true;
            Bill b = new Bill();
            label15.Text = b.setBillID().ToString();
            label9.Text = DateTime.Today.ToString("dd/MM/yyyy");
            label5.Text = DateTime.Now.ToString("hh:mm");
            string conString1 = @"Data Source=DESKTOP-K75LPR3\MSSQL2014;Initial Catalog=HWMSN;Integrated Security=True;Pooling=False";
            string query1 = "Select top 1 row from  CustomerOrder order by row DESC";
            SqlConnection conDataBase1 = new SqlConnection(conString1);
            SqlCommand cmdDataBase1 = new SqlCommand(query1, conDataBase1);
            SqlDataReader myReader1;
            try
            {
                conDataBase1.Open();
                myReader1 = cmdDataBase1.ExecuteReader();
                //int row = myReader.GetInt32(0);
                while (myReader1.Read())
                {
                   
                }
                
                myReader1.Close();
                myReader1.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show("1: " + ex.Message);
            }

            }


            int total = 0;
            string conString = @"Data Source=DESKTOP-K75LPR3\MSSQL2014;Initial Catalog=HWMSN;Integrated Security=True;Pooling=False";
            string query = "Select * from billTemp";
            SqlConnection conDataBase = new SqlConnection(conString);
            SqlCommand cmdDataBase = new SqlCommand(query, conDataBase);
            SqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                //int orderIDX = myReader.GetInt32(0);

                while (myReader.Read())
                {
                    total = int.Parse(myReader["total"].ToString()) + total;
                }
                myReader.Close();
                myReader.Dispose();


            }
            catch (Exception ex)
            {
                MessageBox.Show("1: " + ex.Message);

            }
            label11.Text = total.ToString();
            this.billTempTableAdapter3.Fill(this.hWMSNDataSet9.billTemp);

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            int balance = 0;
            int total = int.Parse(label11.Text);
            
            String cashe = cashT.Text;
            if (cashe == "")
                cashe = "0";
            balance = int.Parse(cashe) - total;
            label14.Text = balance.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(cashT.Text == "") { MessageBox.Show("Cannot proceed the bill without Payments!"); } else { 
            String itemIDD = "";
            String quantityD = "";
            string conString = @"Data Source=DESKTOP-K75LPR3\MSSQL2014;Initial Catalog=HWMSN;Integrated Security=True;Pooling=False";
            string query1 = "Select * From billTemp";
            
            string query3 = "delete billTemp";
            SqlConnection conDataBase = new SqlConnection(conString);
            SqlCommand cmdDataBase1 = new SqlCommand(query1, conDataBase);
           
            SqlCommand cmdDataBase3 = new SqlCommand(query3, conDataBase);
            int value = int.Parse(itemIDcbox.Text);
            
            SqlDataReader myReader1;
           
            SqlDataReader myReader3;
            try
            {
                conDataBase.Open();
                myReader1 = cmdDataBase1.ExecuteReader();
                while (myReader1.Read())
                {
            
                    itemIDD = itemIDD + myReader1["itemId"].ToString();
                   
                    itemIDD = itemIDD + myReader1["quantity"].ToString();

                    quantityD = quantityD + myReader1["quantity"].ToString();
                }

                myReader1.Close();
                myReader1.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("1: " + ex.Message);
            }

            double total = double.Parse(label11.Text);
            Bill b = new Bill();
            try
            {
                int billIDD = int.Parse(label15.Text);
                string query2 = "insert into Bill(billID,transactionID,billDate, billTime, itemID, quantity, total) values(" +billIDD+ "," + billIDD + ",GETUTCDATE(),CURRENT_TIMESTAMP,'" + itemIDD + "','" + billIDD + "'," + total + ")";
                SqlCommand cmdDataBase2 = new SqlCommand(query2, conDataBase);
                SqlDataReader myReader2;
                //conDataBase.Open();
                
                myReader2 = cmdDataBase2.ExecuteReader();

                myReader2.Close();
                myReader2.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("2: " + ex.Message);
            }
            try
            {
                //conDataBase.Open();
                myReader3 = cmdDataBase3.ExecuteReader();
                myReader3.Close();
                myReader3.Dispose();
                    MessageBox.Show("Payment succesfull!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("3: " + ex.Message);
            }

            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
