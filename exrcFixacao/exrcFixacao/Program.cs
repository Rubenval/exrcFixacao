using System;
using System.Globalization;

namespace exrcFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string cliname = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime datebirth = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data:");
        }
    }
}
