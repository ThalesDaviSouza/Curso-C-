using System;
using TratamentoDeExcecoes.Entities;
using TratamentoDeExcecoes.Entities.Exceptions;


public class Program {
    static void Main(string[] args) {
        try {
            Console.WriteLine("Enter account data:");
            Console.Write("Number: ");
            int accountNumber = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string accountHolder = Console.ReadLine();
            Console.Write("Initial Balance: ");
            double accountBalance = double.Parse(Console.ReadLine());
            Console.Write("Withdraw Limit: ");
            double accountWithdrawLimit = double.Parse(Console.ReadLine());

            Account account = new Account(accountNumber, accountHolder, accountBalance, accountWithdrawLimit);

            Console.WriteLine();
            Console.Write("Enter amount for withdraw: ");
            double withdraw = double.Parse(Console.ReadLine());
            account.Withdraw(withdraw);
            Console.WriteLine($"New balance: {account.Balance.ToString("F2")}");
        }
        catch(AccountException e) {
            Console.WriteLine(e.Message);
        }
        catch(Exception e) {
            Console.WriteLine("Error: " + e.Message);
        }

    }
}

