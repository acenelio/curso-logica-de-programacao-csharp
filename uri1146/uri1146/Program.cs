using System;

namespace uri1146 {
    class Program {
        static void Main(string[] args) {

            int x = int.Parse(Console.ReadLine());

            while (x != 0) {

                for (int i = 1; i < x; i++) {
                    Console.Write(i + " ");
                }
                Console.WriteLine(x);

                x = int.Parse(Console.ReadLine());
            }
        }
    }
}
