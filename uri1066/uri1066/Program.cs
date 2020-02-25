using System;

namespace Curso {
    class Program {
        static void Main(string[] args)
        {
            int num, pares, impares, positivos, negativos;

            pares = 0;
            impares = 0;
            positivos = 0;
            negativos = 0;

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

            Console.WriteLine(pares + " valor(es) par(es)");
            Console.WriteLine(impares + " valor(es) impar(es)");
            Console.WriteLine(positivos + " valor(es) positivo(s)");
            Console.WriteLine(negativos + " valor(es) negativo(s)");

            Console.ReadLine();
        }
    }
}
