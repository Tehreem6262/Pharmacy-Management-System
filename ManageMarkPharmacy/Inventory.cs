using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageMarkPharmacy
{
    public class Inventory
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }

         public Inventory() { }

        public Inventory(string name, string category, int quantity)
        {
            Name = name;
            Category = category;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"{Name} - {Category} - Qty: {Quantity}";
        }
    }

}
