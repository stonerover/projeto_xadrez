using Exceptions;
using System;
using tabuleiro;
using xadrez;

namespace Projeto_Xadrez
{
    internal class Program
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
