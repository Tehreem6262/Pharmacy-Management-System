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
    public partial class CoughSyrupsForm : Form
    {
        public CoughSyrupsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var selected in lstCoughSyrups.SelectedItems)
            {
                string selectedItem = selected.ToString();
                double price = 0;
                int quantity = 1;

                if (selectedItem.Contains("Benylin")) price = 90;
                else if (selectedItem.Contains("Corex")) price = 110;
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

     

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CoughSyrupsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
