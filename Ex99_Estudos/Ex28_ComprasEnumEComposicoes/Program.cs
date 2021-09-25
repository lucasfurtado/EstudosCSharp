using Ex28_ComprasEnumEComposicoes.Entities;
using Ex28_ComprasEnumEComposicoes.Entities.Enum;
using System;

namespace Ex28_ComprasEnumEComposicoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string clientEmail = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime clientBirthDate = DateTime.Parse(Console.ReadLine());
            Client client = new Client(clientName, clientEmail, clientBirthDate);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            string stringStatus = Console.ReadLine();
            OrderStatus status = Enum.Parse<OrderStatus>(stringStatus.ToUpper());

            Console.Write("how many items to this order? ");
            int numberContracts = int.Parse(Console.ReadLine());
            Order order = new Order(status, client);
            for (int i = 0; i < numberContracts; i++)
            {
                Console.WriteLine($"Enter #{i+1} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(product, quantity);
                order.AddItem(orderItem);
            }
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine($"Order moment {order.Moment}");
            Console.WriteLine($"Order status {order.Status}");
            Console.WriteLine(client);
            Console.WriteLine("Order items:");
            foreach (OrderItem orderItem in order.Items)
            {
                Console.WriteLine(orderItem);
            }
            Console.WriteLine($"Total price: ${order.Total().ToString("F2", System.Globalization.CultureInfo.InvariantCulture)}");
        }
    }
}
