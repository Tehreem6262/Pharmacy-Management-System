using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageMarkPharmacy
{
    public  class FullTimeEmployee : Employee
    {
        private double monthlySalary = 40000;

        public FullTimeEmployee(string name, int id, double hoursWorked)
            : base(name, id, hoursWorked) { }

        public override double CalculateSalary()
        {
            return monthlySalary;
        }
    }
}
