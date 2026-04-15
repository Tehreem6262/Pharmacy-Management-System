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
    public partial class SupplementsForm : Form
    {
        public SupplementsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var selected in lstSupplements.SelectedItems)
            {
                string selectedItem = selected.ToString();
                double price = 0;
                int quantity = 1;

                if (selectedItem.Contains("Vitamin C")) price = 70;
                else if (selectedItem.Contains("Calcium")) price = 100;
                else if (selectedItem.Contains("Iron")) price = 90;
                else if (selectedItem.Contains("Omega-3")) price = 150;
                else price = 80;

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

       

        private void SupplementsForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lstSupplements_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
