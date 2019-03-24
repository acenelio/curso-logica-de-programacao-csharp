using System;

namespace uri1144 {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {

                int segundo = i * i;
                int terceiro = i * i * i;
                Console.WriteLine(i + " " + segundo + " " + terceiro);
                Console.WriteLine(i + " " + (segundo + 1) + " " + (terceiro + 1));
            }
        }
    }
}
