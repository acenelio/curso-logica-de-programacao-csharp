using System;
using System.Globalization;

namespace uri1009 {
    class Program {
        static void Main(string[] args) {

            string nome;
            double salarioFixo, totalVenda, salarioTotal;

            nome = Console.ReadLine();
            salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            totalVenda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salarioTotal = totalVenda * 15.0 / 100 + salarioFixo;

            Console.WriteLine("TOTAL = R$ " + salarioTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
