using System;

namespace matriz5 {
    class Program {
        static void Main(string[] args) {

            string[] valores = Console.ReadLine().Split(' ');
            int M = int.Parse(valores[0]);
            int N = int.Parse(valores[1]);

            int[,] A = new int[M, N];
            int[,] B = new int[M, N];
            int[,] C = new int[M, N];

            // leitura da matriz A
            for (int i = 0; i < M; i++) {
                valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    A[i, j] = int.Parse(valores[j]);
                }
            }

            // leitura da matriz B
            for (int i = 0; i < M; i++) {
                valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    B[i, j] = int.Parse(valores[j]);
                }
            }

            // geracao da matriz C
            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++) {
                    C[i, j] = A[i, j] + B[i, j];
                }
            }

            // impressao da matriz C na tela
            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++) {
                    Console.Write(C[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
