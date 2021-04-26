using System;
using System.Globalization;
using exrcFixacao.Entities;
using exrcFixacao.Entities.Enums;

namespace exrcFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string cli = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime datebirth = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(cli, email, datebirth);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int nItens = int.Parse(Console.ReadLine());
            for(int i = 1; i <= nItens; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string prod = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Product product = new Product(prod, price);

                Console.Write("Quantity: ");
                int quantIten = int.Parse(Console.ReadLine());
                OrderItem orderItem = new OrderItem(quantIten, price, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine(order);
            Console.WriteLine(OrderStatus.Delivered);
            Console.ReadLine();
        }
    }
}
