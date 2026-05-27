using System;
using ProjetoJogoDeXadrez;
using tabuleiro;
using xadrez;

namespace Jogo_Xadrex
{

    class Program
    {

        static void Main(string[] args)
        {



            PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());


            /*
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));


            Tela.imprimirTabuleiro(tab);
            */



            Console.WriteLine();

        }



    }




}