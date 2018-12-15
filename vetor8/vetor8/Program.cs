using System;
using System.Globalization;

namespace vetor8 {
    class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());

            double[] alturas = new double[N];
            char[] sexos = new char[N];

            for (int i = 0; i < N; i++) {
                string[] valores = Console.ReadLine().Split(' ');
                alturas[i] = double.Parse(valores[0], CultureInfo.InvariantCulture);
                sexos[i] = char.Parse(valores[1]);
            }

            // 1: menor altura
            double menorAltura = alturas[0];
            for (int i = 1; i < N; i++) {
                if (alturas[i] < menorAltura) {
                    menorAltura = alturas[i];
                }
            }
            Console.WriteLine("Menor altura = " + menorAltura.ToString("F2", CultureInfo.InvariantCulture));

            // 2: maior altura
            double maiorAltura = alturas[0];
            for (int i = 1; i < N; i++) {
                if (alturas[i] > maiorAltura) {
                    maiorAltura = alturas[i];
                }
            }
            Console.WriteLine("Maior altura = " + maiorAltura.ToString("F2", CultureInfo.InvariantCulture));

            // 3: altura media das mulheres
            double somaDasAlturasDasMulheres = 0.0;
            int contMulheres = 0;
            for (int i = 0; i < N; i++) {
                if (sexos[i] == 'F') {
                    somaDasAlturasDasMulheres = somaDasAlturasDasMulheres + alturas[i];
                    contMulheres++;
                }
            }

            if (contMulheres == 0) {
                Console.WriteLine("Nao ha nenhuma mulher dentre as pessoas");
            }
            else {
                double media = somaDasAlturasDasMulheres / contMulheres;
                Console.WriteLine("Media das alturas das mulheres = " + media.ToString("F2", CultureInfo.InvariantCulture));
            }

            // 4: numero de homens
            int contHomens = 0;
            for (int i = 0; i < N; i++) {
                if (sexos[i] == 'M') {
                    contHomens++;
                }
            }
            Console.WriteLine("Numero de homens = " + contHomens);
        }
    }
}
