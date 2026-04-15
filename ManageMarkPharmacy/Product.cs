using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageMarkPharmacy
{

    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public int Stock { get; set; }

        public Product(string name, double price, int quantity, int stock)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Stock = stock; 
        }

        public override string ToString()
        {
            return $"{Name} - Rs.{Price} x {Quantity} (Stock: {Stock})";
        }
    }


}

