using System;
using ProjetoJogoDeXadrez;
using tabuleiro;

namespace Jogo_Xadrex
{

    class Program
    {

        static void Main(string[] args)
        {


            Tabuleiro tab = new Tabuleiro(8, 8);

            Tela.imprimirTabuleiro(tab);




            Console.WriteLine();

        }



    }




}