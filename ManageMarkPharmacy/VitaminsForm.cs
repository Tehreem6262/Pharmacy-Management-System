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
    public partial class VitaminsForm : Form
    {
        public VitaminsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var selected in lstVitamins.SelectedItems)
            {
                string selectedItem = selected.ToString();
                double price = 0;
                int quantity = 1;

                if (selectedItem.Contains("A")) price = 60;
                else if (selectedItem.Contains("B12")) price = 80;
                else if (selectedItem.Contains("C")) price = 70;
                else if (selectedItem.Contains("D")) price = 90;
                else if (selectedItem.Contains("E")) price = 100;
                else price = 85;

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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VitaminsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
