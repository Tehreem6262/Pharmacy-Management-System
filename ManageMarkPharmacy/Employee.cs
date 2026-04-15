using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageMarkPharmacy
{
    public abstract class Employee
    {
            public string Name { get; set; }
            public int ID { get; set; }
            public double HoursWorked { get; set; }

            public Employee(string name, int id, double hoursWorked)
            {
                Name = name;
                ID = id;
                HoursWorked = hoursWorked;
            }

            public abstract double CalculateSalary();
        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Hours: {HoursWorked}, Salary: Rs.{CalculateSalary()}";
        }
    }

    }

