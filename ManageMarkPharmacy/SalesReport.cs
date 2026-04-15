using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace ManageMarkPharmacy
{
    public partial class SalesReport : Form
    {
        private string salesFilePath = "sales.txt";

        public SalesReport()
        {
            InitializeComponent();
            if (File.Exists(salesFilePath))
            {
                var lines = File.ReadAllLines(salesFilePath);
                foreach (string line in lines)
                {
                    lstSales.Items.Add(line);
                }
            }
            else
            {
                lstSales.Items.Add("No sales recorded yet.");
            }
        }

        private void SalesReport_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void lstSales_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin admin = new Admin();
            admin.Show();
        }
    }
}
