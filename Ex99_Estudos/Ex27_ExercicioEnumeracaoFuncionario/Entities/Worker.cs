using Ex27_ExercicioEnumeracaoFuncionario.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex27_ExercicioEnumeracaoFuncionario.Entities
{
    class Worker
    {
        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
            _hourContract = new List<HourContract>();
        }

        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        private readonly List<HourContract> _hourContract;

        public void AddContract(HourContract hContract)
        {
            _hourContract.Add(hContract);
        }

        public void RemoveCOntract(HourContract hourContract)
        {
            _hourContract.Remove(hourContract);
        }

        public double Income(int year, int month)
        {
            double income = 0.0;
            string date = string.Concat(year,"/",month);
            List<HourContract> list = _hourContract.Where(x => x.Date == DateTime.Parse(date)).ToList();
            foreach (HourContract item in list)
            {
                income += item.TotalValue();
            }
            return income;
        }
    }
}
