using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ManageMarkPharmacy
{
    internal static class CustomerManager
    {
        public static void SaveCustomers(List<Customer> customers)
        {
            var lines = customers.Select(c => $"{c.Name},{c.Phone},{c.IsRegistered}");
            File.WriteAllLines("customers.txt", lines);
        }

        public static List<Customer> LoadCustomers()
        {
            List<Customer> customers = new List<Customer>();

            if (File.Exists("customers.txt"))
            {
                var lines = File.ReadAllLines("customers.txt");
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        string name = parts[0];
                        string phone = parts[1];
                        bool isRegistered = bool.Parse(parts[2]);
                        customers.Add(new Customer(name, phone, isRegistered));
                    }
                }
            }

            return customers;
        }

    }
}
