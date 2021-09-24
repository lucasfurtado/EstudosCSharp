using Ex27_ExercicioEnumeracaoFuncionario.Entities;
using Ex27_ExercicioEnumeracaoFuncionario.Entities.Enums;
using System;
using System.Globalization;

namespace Ex27_ExercicioEnumeracaoFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter depatment's name: ");
            string departmentName = Console.ReadLine();

            Console.WriteLine("Enter Worker data:");

            Console.Write("Enter depatment's name: ");
            string name = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            string level = Console.ReadLine();

            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("How many contracts to this worker? ");
            int contracts = int.Parse(Console.ReadLine());

            Department department = new Department();
            department.Name = departmentName;
            Worker worker = new Worker(name, Enum.Parse<WorkerLevel>(level), baseSalary, department);

            for (int i = 0; i < contracts; i++)
            {
                HourContract hourContract = new HourContract();
                Console.WriteLine($"Enter #{i+1} contract to this worker?");
                Console.Write("Date (DD/MM/YYYY): ");
                hourContract.Date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                hourContract.ValuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                hourContract.Hours = int.Parse(Console.ReadLine());
                worker.AddContract(hourContract);
            }

            Console.WriteLine("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0,2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine(string.Concat($"Income for {monthAndYear}: {worker.Income(year, month).ToString("F2",CultureInfo.InvariantCulture)}"));
        }
    }
}
