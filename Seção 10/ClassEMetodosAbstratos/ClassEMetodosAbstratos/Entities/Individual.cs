namespace ClassEMetodosAbstratos.Entities {
    internal class Individual : Payer{
        public double HealthExpenditures { get; private set; }

        public Individual() : base() { }
        public Individual(string name, double anualIncome, double healthExpenditures)
            : base(name, anualIncome) {
            HealthExpenditures = healthExpenditures;
        }

        public override double CalculateTaxes() {
            return ((AnualIncome < 20000) ? ((AnualIncome * 0.15) - (HealthExpenditures * 0.5))
                : ((AnualIncome * 0.25) - (HealthExpenditures * 0.5)));
        }
    }
}
