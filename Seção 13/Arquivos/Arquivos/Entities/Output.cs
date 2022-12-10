namespace Arquivos.Entities {
    internal class Output {
        public string Name { get; private set; }
        public double TotalValue { get; private set; }

        public Output(string name, double totalValue) {
            Name = name;
            TotalValue = totalValue;
        }


    }
}
