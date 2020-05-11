using System;

namespace uri1160 {
    class URI {
        static void Main(string[] args)
        {
            int T, PA, PB, crescA, crescB, anos;
            double G1, G2;
            string[] vet;

            T = int.Parse(Console.ReadLine());

            for (int i = 1; i <= T; i++) {
                vet = Console.ReadLine().Split(' ');
                PA = int.Parse(vet[0]);
                PB = int.Parse(vet[1]);
                G1 = double.Parse(vet[2]);
                G2 = double.Parse(vet[3]);

                crescA = PA;
                crescB = PB;

                anos = 0;
                while (crescA <= crescB) {
                    crescA += (int)(crescA * (G1 / 100));
                    crescB += (int)(crescB * (G2 / 100));
                    anos += 1;
                }

                if (anos > 100) {
                    Console.WriteLine("Mais de 1 seculo.");
                }
                else {
                    Console.WriteLine(anos + " anos.");
                }
            }
        }
    }
}
