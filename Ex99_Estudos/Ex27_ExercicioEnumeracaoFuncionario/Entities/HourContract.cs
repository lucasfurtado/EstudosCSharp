﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex27_ExercicioEnumeracaoFuncionario.Entities
{
    public class HourContract
    {
        public HourContract()
        {
            
        }

        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public double TotalValue()
        {
            return ValuePerHour * Hours;
        }
    }
}
