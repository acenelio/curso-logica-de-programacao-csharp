using System;

namespace vetor6 {
    class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());

            String[] nomes = new String[N];
            int[] idades = new int[N];

            for (int i = 0; i < N; i++) {
                string[] valores = Console.ReadLine().Split(' ');
                nomes[i] = valores[0];
                idades[i] = int.Parse(valores[1]);
            }

            // 1: primeiro vamos encontrar a posicao da maior idade
            int maiorIdade = idades[0];
            int posicaoMaiorIdade = 0;

            for (int i = 1; i < N; i++) {
                if (idades[i] > maiorIdade) {
                    maiorIdade = idades[i];
                    posicaoMaiorIdade = i;
                }
            }

            // 2: agora vamos acessar o vetor de nomes na posicao da maior idade
            Console.WriteLine("Pessoa mais velha: " + nomes[posicaoMaiorIdade]);
        }
    }
}
