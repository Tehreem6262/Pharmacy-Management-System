using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageMarkPharmacy
{
    internal class FileManager
    {
        public static void SaveBill(Customer customer, List<CartItem> items, double total)
        {
            string path = "bills.txt";
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine("========== BILL ==========");
                writer.WriteLine($"Name: {customer.Name}");
                writer.WriteLine($"Phone: {customer.Phone}");
                writer.WriteLine($"Registered: {customer.IsRegistered}");
                writer.WriteLine("Items:");

                foreach (var item in items)
                {
                    writer.WriteLine($"- {item.Name} Rs.{item.Price}");
                }

                writer.WriteLine($"Total: Rs.{total}");
                writer.WriteLine($"Date: {DateTime.Now}");
                writer.WriteLine("==========================");
                writer.WriteLine();
            }
        }
    }
}
