using System;

namespace uri1046 {
    class Program {
        static void Main(string[] args) {

            string[] line = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(line[0]);
            int horaFinal = int.Parse(line[1]);

            int duracao;
            if (horaInicial < horaFinal) {
                duracao = horaFinal - horaInicial;
            }
            else {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}
