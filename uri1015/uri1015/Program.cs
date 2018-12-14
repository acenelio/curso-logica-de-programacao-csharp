using System;
using System.Globalization;

namespace uri1015 {
    class Program {
        static void Main(string[] args) {

            string[] linha = Console.ReadLine().Split(' ');
            double x1 = double.Parse(linha[0], CultureInfo.InvariantCulture);
            double y1 = double.Parse(linha[1], CultureInfo.InvariantCulture);

            linha = Console.ReadLine().Split(' ');
            double x2 = double.Parse(linha[0], CultureInfo.InvariantCulture);
            double y2 = double.Parse(linha[1], CultureInfo.InvariantCulture);

            double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0));

            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
