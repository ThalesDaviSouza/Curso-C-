namespace ExFinal.Entities {
    class OrderClient {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }

        public OrderClient() { }
        public OrderClient(string name, string email, DateTime birthDate) {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString() {
            return $"{Name} ({BirthDate.ToString("dd/MM/yyyy")} - {Email})";
        }
    }
}
