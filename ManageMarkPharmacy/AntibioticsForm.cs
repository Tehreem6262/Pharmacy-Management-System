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
    public partial class AntibioticsForm : Form
    {
        public AntibioticsForm()
        {
            InitializeComponent();
        }

        private void AntibioticsForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (var selected in lstAntibiotics.SelectedItems)
            {
                string selectedItem = selected.ToString();
                int quantity = 1;
                double price = 0;
                if (selectedItem.Contains("Amoxylene")) price = 100;
                else if (selectedItem.Contains("Azithromycin")) price = 120;
                else price = 80;

                Cart.Items.Add(new CartItem
                {
                    Name = selectedItem,       
                    Price = price * quantity,
                    Quantity = quantity
                });

            }

            MessageBox.Show("Items added to cart!");
            this.Hide();
            CustomerForm customerForm = new CustomerForm();
            customerForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
