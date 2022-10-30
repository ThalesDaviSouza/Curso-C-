using System;

namespace Produto {
    class Program {
        static void Main(string[] args) {
            Produto tv = new Produto("TV Smart", 2245.65, 6);
            Console.WriteLine(tv);
            tv.AddProducts(5);
            Console.WriteLine(tv);
            tv.RemoveProducts(7);
            Console.WriteLine(tv);
        }
    }
}