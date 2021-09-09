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
                Console.WriteLine("Enter #{0} contract to this worker?", i+1);
            }
        }
    }
}
