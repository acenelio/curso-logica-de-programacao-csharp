using System;

namespace matriz7 {
    class Program {
        static void Main(string[] args) {

            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());

            int[,] mat = new int[M,N];

            // leitura dos dados de entrada
            for (int i = 0; i < M; i++) {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    mat[i, j] = int.Parse(valores[j]);
                }
            }

            int fila = int.Parse(Console.ReadLine());

            // como nossa matriz comeca na linha 0, vamos decrementar o valor da fila
            fila = fila - 1;

            // passo 1: vamos salvar o ultimo da fila escolhida
            int ultimoDaFila = mat[fila, N - 1];

            // passo 2: vamos mover todos da fila (menos o ultimo) para a direita,
            // mas teremos que fazer isso da direita para a esquerda (contagem decrescente)
            for (int j = N - 1; j > 0; j--) {
                mat[fila, j] = mat[fila, j - 1];
            }

            // passo 3: agora vamos armazenar o ultimo na primeira posicao da fila
            mat[fila, 0] = ultimoDaFila;

            // pronto! Agora vamos imprimir a matriz alterada:
            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++) {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
