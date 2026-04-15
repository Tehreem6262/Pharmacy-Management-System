using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageMarkPharmacy
{
    internal class Customer
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public bool IsRegistered { get; set; }

        public Customer(string name, string phone, bool isRegistered)
        {
            Name = name;
            Phone = phone;
            IsRegistered = isRegistered;
        }
        public override string ToString()
        {
            return $"{Name} - {Phone}";
        }
    }

}
