using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageMarkPharmacy
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomeForm w = new WelcomeForm();
            w.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeManagement employeeManagement = new EmployeeManagement();
            employeeManagement.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesReport salesReport = new SalesReport();
            salesReport.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            InventoryManagementForm inventoryManagementForm = new InventoryManagementForm();    
            inventoryManagementForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerManagementForm customerManagementForm = new CustomerManagementForm();   
                customerManagementForm.Show();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
       this.Close();
        }
    }
}
