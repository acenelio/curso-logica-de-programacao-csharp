using System;

namespace matriz1 {
    class Program {
        static void Main(string[] args) {

            string[] valores = Console.ReadLine().Split(' ');
            int M = int.Parse(valores[0]);
            int N = int.Parse(valores[1]);

            int[,] mat = new int[M, N];

            for (int i = 0; i < M; i++) {
                valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    mat[i, j] = int.Parse(valores[j]);
                }
            }

            Console.WriteLine("VALORES NEGATIVOS:");
            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++) {
                    if (mat[i, j] < 0) {
                        Console.WriteLine(mat[i, j]);
                    }
                }
            }
        }
    }
}
