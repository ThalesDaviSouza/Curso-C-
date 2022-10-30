using System;

namespace PrimeirosExerciciosOO {
    public class TestEmployer {
        public void Run() {
            Employer e1, e2;
            String name;
            double salary;
            
            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            name = Console.ReadLine();
            Console.Write("Salário: ");
            salary = double.Parse(Console.ReadLine());
            e1 = new Employer(name, salary);

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            name = Console.ReadLine();
            Console.Write("Salário: ");
            salary = double.Parse(Console.ReadLine());
            e2 = new Employer(name, salary);

            Console.WriteLine("O salário médio é: {0}", ((e1.getSalary()+e2.getSalary())/2.0).ToString("F3"));


        }
    }
}
