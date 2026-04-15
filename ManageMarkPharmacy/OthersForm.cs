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
    public partial class OthersForm : Form
    {
        public OthersForm()
        {
            InitializeComponent();
        }

        private void Others_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lstVitamins_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var selected in lstOthers.SelectedItems)
            {
                string selectedItem = selected.ToString();

                double price = 0;
                int quantity = 1;

                if (selectedItem.Contains("First Aid Kit")) price = 300;
                else if (selectedItem.Contains("Bandages")) price = 50;
                else if (selectedItem.Contains("Hand Sanitizer")) price = 150;
                else if (selectedItem.Contains("Face Mask")) price = 20;
                else if (selectedItem.Contains("Thermometer")) price = 250;
                else if (selectedItem.Contains("Glucose Powder")) price = 80;
                else if (selectedItem.Contains("Antiseptic Cream")) price = 90;
                else if (selectedItem.Contains("Mosquito Repellent")) price = 100;
                else if (selectedItem.Contains("Nasal Spray")) price = 120;
                else if (selectedItem.Contains("Ointments")) price = 70;
                else price = 50;

                Cart.Items.Add(new CartItem
                {
                    Name = selectedItem,      
                    Price = price * quantity,
                    Quantity = quantity
                });

            }

            MessageBox.Show("Items added to cart!");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerForm customerForm = new CustomerForm();
            customerForm.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
