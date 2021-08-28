using System;
using System.Collections.Generic;
using System.Globalization;

namespace Ex23_Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listEmployee = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            int numberEmployee = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberEmployee; i++)
            {
                Console.WriteLine(string.Concat("Employee #", i+1));
                int auxId = int.Parse(Console.ReadLine());
                string auxName = Console.ReadLine();
                double auxSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Employee employee = new Employee(auxId, auxName, auxSalary);
                listEmployee.Add(employee);
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int id = int.Parse(Console.ReadLine());
            Employee auxEmployee = listEmployee.Find(x => x.Id == id);
            if(auxEmployee != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                auxEmployee.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("Employee not found");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Employee item in listEmployee)
            {
                Console.WriteLine(item);
            }
        }
    }
}
