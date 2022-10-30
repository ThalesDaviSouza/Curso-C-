using System;

namespace Exercicio2 {
    public class FuncionarioTeste {
        public void Run() {
            Funcionario test;
            string name;
            double salarioBruto, imposto;
            double aumento;
            
            Console.Write("Nome: ");
            name = Console.ReadLine();
            Console.Write("Salário bruto: ");
            salarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            imposto = double.Parse(Console.ReadLine());


            test = new Funcionario(name, salarioBruto, imposto);
            Console.WriteLine(test);
            Console.WriteLine($"Salário líquido: {test.SalarioLiquido().ToString("F2")}");
            
            Console.Write("Digite a porcentagem de aumento do salário: ");
            aumento = double.Parse(Console.ReadLine());
            
            test.IncreaseSalary(aumento);
            Console.WriteLine(test);
            Console.WriteLine($"Salário líquido: {test.SalarioLiquido().ToString("F2")}");

        }
    }
}
