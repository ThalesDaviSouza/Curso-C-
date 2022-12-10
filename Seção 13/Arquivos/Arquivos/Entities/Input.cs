namespace Arquivos.Entities {
    internal class Input {
        public string Name { get; private set; }
        public double Value { get; private set; }
        public int Quantity { get; private set; }

        public Input(string name, double value, int quantity) {
            Name = name;
            Value = value;
            Quantity = quantity;
        }
    }
}
