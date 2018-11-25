using System;

namespace cond01 {
    class Program {
        static void Main(string[] args) {


            int N = int.Parse(Console.ReadLine());

            if (N < 0) {
                Console.WriteLine("NEGATIVO");
            }
            else {
                Console.WriteLine("NAO NEGATIVO");
            }
        }
    }
}
