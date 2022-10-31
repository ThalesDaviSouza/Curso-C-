namespace Properties {
    public class Conta {
        public int AccountNumber { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; private set; }

        public Conta() {
            Saldo = 0;
        }
        public Conta(int accountNumber, string titular) : this() {
            AccountNumber = accountNumber;
            Titular = titular;
        }
        public Conta(int accountNumber, string titular, double initialDeposit) : this(accountNumber, titular) {
            Deposit(initialDeposit);
        }

        public void Deposit(double amount) {
            if(amount > 0) {
                Saldo += amount;
            }
        }

        //Taxa de 5 reais para realizar a operação
        public void Draft(double amount) {
            if (amount > 0 && Saldo >= amount) {
                Saldo -= (amount + 5);
            }
        }



        public override string ToString() {
            return $"Conta {AccountNumber}, Títular: {Titular}, Saldo: ${Saldo.ToString("F2")}";
        }

    }
}
