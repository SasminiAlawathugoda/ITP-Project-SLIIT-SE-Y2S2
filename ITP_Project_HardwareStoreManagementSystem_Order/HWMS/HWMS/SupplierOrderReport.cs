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
    public partial class SupplierOrderReport : Form
    {
        public SupplierOrderReport()
        {
            InitializeComponent();
        }

        private void SupplierOrderReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'HWMSNDataSet15.SupplierOrder' table. You can move, or remove it, as needed.
           // this.SupplierOrderTableAdapter.Fill(this.HWMSNDataSet15.SupplierOrder);

           // this.reportViewer1.RefreshReport();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CashierMenu cm1 = new CashierMenu();
            cm1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 fm1 = new Form3();
            fm1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SupplierOrderTableAdapter.Fill(this.HWMSNDataSet15.SupplierOrder, int.Parse(textBox1.Text));

            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SupplierOrderFullReport sofr1 = new SupplierOrderFullReport();
            sofr1.Show();
            this.Hide();
        }
    }
}
