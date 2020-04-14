using System;

namespace uri1150 {
    class Program {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());


            while (z <= x) {
                z = int.Parse(Console.ReadLine());
            }

            int cont = 1;
            int soma = x;
            do {
                x = x + 1;
                soma = soma + x;
                cont = cont + 1;
            } while (soma <= z);

            Console.WriteLine(cont);
        }
    }
}
