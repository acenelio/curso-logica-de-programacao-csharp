using System;

namespace uri1094 {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            int coelhos = 0;
            int ratos = 0;
            int sapos = 0;

            for (int i = 0; i < n; i++) {

                string[] valores = Console.ReadLine().Split(' ');
                int quantia = int.Parse(valores[0]);
                char tipo = char.Parse(valores[1]);

                if (tipo == 'C') {
                    coelhos = coelhos + quantia;
                }
                else if (tipo == 'R') {
                    ratos = ratos + quantia;
                }
                else {
                    sapos = sapos + quantia;
                }
            }

            int total = coelhos + ratos + sapos;
            double porcentagemCoelhos = (double)coelhos / total * 100.0;
            double porcentagemRatos = (double)ratos / total * 100.0;
            double porcentagemSapos = (double)sapos / total * 100.0;

            Console.WriteLine("Total: " + total + " cobaias");
            Console.WriteLine("Total de coelhos: " + coelhos);
            Console.WriteLine("Total de ratos: " + ratos);
            Console.WriteLine("Total de sapos: " + sapos);
            Console.WriteLine("Percentual de coelhos: " + porcentagemCoelhos.ToString("F2") + " %");
            Console.WriteLine("Percentual de ratos: " + porcentagemRatos.ToString("F2") + " %");
            Console.WriteLine("Percentual de sapos: " + porcentagemSapos.ToString("F2") + " %");
        }
    }
}
