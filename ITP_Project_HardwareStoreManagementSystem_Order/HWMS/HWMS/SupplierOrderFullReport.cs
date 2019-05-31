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
    public partial class SupplierOrderFullReport : Form
    {
        public SupplierOrderFullReport()
        {
            InitializeComponent();
        }

        private void SupplierOrderFullReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'HWMSNDataSet16.SupplierOrder' table. You can move, or remove it, as needed.
            this.SupplierOrderTableAdapter.Fill(this.HWMSNDataSet16.SupplierOrder);

            this.reportViewer1.RefreshReport();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CashierMenu cm1 = new CashierMenu();
            cm1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SupplierOrderReport sor1 = new SupplierOrderReport();
            sor1.Show();
            this.Hide();
        }
    }
}
