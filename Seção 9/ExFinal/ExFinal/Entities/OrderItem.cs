namespace ExFinal.Entities {
    class OrderItem {
        public int Quantity { get; private set; }
        public double Price { get; private set; }
        public OrderProduct Product { get; private set; }

        public OrderItem() { }
        public OrderItem(int quantity, double price, OrderProduct product) {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal() {
            return Quantity * Price;
        }

        public override string ToString() {
            return $"{Product.Name}, ${Price.ToString("F2")}, Quantity: {Quantity}, Subtotal: ${SubTotal().ToString("F2")}";
        }

    }
}
