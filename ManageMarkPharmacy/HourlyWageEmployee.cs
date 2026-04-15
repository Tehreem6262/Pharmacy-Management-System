using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageMarkPharmacy
{
    public class HourlyWageEmployee : Employee
    {
        private double hourlyRate = 300;

        public HourlyWageEmployee(string name, int id, double hoursWorked)
            : base(name, id, hoursWorked) { }

        public override double CalculateSalary()
        {
            return hourlyRate * HoursWorked;
        }
    }
}
