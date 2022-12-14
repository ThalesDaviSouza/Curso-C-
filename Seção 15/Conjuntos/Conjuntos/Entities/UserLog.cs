namespace Conjuntos.Entities {
    internal class UserLog : IComparable {
        public string Name { get; private set; }
        public DateTime Date { get; private set; }

        public UserLog(string name, DateTime date) {
            Name = name;
            Date = date;
        }

        public int CompareTo(object? obj) {
            if (obj is not UserLog) {
                throw new ArgumentException("Argument error: Argument is not a UserLog");
            }

            UserLog other = obj as UserLog;
            return Name.CompareTo(other.Name);
        }

        public override string ToString() {
            return $"{Name}";
        }
    }
}
