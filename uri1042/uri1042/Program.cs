using System;

namespace uri1042 {
    class Program {
        static void Main(string[] args) {

            int x, y, z, maior, meio, menor;

            string[] valores = Console.ReadLine().Split(' ');
            x = int.Parse(valores[0]);
            y = int.Parse(valores[1]);
            z = int.Parse(valores[2]);

            if (x < y && x < z) {
                menor = x;
                if (y < z) {
                    meio = y;
                    maior = z;
                }
                else {
                    meio = z;
                    maior = y;
                }
            }
            else if (y < z) {
                menor = y;
                if (x < z) {
                    meio = x;
                    maior = z;
                }
                else {
                    meio = z;
                    maior = x;
                }
            }
            else {
                menor = z;
                if (x < y) {
                    meio = x;
                    maior = y;
                }
                else {
                    meio = y;
                    maior = x;
                }
            }

            Console.WriteLine(menor);
            Console.WriteLine(meio);
            Console.WriteLine(maior);
            Console.WriteLine();
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}
