using System;
using tabuleiro;
using xadrez;

namespace Xadrez_Console
{
    class Programa
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);
            Console.WriteLine(pos);

            Console.WriteLine(pos.toPsicao());
            Console.ReadLine();
        }
    }
}
