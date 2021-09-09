using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex27_ExercicioEnumeracaoFuncionario.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public double TotalValue() /**Total não esta em função da data**/
        {
            return ValuePerHour * Hours;
        }
    }
}
