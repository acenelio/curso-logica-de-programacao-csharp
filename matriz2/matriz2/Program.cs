using System;

namespace matriz2 {
    class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());

            int[,] mat = new int[N, N];

            for (int i = 0; i < N; i++) {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    mat[i, j] = int.Parse(valores[j]);
                }
            }

            for (int i = 0; i < N; i++) {
                int soma = 0;
                for (int j = 0; j < N; j++) {
                    soma = soma + mat[i, j];
                }
                Console.WriteLine(soma);
            }
        }
    }
}
