using System;

namespace Properties {
    public class ContaTeste {
        public void Run() {
            Conta client;
            int accountNumber;
            string titular;
            double initialDeposit, deposit, draft;

            Console.Write("Entre o número da conta: ");
            accountNumber = int.Parse(Console.ReadLine());
            Console.Write("Entre o títular da conta: ");
            titular = Console.ReadLine();
            
            Console.Write("Haverá depóstito inicial (s/n)? ");
            if(Console.ReadLine().ToLower() == "s") {
                Console.Write("Entre com o depósito inicial: ");
                initialDeposit = double.Parse(Console.ReadLine());
                client = new Conta(accountNumber, titular, initialDeposit);
            }
            else {
                client = new Conta(accountNumber, titular);
            }

            Console.WriteLine("Dados da conta");
            Console.WriteLine(client);

            Console.Write("\nEntre um valor para deposito: ");
            deposit = double.Parse(Console.ReadLine());
            client.Deposit(deposit);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(client);

            Console.Write("Entre um valor para saque: ");
            draft = double.Parse(Console.ReadLine());
            client.Draft(draft);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(client);

        }


    }
}
