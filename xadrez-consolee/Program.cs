using System;
using tabuleiro;
using xadrez;

namespace xadrez_consolee
{
    public class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());

            Console.ReadLine();

        }
    }
}
