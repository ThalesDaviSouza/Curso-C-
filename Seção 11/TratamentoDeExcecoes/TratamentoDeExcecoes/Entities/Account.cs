using TratamentoDeExcecoes.Entities.Exceptions;

namespace TratamentoDeExcecoes.Entities {
    internal class Account {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; private set; }

        public Account() { }
        public Account(int number, string holder, double balance, double withdrawLimit) {
            if(balance < 0) {
                throw new AccountException("Account create error: Inicial balance invalid!");
            }

            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount) {
            if(amount <= 0) {
                throw new AccountException("Deposit error: The amount is equal or less than zero.");
            }
            Balance += amount;
        }
        public void Withdraw(double amount) {
            if(amount <= 0) {
                throw new AccountException("Withdraw error: The amount is equal or less than zero.");
            }
            if(amount > WithdrawLimit) {
                throw new AccountException("Withdraw error: The amount exceeds withdraw limit.");
            }
            if(amount > Balance) {
                throw new AccountException("Withdraw error: Not enough balance.");
            }
            Balance -= amount;
        }
    }
}
