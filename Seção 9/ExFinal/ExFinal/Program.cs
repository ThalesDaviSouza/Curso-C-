using System;
using System.Globalization;
using ExFinal.Entities;
using ExFinal.Entities.Enums;


namespace ExFinal {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter Client Data:");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string clientEmail = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime clientBirthDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            OrderClient Client = new OrderClient(clientName, clientEmail, clientBirthDate);
            
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(DateTime.Now, status, Client);

            Console.Write("How many items to this order? ");
            int numberItems = int.Parse(Console.ReadLine());
            for(int i = 1; i <= numberItems; i++) {
                Console.WriteLine("Enter #{0} item data:", i);
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());
                order.AddItem(new OrderItem(productQuantity, productPrice, new OrderProduct(productName, productPrice)));
            }

            Console.WriteLine(order);

        }
    }
}
