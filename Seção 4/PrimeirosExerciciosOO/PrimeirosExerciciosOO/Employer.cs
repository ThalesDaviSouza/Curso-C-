using System;

namespace PrimeirosExerciciosOO {
    public class Employer {
        private String _name;
        private double _salary;

        public Employer() { }
        public Employer(String _name, double _salary) {
            this._name = _name;
            this._salary = _salary;
        }

        public String getName() {
            return _name;
        }
        public double getSalary() {
            return _salary;
        }
    }
}
