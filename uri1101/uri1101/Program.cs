using System;

namespace uri1101 {
    class Program {
        static void Main(string[] args) {

            string[] valores = Console.ReadLine().Split(' ');
            int m = int.Parse(valores[0]);
            int n = int.Parse(valores[1]);

            while (m > 0 && n > 0) {

                int menor = m;
                int maior = n;

                if (m > n) {
                    menor = n;
                    maior = m;
                }

                int soma = 0;
                for (int i = menor; i <= maior; i++) {
                    soma = soma + i;
                    Console.Write(i + " ");
                }
                Console.WriteLine("Sum=" + soma);

                valores = Console.ReadLine().Split(' ');
                m = int.Parse(valores[0]);
                n = int.Parse(valores[1]);
            }
        }
    }
}
