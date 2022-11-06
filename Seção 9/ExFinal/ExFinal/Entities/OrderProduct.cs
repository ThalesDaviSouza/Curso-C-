namespace ExFinal.Entities {
    class OrderProduct {
        public string Name { get; private set; }
        public double Price { get; private set; }

        public OrderProduct() { }
        public OrderProduct(string name, double price) {
            Name = name;
            Price = price;
        }

    }
}
