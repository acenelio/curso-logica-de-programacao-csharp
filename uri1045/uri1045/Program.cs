using System;
using System.Globalization;

namespace uri1045 {
    class Program {
        static void Main(string[] args) {

            string[] valores = Console.ReadLine().Split(' ');
            double n1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double n2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double n3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            double A, B, C;
            if (n1 > n2 && n1 > n3) {
                A = n1;
                if (n2 > n3) {
                    B = n2;
                    C = n3;
                }
                else {
                    B = n3;
                    C = n2;
                }
            }
            else if (n2 > n3) {
                A = n2;
                if (n1 > n3) {
                    B = n1;
                    C = n3;
                }
                else {
                    B = n3;
                    C = n1;
                }
            }
            else {
                A = n3;
                if (n1 > n2) {
                    B = n1;
                    C = n2;
                }
                else {
                    B = n2;
                    C = n1;
                }
            }

            if (A >= B + C) {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else {
                // primeiro vamos testas as tres possibilidades em relacao a angulos
                if (A * A == B * B + C * C) {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                else if (A * A > B * B + C * C) {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                else {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }

                // agora vamos testar se pode ser equilatero ou isosceles
                if (A == B && B == C) {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (A == B || A == C || B == C) {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
        }
    }
}
