using System;

namespace uri1044 {
    class Program {
        static void Main(string[] args) {

            string[] line = Console.ReadLine().Split(' ');
            int A = int.Parse(line[0]);
            int B = int.Parse(line[1]);

            if (A % B == 0 || B % A == 0) {
                Console.WriteLine("Sao Multiplos");
            }
            else {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
