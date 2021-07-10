using System.Globalization;

namespace Ex19_RegistroEmpregados
{
    class Employees
    {
        public int Id { private set; get; }
        public string Name { private set; get; }
        public double Salary { private set; get; }

        public Employees(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double percentage)
        {
            Salary += Salary * (percentage/100);
        }

        public override string ToString()
        {
            return Id + ", " + Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
