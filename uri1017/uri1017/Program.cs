using System;
using System.Globalization;

namespace uri1017 {
    class Program {
        static void Main(string[] args) {

            int tempo, velocidade, distancia;
            double litros;

            tempo = int.Parse(Console.ReadLine());
            velocidade = int.Parse(Console.ReadLine());

            distancia = tempo * velocidade;

            // aqui eh importante colocar o .0 depois do 12, ou entao fazer o casting (double)
            litros = distancia / 12.0;

            Console.WriteLine(litros.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
