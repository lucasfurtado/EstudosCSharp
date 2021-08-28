using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ex23_Listas
{
    class Employee
    {
        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public void IncreaseSalary(double percentage)
        {
            Salary += Salary * (percentage/100);
        }

        public override string ToString()
        {
            return string.Concat(Id,", ",Name,", ",Salary.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
