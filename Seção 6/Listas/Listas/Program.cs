using System;
using System.Collections.Generic;


namespace Listas {
    class Program {
        static void Main(string[] args) {
            List<Employee> employees = new List<Employee>();
            Employee? salaryIncrease;
            int employeesNumber;
            int employeeId;

            Console.Write("How many employees will be registered? ");
            employeesNumber = int.Parse(Console.ReadLine());
            for(int i = 1; i <= employeesNumber; i++) {
                int id;
                string name;
                double salary;

                Console.WriteLine("Employee #{0}:",  i);
                Console.Write("Id: ");
                id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Salary: ");
                salary = double.Parse(Console.ReadLine());
                Console.WriteLine();

                employees.Add(new Employee(id, name, salary));
            }

            Console.Write("Enter the employee id that will have the salary increase: ");
            employeeId = int.Parse(Console.ReadLine());
            salaryIncrease = employees.Find(employee => employee.Id == employeeId) ?? null;
            if (salaryIncrease != null) {
                double percentage;
                Console.Write("Enter the percentage: ");
                percentage = double.Parse(Console.ReadLine());
                salaryIncrease.IncreaseSalary(percentage);
            }
            else {
                Console.WriteLine("This id does not exist!");
            }
            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach(Employee e in employees) {
                Console.WriteLine(e);
            }

        }
    }
}