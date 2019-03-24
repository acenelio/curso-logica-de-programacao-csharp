using System;

namespace uri1145 {
    class Program {
        static void Main(string[] args) {

            string[] valores = Console.ReadLine().Split(' ');
            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);

            for (int i = 1; i <= y; i++) {
                Console.Write(i);
                if (i % x == 0) {
                    Console.WriteLine();
                }
                else {
                    Console.Write(" ");
                }
            }
        }
    }
}
