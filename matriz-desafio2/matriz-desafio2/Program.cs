using System;

namespace matriz_desafio2 {
    class Program {
        static void Main(string[] args) {

            int n = 8;
            char[,] input = new char[n, n];
            bool[,] output = new bool[n, n];

            for (int i = 0; i < n; i++) {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    input[i, j] = char.Parse(valores[j]);
                }
            }

            // encontrando a posicao da torre
            int torreX = 0, torreY = 0;
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (input[i, j] == 'T') {
                        torreX = i;
                        torreY = j;
                    }
                }
            }

            // verificando acima
            int x = torreX;
            int y = torreY - 1;
            while (y >= 0 && input[x, y] == '-') {
                output[x, y] = true;
                y = y - 1;
            }
            if (y >= 0 && input[x, y] == 'P') {
                output[x, y] = true;
            }

            // verificando abaixo
            x = torreX;
            y = torreY + 1;
            while (y < n && input[x, y] == '-') {
                output[x, y] = true;
                y = y + 1;
            }
            if (y < n && input[x, y] == 'P') {
                output[x, y] = true;
            }

            // verificando a esquerda
            x = torreX - 1;
            y = torreY;
            while (x >= 0 && input[x, y] == '-') {
                output[x, y] = true;
                x = x - 1;
            }
            if (x >= 0 && input[x, y] == 'P') {
                output[x, y] = true;
            }

            // verificando a direita
            x = torreX + 1;
            y = torreY;
            while (x < n && input[x, y] == '-') {
                output[x, y] = true;
                x = x + 1;
            }
            if (x < n && input[x, y] == 'P') {
                output[x, y] = true;
            }

            // imprimindo a saida
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (output[i, j]) {
                        Console.Write("x ");
                    }
                    else {
                        Console.Write("- ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
