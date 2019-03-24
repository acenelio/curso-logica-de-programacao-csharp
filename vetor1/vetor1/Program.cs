using System;
using System.Globalization;

namespace vetor1 {
    class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());

            double[] vet = new double[N];

            string[] valores = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++) {
                vet[i] = double.Parse(valores[i], CultureInfo.InvariantCulture);
            }

            double maior = vet[0];
            int posicaoMaior = 0;

            for (int i = 1; i < N; i++) {
                if (vet[i] > maior) {
                    maior = vet[i];
                    posicaoMaior = i;
                }
            }

            Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(posicaoMaior);
        }
    }
}
