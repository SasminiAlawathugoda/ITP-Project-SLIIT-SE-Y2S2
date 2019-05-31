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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hWMSNDataSet8.billTemp' table. You can move, or remove it, as needed.
            this.billTempTableAdapter.Fill(this.hWMSNDataSet8.billTemp);

        }

        private void label11_Click(object sender, EventArgs e)
        {
            
        }
    }
}
