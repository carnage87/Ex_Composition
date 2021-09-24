using System;
using Ex_Composition.Entities;
using Ex_Composition.Entities.Enums;
using System.Globalization;

namespace Ex_Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            
            Client c = new Client(name, email, birthDate);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            //qoi = quantity of order items
            int qoi = int.Parse(Console.ReadLine());

            Order o = new Order(DateTime.Now, status, c);
            Product p;
            OrderItem oi;

            for (int i = 1; i <= qoi; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                //pname = product name / quantity = quantity of items in that orderitem
                string pname = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                p = new Product(pname, price);
                oi = new OrderItem(quantity, p);
                o.AddItem(oi);
            }
            Console.WriteLine("\n" + o);
        }
    }
}
