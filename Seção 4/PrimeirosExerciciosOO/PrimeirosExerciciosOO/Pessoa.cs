using System;

namespace PrimeirosExerciciosOO {
    internal class Pessoa {
        private string _name;
        private int _age;

        public Pessoa() { }

        public Pessoa(string _name, int _age) {
            this._name = _name;
            this._age = _age;
        }

        public string getName() {
            return _name;
        }
        public int getAge() {
            return _age;
        }
    }
}
