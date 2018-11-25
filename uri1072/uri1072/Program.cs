using System;

namespace uri1072 {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            int cont_in = 0;
            int cont_out = 0;

            for (int i = 0; i < n; i++) {
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20) {
                    cont_in = cont_in + 1;
                }
                else {
                    cont_out = cont_out + 1;
                }
            }

            Console.WriteLine(cont_in + " in");
            Console.WriteLine(cont_out + " out");
        }
    }
}
