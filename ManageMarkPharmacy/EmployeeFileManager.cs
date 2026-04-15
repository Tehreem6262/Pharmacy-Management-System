using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ManageMarkPharmacy
{
    public static class EmployeeFileManager
    {
        private static string empFilePath = "employees.txt";

        public static void SaveEmployee(Employee emp)
        {
            File.AppendAllText(empFilePath, emp.ToString() + Environment.NewLine);
        }

        public static List<string> LoadEmployees()
        {
            if (File.Exists(empFilePath))
                return new List<string>(File.ReadAllLines(empFilePath));
            else
                return new List<string>();
        }  }
    }
