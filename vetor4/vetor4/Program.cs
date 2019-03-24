using System;
using System.Globalization;

namespace vetor4 {
    class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());

            double[] vet = new double[N];

            string[] valores = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++) {
                vet[i] = double.Parse(valores[i], CultureInfo.InvariantCulture);
            }

            // 1: calculando e mostrando a media
            double soma = 0.0;
            for (int i = 0; i < N; i++) {
                soma = soma + vet[i];
            }
            double media = soma / N;
            Console.WriteLine("MEDIA = " + media.ToString("F3", CultureInfo.InvariantCulture));

            // 2: mostrando todos elementos abaixo da media
            for (int i = 0; i < N; i++) {
                if (vet[i] < media) {
                    Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
