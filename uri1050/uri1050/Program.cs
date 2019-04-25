using System;

namespace uri1050 {
    class Program {
        static void Main(string[] args) {

            int ddd = int.Parse(Console.ReadLine());

            if (ddd == 61) {
                Console.WriteLine("Brasilia");
            }
            else if (ddd == 71) {
                Console.WriteLine("Salvador");
            }
            else if (ddd == 11) {
                Console.WriteLine("Sao Paulo");
            }
            else if (ddd == 21) {
                Console.WriteLine("Rio de Janeiro");
            }
            else if (ddd == 32) {
                Console.WriteLine("Juiz de Fora");
            }
            else if (ddd == 19) {
                Console.WriteLine("Campinas");
            }
            else if (ddd == 27) {
                Console.WriteLine("Vitoria");
            }
            else if (ddd == 31) {
                Console.WriteLine("Belo Horizonte");
            }
            else {
                Console.WriteLine("DDD nao cadastrado");
            }
        }
    }
}
