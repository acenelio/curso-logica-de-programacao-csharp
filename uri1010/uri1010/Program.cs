using System;
using System.Globalization;

namespace uri1010 {
    class Program {
        static void Main(string[] args) {

            int cod1, cod2, qte1, qte2;
            double preco1, preco2, total;

            string[] vect = Console.ReadLine().Split(' ');
            cod1 = int.Parse(vect[0]);
            qte1 = int.Parse(vect[1]);
            preco1 = double.Parse(vect[2], CultureInfo.InvariantCulture);

            vect = Console.ReadLine().Split(' ');
            cod2 = int.Parse(vect[0]);
            qte2 = int.Parse(vect[1]);
            preco2 = double.Parse(vect[2], CultureInfo.InvariantCulture);

            total = preco1 * qte1 + preco2 * qte2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
