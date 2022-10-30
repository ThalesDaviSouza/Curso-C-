namespace Exercicio2 {
    public class Funcionario {
        private string _name;
        private double _salary;
        private double _tax;

        public Funcionario(string name, double salary, double tax) {
            _name = name;
            _salary = salary;
            _tax = tax;
        }   

        public double SalarioLiquido() {
            return _salary - _tax;
        }
        public void IncreaseSalary(double increase) {
            _salary *= (1+ (increase / 100));
        }

        public override string ToString() {
            return $"{_name}, salary ${_salary.ToString("F2")} and tax: ${_tax.ToString("F2")}";
        }

    }
}
