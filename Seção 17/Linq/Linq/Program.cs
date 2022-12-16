using System;
using System.Linq;
using System.Collections.Generic;

using Linq.Entities;

namespace Linq {
    class Program {
        static void Main(string[] args) {
            try {
                string currentDirectory = Directory.GetCurrentDirectory();
                string inputFile = currentDirectory + @"\in.txt";
                
                if (!File.Exists(inputFile)) {
                    using(StreamWriter sw = File.CreateText(inputFile)) {
                        sw.WriteLine("Tv,900.00");
                        sw.WriteLine("Mouse,50.00");
                        sw.WriteLine("Tablet,350.50");
                        sw.WriteLine("HD Case,80.90");
                        sw.WriteLine("Computer,850.00");
                        sw.WriteLine("Monitor,290.00");
                    }
                }

                List<Product> products = new List<Product>();

                using(StreamReader sr = File.OpenText(inputFile)) {
                    while (!sr.EndOfStream) {
                        string[] product = sr.ReadLine().Split(",");
                        string productName = product[0];
                        double productValue = double.Parse(product[1]);

                        products.Add(new Product(productName, productValue));
                    }
                }

                double averagePrice = products.Select(p => p.Value).DefaultIfEmpty(0.0).Average();
                Console.WriteLine($"Average price: {averagePrice.ToString("F2")}");

                var belowValueProducts =
                    from p in products
                    where p.Value < averagePrice
                    orderby p.Name descending
                    select p.Name;


                foreach (var product in belowValueProducts) {
                    Console.WriteLine(product);
                }

            }
            catch(Exception e) {
                Console.WriteLine("An error ocurred: " + e.Message);
            }
        }
    }
}