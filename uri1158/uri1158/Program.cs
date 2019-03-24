using System;

namespace uri1158 {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {

                string[] valores = Console.ReadLine().Split(' ');
                int x = int.Parse(valores[0]);
                int y = int.Parse(valores[1]);

                int soma = 0;
                int cont = 0;
                for (int j = x; cont < y; j++) {
                    if (j % 2 != 0) {
                        soma = soma + j;
                        cont = cont + 1;
                    }
                }

                Console.WriteLine(soma);
            }
        }
    }
}
