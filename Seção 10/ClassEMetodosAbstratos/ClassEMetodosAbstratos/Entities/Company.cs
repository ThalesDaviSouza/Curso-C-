using System.Collections.Generic;

namespace ClassEMetodosAbstratos.Entities {
    internal class Company : Payer{
        public int EmployeesNumber { get; private set; }

        public Company() : base() { }
        public Company(string name, double anualIncome, int employeesNumber)
            : base(name, anualIncome) {
            EmployeesNumber = employeesNumber;
        }

        public override double CalculateTaxes() {
            return ((EmployeesNumber < 10) ? (AnualIncome * 0.16) : (AnualIncome * 0.14));
        }

    }
}
