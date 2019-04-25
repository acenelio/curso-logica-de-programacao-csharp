using System;

namespace uri1070 {
    class Program {
        static void Main(string[] args) {

            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0) {
                x = x + 1;
            }

            Console.WriteLine(x);
            Console.WriteLine(x + 2);
            Console.WriteLine(x + 4);
            Console.WriteLine(x + 6);
            Console.WriteLine(x + 8);
            Console.WriteLine(x + 10);
        }
    }
}
