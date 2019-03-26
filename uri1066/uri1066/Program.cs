using System;

namespace Curso {
    class Program {
        static void Main(string[] args) {
            int num, pares, impares, positivos, negativos, i;

            pares = 0;
            impares = 0;
            positivos = 0;
            negativos = 0;

            for (i = 1; i <= 5; i++) {
                num = int.Parse(Console.ReadLine());

                if (num % 2 == 0) {
                    pares++;

                }
                else {
                    impares++;
                }
                if (num > 0) {
                    positivos++;
                }
                else if (num < 0) {
                    negativos++;
                }
            }
            Console.WriteLine(pares + " valor(es) par(es)");
            Console.WriteLine(impares + " valor(es) impar(es)");
            Console.WriteLine(positivos + " valor(es) positivo(s)");
            Console.WriteLine(negativos + " valor(es) negativo(s)");

            Console.ReadLine();

        }
    }
}