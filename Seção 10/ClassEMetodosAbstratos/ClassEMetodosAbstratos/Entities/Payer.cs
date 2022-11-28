using System.Text;

namespace ClassEMetodosAbstratos.Entities {
    internal abstract class Payer {
        public string? Name { get; private protected set; }
        public double AnualIncome { get; private protected set; }

        public Payer() { }
        public Payer(string name, double anualIncome) {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double CalculateTaxes();

        public string PrintTaxes() {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Name} - $ {CalculateTaxes().ToString("F2")}");
            return sb.ToString();
        }

    }
}
