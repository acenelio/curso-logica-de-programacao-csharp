using System;

namespace uri1061 {
    class Program {
        static void Main(string[] args) {

            int W1, X1, Y1, Z1, W2, X2, Y2, Z2, W, X, Y, Z, inicio, fim, duracao, resto;

            // Ler a primeira linha, armazenando o valor de W (dia)
            string[] valores = Console.ReadLine().Split(' ');
            W1 = int.Parse(valores[1]);

            // Ler a segunda linha, armazenando o valor de X (hora), Y (minuto), Z (segundo)
            valores = Console.ReadLine().Split(' ');
            X1 = int.Parse(valores[0]);
            Y1 = int.Parse(valores[2]);
            Z1 = int.Parse(valores[4]);

            // Ler a terceira linha, armazenando o valor de W (dia)
            valores = Console.ReadLine().Split(' ');
            W2 = int.Parse(valores[1]);

            // Ler a segunda linha, armazenando o valor de X (hora), Y (minuto), Z (segundo)
            valores = Console.ReadLine().Split(' ');
            X2 = int.Parse(valores[0]);
            Y2 = int.Parse(valores[2]);
            Z2 = int.Parse(valores[4]);

            // Calculando o valor do inicio e fim, convertendo tudo para segundos
            inicio = (W1 - 1) * 24 * 60 * 60 + X1 * 60 * 60 + Y1 * 60 + Z1;
            fim = (W2 - 1) * 24 * 60 * 60 + X2 * 60 * 60 + Y2 * 60 + Z2;
            
            // Calculando a duracao em segundos
            duracao = fim - inicio;

            // Agora vamos desmembrar a duracao em segundos para dia (W), hora (X), minutos (Y) e segundos (Z) restantes
            W = duracao / (24 * 60 * 60);
            resto = duracao % (24 * 60 * 60);
            X = resto / (60 * 60);
            resto = resto % (60 * 60);
            Y = resto / 60;
            Z = resto % 60;

            Console.WriteLine(W + " dia(s)");
            Console.WriteLine(X + " hora(s)");
            Console.WriteLine(Y + " minuto(s)");
            Console.WriteLine(Z + " segundo(s)");
        }
    }
}
