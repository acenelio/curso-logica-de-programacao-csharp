using System;
using System.Globalization;

namespace uri1116 {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {

                string[] line = Console.ReadLine().Split(' ');
                int x = int.Parse(line[0]);
                int y = int.Parse(line[1]);

                if (y == 0) {
                    Console.WriteLine("divisao impossivel");
                }
                else {
                    double div = (double)x / y;
                    Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture);
                }
            }
        }
    }
}
