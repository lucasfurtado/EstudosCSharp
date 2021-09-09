using Ex26_Enumeracoes.Entities.Enums;
using System;

namespace Ex26_Enumeracoes.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return "Id: " + Id + " " +
                "Data: " + Moment + " " +
                "Status: " + Status;
        }
    }
}
