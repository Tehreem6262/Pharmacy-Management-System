using System;
using System.Collections.Generic;
using System.IO;          
using System.Linq;
using System.Windows.Forms;

namespace ManageMarkPharmacy
{
    public partial class InventoryManagementForm : Form
    {
        List<Inventory> inventory = new List<Inventory>();
        private readonly string inventoryFilePath = "inventory.txt";

        public InventoryManagementForm()
        {
            InitializeComponent();
        }

        private void InventoryManagementForm_Load(object sender, EventArgs e)
        {
            lstInventory.View = View.Details;
            lstInventory.FullRowSelect = true;
            lstInventory.GridLines = true;
            lstInventory.Columns.Clear();
            lstInventory.Columns.Add("Name", 150);
            lstInventory.Columns.Add("Quantity", 80);

            var groups = new Dictionary<string, ListViewGroup>
            {
                ["Pain Killer"] = new ListViewGroup("Pain Killers", HorizontalAlignment.Left),
                ["Cough Syrup"] = new ListViewGroup("Cough Syrups", HorizontalAlignment.Left),
                ["Vitamin"] = new ListViewGroup("Vitamins", HorizontalAlignment.Left),
                ["Antibiotic"] = new ListViewGroup("Antibiotics", HorizontalAlignment.Left),
                ["Supplement"] = new ListViewGroup("Supplements", HorizontalAlignment.Left),
                ["Other"] = new ListViewGroup("Others", HorizontalAlignment.Left)
            };

            lstInventory.Groups.AddRange(groups.Values.ToArray());

            void AddItem(string name, string category, int quantity = 0)
            {
                var item = new ListViewItem(name);
                item.SubItems.Add(quantity.ToString());
                item.Group = groups[category];
                lstInventory.Items.Add(item);

                inventory.Add(new Inventory { Name = name, Category = category, Quantity = quantity });
            }

            AddItem("Paracetamol", "Pain Killer");
            AddItem("Ibuprofen", "Pain Killer");
            AddItem("Aspirin", "Pain Killer");
            AddItem("Diclofenac", "Pain Killer");
            AddItem("Naproxen", "Pain Killer");

            AddItem("Benylin", "Cough Syrup");
            AddItem("Corex", "Cough Syrup");
            AddItem("Grilinctus", "Cough Syrup");
            AddItem("Ascoril D", "Cough Syrup");
            AddItem("Chericof", "Cough Syrup");

            AddItem("Vitamin A", "Vitamin");
            AddItem("Vitamin B12", "Vitamin");
            AddItem("Vitamin C", "Vitamin");
            AddItem("Vitamin E", "Vitamin");
            AddItem("Vitamin D", "Vitamin");

            AddItem("Amoxicillin", "Antibiotic");
            AddItem("Azithromycin", "Antibiotic");
            AddItem("Ciprofloxacin", "Antibiotic");
            AddItem("Erythromycil", "Antibiotic");
            AddItem("Doxycycline", "Antibiotic");

            AddItem("Calcium", "Supplement");
            AddItem("Iron", "Supplement");
            AddItem("Zinc", "Supplement");
            AddItem("Vitamin C", "Supplement");
            AddItem("Omega-3", "Supplement");

            AddItem("Bandages", "Other");
            AddItem("Face Mask", "Other");
            AddItem("Thermometer", "Other");
            AddItem("Hand Sanitizer", "Other");
            AddItem("Anticeptive Cream", "Other");
            AddItem("Oilnaments", "Other");
            AddItem("Eye Drops", "Other");
            AddItem("Nasal Spray", "Other");
            AddItem("Inhaler", "Other");
            AddItem("First Aid Kit", "Other");

            LoadInventoryFromFile();
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            if (lstInventory.SelectedItems.Count > 0)
            {
                var selectedItem = lstInventory.SelectedItems[0];

                if (!int.TryParse(txtAddQty.Text.Trim(), out int addedQty) || addedQty <= 0)
                {
                    MessageBox.Show("Please enter a valid quantity to add (e.g., 1, 2, 5...).");
                    return;
                }

                if (int.TryParse(selectedItem.SubItems[1].Text, out int currentQty))
                {
                    int newQty = currentQty + addedQty;
                    selectedItem.SubItems[1].Text = newQty.ToString();

                    var item = inventory.FirstOrDefault(i => i.Name == selectedItem.Text);
                    if (item != null)
                        item.Quantity = newQty;

                    txtAddQty.Clear();

                    SaveInventoryToFile();
                }
                else
                {
                    MessageBox.Show("Invalid quantity value in list.");
                }
            }
            else
            {
                MessageBox.Show("Please select an item to add stock.");
            }
        }

        private void SaveInventoryToFile()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(inventoryFilePath))
                {
                    foreach (var item in inventory)
                    {
                        writer.WriteLine($"{item.Name}|{item.Category}|{item.Quantity}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving inventory to file: {ex.Message}");
            }
        }


        private void LoadInventoryFromFile()
        {
            if (!File.Exists(inventoryFilePath))
                return;

            try
            {
                var lines = File.ReadAllLines(inventoryFilePath);
                foreach (var line in lines)
                {
                    var parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        string name = parts[0];
                        string category = parts[1];
                        if (int.TryParse(parts[2], out int quantity))
                        {
                            var item = inventory.FirstOrDefault(i => i.Name == name);
                            if (item != null)
                            {
                                item.Quantity = quantity;

                                var listViewItem = lstInventory.Items.Cast<ListViewItem>().FirstOrDefault(lvi => lvi.Text == name);
                                if (listViewItem != null)
                                {
                                    listViewItem.SubItems[1].Text = quantity.ToString();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading inventory from file: {ex.Message}");
            }
        }
       


        private void txtAddQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin admin = new Admin();
            admin.Show();
        }
    }
}
