using System;

namespace uri1146 {
    class Program {
        static void Main(string[] args) {

            int x = int.Parse(Console.ReadLine());

            while (x != 0) {
                string s = "";
                for (int i = 1; i < x; i++) {
                    s = s + i + " ";
                }
                s = s + x;
                Console.WriteLine(s);

                x = int.Parse(Console.ReadLine());
            }
        }
    }
}
