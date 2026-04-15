using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageMarkPharmacy
{
       public class CartItem
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public int Quantity { get; set; }

            public CartItem() { }

            public CartItem(Product product, double price, int quantity)
            {
                Name = product.Name;
                Price = price;
                Quantity = quantity;
            }
     
    public override string ToString()
            {
                return $"{Name} x{Quantity} - Rs.{Price}";
            }
        }
    }

