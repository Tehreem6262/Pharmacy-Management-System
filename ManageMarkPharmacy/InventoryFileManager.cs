using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace ManageMarkPharmacy
{
    public static class InventoryFileManager
    {
        public static string filePath = "inventory.txt";

        public static List<Inventory> LoadInventory()
        {
            var inventoryList = new List<Inventory>();

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var parts = line.Split('|'); 
                    if (parts.Length == 3)
                    {
                        inventoryList.Add(new Inventory
                        {
                            Name = parts[0],
                            Category = parts[1],
                            Quantity = int.Parse(parts[2])
                        });
                    }
                }
            }

            return inventoryList;
        }

        public static void SaveInventory(List<Inventory> inventoryList)
        {
            var lines = inventoryList.Select(i => $"{i.Name}|{i.Category}|{i.Quantity}");
            File.WriteAllLines(filePath, lines);
        }

        public static void DeductFromInventory(List<CartItem> soldItems)
        {
            var inventory = LoadInventory();

            foreach (var soldItem in soldItems)
            {
                var invItem = inventory.FirstOrDefault(i => i.Name == soldItem.Name);
                if (invItem != null)
                {
                    invItem.Quantity -= soldItem.Quantity;
                    if (invItem.Quantity < 0)
                        invItem.Quantity = 0;
                }
            }

            SaveInventory(inventory);
        }

    }

}

