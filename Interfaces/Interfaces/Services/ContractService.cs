using Interfaces.Entities;
using System.Text;

namespace Interfaces.Services {
    internal class ContractService {
        private IPaymentService _paymentService;
        public ContractService(IPaymentService paymentService) {
            this._paymentService = paymentService;
        }

        public void ProcessContract(Contract contract, int installmentsNumber) {
            DateTime dueDate;
            double amount;
            double monthlyPee = contract.Value / installmentsNumber;

            for(int i = 1; i <= installmentsNumber; i++) {
                dueDate = contract.Date.AddMonths(i);

                amount = monthlyPee;
                amount += _paymentService.Interest(monthlyPee, i);
                amount += _paymentService.PaymentFee(amount);

                contract.Installments.Add(new Installment(dueDate, amount));
            }
        }


    }
}
