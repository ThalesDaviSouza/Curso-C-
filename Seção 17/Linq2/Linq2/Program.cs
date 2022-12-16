using System;
using System.Linq;
using System.Collections.Generic;
using Linq2.Entities;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;

namespace Linq2 {
    class Program {
        static void Main(string[] args) {
            try {
                string inputFile = Directory.GetCurrentDirectory() + @"\in.txt";
                List<Employee> employees = new List<Employee>();
                
                if (!File.Exists(inputFile)) {
                    using(StreamWriter sw = File.CreateText(inputFile)) {
                        sw.WriteLine("Maria,maria@gmail.com,3200.00");
                        sw.WriteLine("Alex,alex@gmail.com,1900.00");
                        sw.WriteLine("Marco,marco@gmail.com,1700.00");
                        sw.WriteLine("Bob,bob@gmail.com,3500.00");
                        sw.WriteLine("Anna,anna@gmail.com,2800.00");
                    }
                }

                using (StreamReader sr = File.OpenText(inputFile)) {
                    while (!sr.EndOfStream) {
                        string[] data = sr.ReadLine().Split(",");
                        string name = data[0];
                        string email = data[1];
                        double salary = double.Parse(data[2]);
                        employees.Add(new Employee(name, email, salary));
                    }
                }
                
                Console.Write("Enter salary: ");
                double search = double.Parse(Console.ReadLine());

                var result =
                    from e in employees
                    where e.Salary > search
                    orderby e.Name
                    select e.Email;

                Console.WriteLine($"Email of people whose salary is more than {search.ToString("F2")}:");
                foreach (var employee in result) {
                    Console.WriteLine(employee);
                }

                var sum =
                    (from e in employees
                     where e.Name.ToUpper()[0] == 'M'
                     select e.Salary)
                    .DefaultIfEmpty(0.0)
                    .Sum();

                Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sum.ToString("F2"));    


            }
            catch(Exception e) {
                Console.WriteLine("An error ocurred: " + e.Message);
            }
        }
    }
}