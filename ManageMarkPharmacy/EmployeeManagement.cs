using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ManageMarkPharmacy
{
    public partial class EmployeeManagement : Form
    {
        private string filePath = "employees.txt";
        public EmployeeManagement()
        {
            InitializeComponent();
            cmbEmployeeType.Items.AddRange(new string[] { "Full-Time", "Part-Time", "Hourly-Waged" });
            cmbEmployeeType.SelectedIndex = 0;

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string name = txtName.Text;
            string hoursText = txtHoursWorked.Text;
            string type = cmbEmployeeType.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(hoursText) || string.IsNullOrWhiteSpace(type))
            {
                MessageBox.Show("Please fill all fields properly.");
                return;
            }

            if (!double.TryParse(hoursText, out double hours))
            {
                MessageBox.Show("Invalid number for hours worked.");
                return;
            }

            double salary = 0;
            switch (type)
            {
                case "Full-Time":
                    salary = 40000;
                    break;
                case "Part-Time":
                    salary = 20000;
                    break;
                case "Hourly-Waged":
                    salary = hours * 800;
                    break;
                default:
                    MessageBox.Show("Select a valid employee type.");
                    return;
            }

            string employeeInfo = $"ID: {id}, Name: {name}, Type: {type}, Salary: {salary}";

         
            lstEmployees.Items.Add(employeeInfo);

            
            try
            {
                File.AppendAllText(filePath, employeeInfo + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving employee: " + ex.Message);
            }

            label8.Text = $"{salary} PKR";
        }


        private void btnLoadEmployees_Click(object sender, EventArgs e)
        {



            if (File.Exists(filePath))
            {
                lstEmployees.Items.Clear();
                var lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    lstEmployees.Items.Add(line);
                }
            }
            else
            {
                MessageBox.Show("No employee records found.");
            }
        }

     

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblType_Click(object sender, EventArgs e)
        {

        }

        private void lstEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmployeeManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
