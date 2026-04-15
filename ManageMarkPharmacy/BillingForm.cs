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
    public partial class BillingForm : Form
    {
        public BillingForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerateBill_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string phone = txtPhone.Text;

            if (string.IsNullOrEmpty(name) || name.Any(char.IsDigit))
            {
                MessageBox.Show("Name should only contain letters and cannot be empty.");
                return;
            }

            if (!phone.All(char.IsDigit) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Phone number should contain only digits and cannot be empty.");
                return;
            }

            List<Customer> registeredCustomers = CustomerManager.LoadCustomers();
            bool isRegistered = registeredCustomers.Any(c => c.Name == name && c.Phone == phone);

            Customer customer = new Customer(name, phone, isRegistered);
            Cart.IsRegisteredCustomer = isRegistered;

            lstBill.Items.Clear();

            double total = 0;

            foreach (var item in Cart.Items)
            {
                lstBill.Items.Add(item.ToString());
                total += item.Price * item.Quantity;

                string saleRecord = $"Date: {DateTime.Now}, Item: {item.Name}, Qty: {item.Quantity}, Total: {item.Price} PKR";
                File.AppendAllText("sales.txt", saleRecord + Environment.NewLine);
            }

            if (isRegistered)
            {
                MessageBox.Show("Registered customer detected. 10% discount will be applied.");
                double discount = total * 0.10;
                total -= discount;
                lstBill.Items.Add($"Discount Applied: Rs.{discount}");
            }
            else
            {
                MessageBox.Show("Customer not registered. No discount.");
            }
            lstBill.Items.Add($"Final Total: Rs.{total}");
            lblTotal.Text = $"Total: Rs.{total}";

            

            FileManager.SaveBill(customer, Cart.Items, total);
            InventoryFileManager.DeductFromInventory(Cart.Items);

            Cart.Clear();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstBill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void BillingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
