using System.Collections.Generic;
using System.Text;
using ExFinal.Entities.Enums;

namespace ExFinal.Entities {
    class Order {
        public DateTime Moment { get; private set; }
        public OrderStatus Status { get; private set; }
        public List<OrderItem> Items { get; private set; } = new List<OrderItem>();
        public OrderClient Client { get; private set; }

        public Order() { }
        public Order(DateTime moment, OrderStatus status, OrderClient client) {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item) {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item) {
            Items.Remove(item);
        }
        public double Total() {
            double total = 0;
            foreach (OrderItem item in Items) {
                total += item.SubTotal();
            }

            return total;
        }


        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY");
            sb.AppendLine($"Order moment: {Moment.ToString("dd/MM/yyyy HH:mm:ss")}");
            sb.AppendLine($"Order status: {Status}");
            sb.AppendLine($"Client: {Client}");
            sb.AppendLine("Order Items:");
            foreach (OrderItem item in Items) {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine($"Total price: ${Total()}");
            return sb.ToString();
        }

    }
}
