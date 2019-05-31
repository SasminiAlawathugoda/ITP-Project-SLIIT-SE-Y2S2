using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWMS
{
    public partial class CustomerOrderReport : Form
    {
        public CustomerOrderReport()
        {
            InitializeComponent();
        }

        private void CustomerOrderReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'HWMSNDataSet13.CustomerOrder' table. You can move, or remove it, as needed.
           // this.CustomerOrderTableAdapter.Fill(this.HWMSNDataSet13.CustomerOrder);

           // this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
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
            Form2 fm1 = new Form2();
            fm1.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.CustomerOrderTableAdapter.Fill(this.HWMSNDataSet13.CustomerOrder, int.Parse(textBox1.Text));

            this.reportViewer1.RefreshReport();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerOrderFullReport cofr1 = new CustomerOrderFullReport();
            cofr1.Show();
            this.Hide();
        }
    }
}
