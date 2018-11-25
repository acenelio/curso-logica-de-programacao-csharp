using System;

namespace uri1115 {
    class Program {
        static void Main(string[] args) {

            string[] line = Console.ReadLine().Split(' ');
            int x = int.Parse(line[0]);
            int y = int.Parse(line[1]);

            while (x != 0 && y != 0) {
                if (x > 0 && y > 0) {
                    Console.WriteLine("primeiro");
                }
                else if (x < 0 && y > 0) {
                    Console.WriteLine("segundo");
                }
                else if (x < 0 && y < 0) {
                    Console.WriteLine("terceiro");
                }
                else {
                    Console.WriteLine("quarto");
                }
                line = Console.ReadLine().Split(' ');
                x = int.Parse(line[0]);
                y = int.Parse(line[1]);
            }
        }
    }
}
