using System;

namespace vetor2 {
    class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());

            int[] vet = new int[N];

            string[] valores = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++) {
                vet[i] = int.Parse(valores[i]);
            }

            // 1: mostrando os numeros pares
            for (int i = 0; i < N; i++) {
                if (vet[i] % 2 == 0) {
                    Console.Write(vet[i] + " ");
                }
            }
            Console.WriteLine();

            // 2: mostrando a quantidade de pares
            int quantidadeDePares = 0;
            for (int i = 0; i < N; i++) {
                if (vet[i] % 2 == 0) {
                    quantidadeDePares++;
                }
            }
            Console.WriteLine(quantidadeDePares);
        }
    }
}
