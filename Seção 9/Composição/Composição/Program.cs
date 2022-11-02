using System;
using Composicao.Entities;
using Composicao.Entities.Enums;
using System.Globalization;

namespace Composicao {
    class Program {
        static void Main(string[] args) {
            Worker worker;

            Console.Write("Enter department's name: ");
            string departmentName = Console.ReadLine();

            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double salary = double.Parse(Console.ReadLine());
            worker = new Worker(name, salary, departmentName, level);

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++) {
                Console.WriteLine("Enter #{0} contract data:", i);
                Console.Write("Data (DD/MM/YYYY): ");
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.Write("Value per hour: ");
                double value = double.Parse(Console.ReadLine());
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                worker.AddContract(new HourContract(date, value, hours));
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string[] dateIncome = Console.ReadLine().Split('/');
            int month = int.Parse(dateIncome[0]);
            int year = int.Parse(dateIncome[1]);

            Console.WriteLine();
            Console.WriteLine("Name: {0}", worker.Name);
            Console.WriteLine("Department: {0}", worker.Department);
            
            Console.WriteLine("Income for {0}/{1}: {2}", month, year, worker.Income(year, month));

        }
    }
}