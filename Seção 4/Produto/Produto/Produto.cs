using System;

namespace Produto {
    public class Produto {
        private string _name;
        private double _price;
        private int _amount;

        public Produto() { }
        public Produto(string _name, double _price, int _amount) {
            this._name = _name;
            this._price = _price;
            this._amount = _amount;
        }

        public string getName() {
            return _name;
        }
        public double getPrice() {
            return _price;
        }
        public int getAmount() {
            return _amount;    
        }


        public double TotalValueInStock() {
            return _amount * _price;
        }

        public void AddProducts(int quantity) {
            _amount += quantity;
        }

        public void RemoveProducts(int quantity) {
            _amount -= quantity;
        }

        public override string ToString() {
            return $"{_name}, ${_price.ToString("F2")}. Actually has {_amount}, what means a total value in stock of ${TotalValueInStock().ToString("F2")}.";
        }

    }
}
