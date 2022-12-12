using System.Text;

namespace Interfaces.Entities {
    internal class Contract {
        public int Number { get; private set; }
        public DateTime Date { get; private set; }
        public double Value { get; private set; }
        public List<Installment> Installments { get; private set; }

        public Contract(int number, DateTime date, double value) {
            Number = number;
            Date = date;
            Value = value;
            Installments = new List<Installment>();
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Installments:");
            foreach(Installment i in Installments) {
                sb.AppendLine(i.ToString());
            }

            return sb.ToString();
        }
    }
}
