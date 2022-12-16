namespace Linq.Entities {
    internal class Product {
        public string Name { get; private set; }
        public double Value { get; private set; }

        public Product(string name, double value) {
            Name = name;
            Value = value;
        }
    }
}
