namespace Interfaces.Services {
    internal class PaypalService : IPaymentService {
        private const double _paymentFee = 0.02;
        private const double _monthlyInterest = 0.01;

        public PaypalService() { }

        public double Interest(double amount, int month) {
            return (amount * _monthlyInterest * month);
        }

        public double PaymentFee(double amount) {
            return (amount * _paymentFee);
        }
    
    }
}
