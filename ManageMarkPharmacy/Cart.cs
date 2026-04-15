using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace ManageMarkPharmacy
{
    internal class Cart
    {
        public static List<CartItem> Items { get; private set; } = new List<CartItem>();
        public static bool IsRegisteredCustomer { get; set; }

        public static void AddItem(Product product, int quantityToAdd = 1)
        {
            if (product.Stock < quantityToAdd)
            {
                Console.WriteLine("Not enough stock for " + product.Name);
                return; 
            }

            var existingItem = Items.FirstOrDefault(i => i.Name == product.Name);
            if (existingItem != null)
            {
                existingItem.Quantity += quantityToAdd;
            }
            else
            {
                Items.Add(new CartItem
                {
                    Name = product.Name,
                    Price = product.Price,
                    Quantity = quantityToAdd
                });
            }

            product.Stock -= quantityToAdd;
        }

        public static void Clear()
        {
            Items.Clear();
            IsRegisteredCustomer = false;
        }
    }
}
