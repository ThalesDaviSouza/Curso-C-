using System;
using System.Collections.Generic;
using ClassEMetodosAbstratos.Entities;

namespace ClassEMetodosAbstratos {
    public class Program {
        static void Main(string[] args) {
            // Constant
            const string Individual = "I";
            const string Company = "C";

            //Variables
            List<Payer> Payers = new List<Payer>();

            Console.Write("Enter the number of tax payers: ");
            int taxPayersNumber = int.Parse(Console.ReadLine());
            for (int i = 1; i <= taxPayersNumber; i++) {
                Console.WriteLine($"Tax payer #{i} data");
                Console.WriteLine("Individual or Company (i/c)?");
                string payerType = Console.ReadLine().ToUpper();

                Console.Write("Name: ");
                string payerName = Console.ReadLine();
                Console.Write("Anual Income: ");
                double payerAnualIncome = double.Parse(Console.ReadLine());

                if (payerType == Individual) {
                    Console.Write("Health Expenditures: ");
                    double payerHealthExpenditures = double.Parse(Console.ReadLine());
                    Payers.Add(new Individual(payerName, payerAnualIncome, payerHealthExpenditures));
                }
                else if(payerType == Company) {
                    Console.Write("Number of Employees: ");
                    int payerEmployesNumber = int.Parse(Console.ReadLine());
                    Payers.Add(new Company(payerName, payerAnualIncome, payerEmployesNumber));
                }
                else {
                    Console.WriteLine("Something went wrong!");
                }
            }

            double totalTaxes = 0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach(Payer p in Payers) {
                Console.WriteLine(p.PrintTaxes());
                totalTaxes += p.CalculateTaxes();
            }
            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: {totalTaxes.ToString("F2")}");

        }
    }
}