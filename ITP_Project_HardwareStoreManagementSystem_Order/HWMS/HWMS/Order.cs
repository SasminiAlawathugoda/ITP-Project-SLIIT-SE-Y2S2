using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWMS
{
    class Order
    {
        private int orderId;
        private DateTime orderDate;
        private DateTime orderTime;
        private String orderDestination;
        private int itemId;
        private double quantity;
        private double weight;

        public Order(int orderId,DateTime orderDate,DateTime orderTime,String orderDestination,int itemId,double quantity,double weight)
        {
            this.orderId = orderId;
            this.orderDate = orderDate;
            this.orderTime = orderTime;
            this.orderDestination = orderDestination;
            this.itemId = itemId;
            this.quantity = quantity;
            this.weight = weight;
        }
        public Order() { }

        public void addOrder(Order order) {
            string conString = @"Data Source=DESKTOP-K75LPR3\MSSQL2014;Initial Catalog=HWMSN;Integrated Security=True;Pooling=False";
            string query = "Insert into Order(orderId,orderDate,orderTime,orderDestination,itemId,quantity,weight) values ('" + this.orderId + "' , '" + this.orderDate + "', '" + this.orderTime + "', '" + this.orderDestination + "', '" + this.itemId + "', '" + this.quantity + "', '" + this.weight + "');";
            SqlConnection conDataBase = new SqlConnection(conString);
            SqlCommand cmdDataBase = new SqlCommand(query, conDataBase);
            SqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        public void removeOrder(int orderId) { }

        public void updateOrder(int orderId) { }

        public void searchOrder(int orderId) { }

        public void deleteOrder(int orderId) {
            string conString = "Data Source = localhost; Initial Catalog = HWMS; Integrated Security = True; Pooling = False";
            string query = "delete from Order where orderID = @orderId";

            SqlConnection conDataBase = new SqlConnection(conString);
            SqlCommand cmdDataBase = new SqlCommand(query, conDataBase);
            cmdDataBase.Parameters.AddWithValue("@orderId", orderId);
            SqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        public Order getOrderById(int orderId) { return null; }

        public void generateOrderReport(int orderId) { }

    }
}
