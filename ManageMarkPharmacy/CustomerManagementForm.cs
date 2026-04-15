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
    public partial class CustomerManagementForm : Form
    {
        public CustomerManagementForm()
        {
            InitializeComponent();
        }

        List<Customer> registeredCustomers = new List<Customer>();

        private void CustomerManagementForm_Load(object sender, EventArgs e)
        {
            registeredCustomers = CustomerManager.LoadCustomers();
            RefreshCustomerList();
        }


        private void RefreshCustomerList()
        {
            lstCustomers.Items.Clear();
            foreach (var customer in registeredCustomers)
            {
                lstCustomers.Items.Add($"{customer.Name} - {customer.Phone}");
            }

            lblTotal.Text = $"Total Registered Customers: {registeredCustomers.Count}";
        }

        private void btnAddCustomer_Click_1(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string phone = txtPhone.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Please enter both name and phone.");
                return;
            }

            registeredCustomers = CustomerManager.LoadCustomers();

            if (registeredCustomers.Any(c => c.Name == name && c.Phone == phone))
            {
                MessageBox.Show("Customer already registered.");
                return;
            }

            var customer = new Customer(name, phone, true);
            registeredCustomers.Add(customer);

            CustomerManager.SaveCustomers(registeredCustomers);

            RefreshCustomerList();

            txtName.Clear();
            txtPhone.Clear();
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
           this.Close();
            Admin admin = new Admin();
            admin.Show();
        }
    }
}
