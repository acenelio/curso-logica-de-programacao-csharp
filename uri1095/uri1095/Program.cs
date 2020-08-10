using System;

namespace uri1095 {
    class Program {
        static void Main(string[] args) {

            int i = 1;
            for (int j = 60; j >= 0; j = j - 5) {
                Console.WriteLine("I=" + i + " J=" + j);
                i = i + 3;
            }
        }
    }
}
