using System;

namespace PrimeirosExerciciosOO {
    public class TestePessoa {
        public void Run() {
            Pessoa p1, p2;
            p1 = new Pessoa();
            p2 = new Pessoa();
            string name;
            int age;

            for (int i = 1; i <= 2; i++) {
                Console.WriteLine("Dados da pessoa #{0}", i);
                Console.Write("Nome: ");
                name = Console.ReadLine();
                Console.Write("Idade: ");
                age = int.Parse(Console.ReadLine());
                if (i == 1) {
                    p1 = new Pessoa(name, age);
                }
                else {
                    p2 = new Pessoa(name, age);
                }
            }

            Console.WriteLine("A pessoa mais velha é: {0}", (p1.getAge() > p2.getAge() ? p1.getName() : p2.getName()));
        }
    }
}
