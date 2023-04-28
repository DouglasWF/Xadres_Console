using System;
using System.Threading.Channels;
using tabuleiro;
using xadrez;

namespace Xadrez_Console
{
    class Programa
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

               while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPsicao();
                    Console.Write("Desino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPsicao();

                    partida.executaMovimento(origem, destino);
                }                   
                
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
