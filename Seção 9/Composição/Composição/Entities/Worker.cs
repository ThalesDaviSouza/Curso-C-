using System.Collections.Generic;
using Composicao.Entities.Enums;

namespace Composicao.Entities {
    class Worker {
        public string? Name { get; private set; }
        public WorkerLevel Level { get; private set; }
        public double Salary { get; private set; }
        public List<HourContract> Contracts { get; private set; } = new List<HourContract>();
        public string? Department { get; private set; }

        public Worker() { }

        public Worker(string name, double salary, string department, WorkerLevel level) {
            Name = name;
            Salary = salary;
            Department = department;
            Level = level;
        }

        public Worker(string name, double salary, string department, WorkerLevel level, List<HourContract> contracts) : this(name, salary, department, level) {
            Contracts = contracts;
        }


        public void AddContract(HourContract contract) {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract) {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month) {
            double income = Salary;
            List<HourContract> revelantContracts = Contracts.FindAll(c => c.Date.Year == year && c.Date.Month == month);
            foreach (HourContract contract in revelantContracts) {
                income += contract.TotalValue();
            }

            return income;
        }

    }
}
