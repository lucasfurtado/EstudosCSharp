using System;
using System.Globalization;

namespace Ex19_RegistroEmpregados
{
    class Program
    {
        static void Main(string[] args)
        {
            int id, lenght;
            string name;
            double salary, percentage;

            Employees[] vect;

            Console.Write("How many employees will be registered? ");
            lenght = int.Parse(Console.ReadLine());

            vect = new Employees[lenght];

            for(int i = 0; i < lenght; i++)
            {
                Console.WriteLine("Employee #" + (i+1));

                Console.Write("Id: ");
                id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                name = Console.ReadLine();

                Console.Write("Salary: ");
                salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vect[i] = new Employees(id, name, salary);

                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            id = int.Parse(Console.ReadLine());

            for (int i = 0; i < lenght; i++)
            {
                if(vect[i].Id == id)
                {
                    Console.Write("Enter the percentage: ");
                    percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    vect[i].IncreaseSalary(percentage);
                }
            }

            Console.WriteLine();

            Console.WriteLine("Updated list of employees:");

            for(int i = 0; i < lenght; i++)
            {
                Console.WriteLine(vect[i]);
            }

        }
    }
}
