using System;

namespace Exercicio1 {
    public class TesteRetangulo {
        public void Run() {
            Retangulo r;
            Console.WriteLine("Entre com a largura e a altura do retângulo: ");
            r = new Retangulo(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));

            Console.WriteLine("Area: {0}", r.CalcularArea());
            Console.WriteLine("Perímetro: {0}", r.CalcularPerimetro());
            Console.WriteLine("Diagonal: {0}", r.CalcularDiagonal());

        }
    }
}
