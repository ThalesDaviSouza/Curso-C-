using Interfaces.Entities;
using Interfaces.Services;

using System;
using System.Globalization;

namespace Interfaces {
    public class Program {
        public static void Main(string[] args) {
            try {
                Console.WriteLine("Enter contract data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Date (dd/MM/yyyy): ");
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

                Console.Write("Contract value: ");
                double value = double.Parse(Console.ReadLine());

                Contract paymentContract = new Contract(number, date, value);

                Console.Write("Enter number of installments: ");
                int installmentsNumber = int.Parse(Console.ReadLine());

                ContractService contractService = new ContractService(new PaypalService());
                contractService.ProcessContract(paymentContract, installmentsNumber);

                Console.WriteLine(paymentContract);
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}