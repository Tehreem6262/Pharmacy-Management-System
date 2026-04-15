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
    public partial class PainRelieversForm : Form
    {
        public PainRelieversForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var selected in lstPainRelievers.SelectedItems)
            {
                string selectedItem = selected.ToString();
                double price = 0;
                int quantity = 1; 

                if (selectedItem.Contains("Paracetamol")) price = 50;
                else if (selectedItem.Contains("Ibuprofen")) price = 60;
                else if (selectedItem.Contains("Aspirin")) price = 70;
                else if (selectedItem.Contains("Diclofenac")) price = 80;
                else price = 90;

                Cart.Items.Add(new CartItem
                {
                    Name = selectedItem,       
                    Price = price * quantity,
                    Quantity = quantity
                });

            }


            MessageBox.Show("Added to cart!");
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

        private void PainRelieversForm_Load(object sender, EventArgs e)
        {

        }
    }
}
