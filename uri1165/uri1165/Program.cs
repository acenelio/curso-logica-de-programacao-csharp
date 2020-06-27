using System;

namespace uri1165 {
    class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++) {

                int x = int.Parse(Console.ReadLine());
                int metade = x / 2;

                bool primo = true;

                for (int j = 2; j <= metade; j++) {
                    if (x % j == 0) {
                        primo = false;
                        break;
                    }
                }

                if (primo) {
                    Console.WriteLine(x + " eh primo");
                }
                else {
                    Console.WriteLine(x + " nao eh primo");
                }
            }
        }
    }
}
