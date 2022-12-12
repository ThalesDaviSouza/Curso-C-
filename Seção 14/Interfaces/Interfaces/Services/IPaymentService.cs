namespace Interfaces.Services {
    internal interface IPaymentService {
        public double Interest(double amount, int month);
        public double PaymentFee(double amount);
    }
}
