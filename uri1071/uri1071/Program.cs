using System;

namespace uri1071 {
    class Program {
        static void Main(string[] args) {

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int min, max;
            if (x < y) {
                min = x;
                max = y;
            }
            else {
                min = y;
                max = x;
            }

            int soma = 0;
            for (int i = min + 1; i < max; i++) {
                if (i % 2 != 0) {
                    soma = soma + i;
                }
            }

            Console.WriteLine(soma);
        }
    }
}
