using Ex26_Enumeracoes.Entities;
using Ex26_Enumeracoes.Entities.Enums;
using System;

namespace Ex26_Enumeracoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1000,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Order order1 = new Order
            {
                Id = 1001,
                Moment = DateTime.Now.AddDays(-1),
                Status = os
            };

            Console.WriteLine(order1);
        }
    }
}
