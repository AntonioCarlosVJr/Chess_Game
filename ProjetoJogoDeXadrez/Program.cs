using System;
using System.Threading.Channels;
using ProjetoJogoDeXadrez;
using tabuleiro;
using xadrez;

namespace Jogo_Xadrex
{

    class Program
    {

        static void Main(string[] args)
        {
            /* 243 - aulas  */


            try
            {
                
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(3, 5));
                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(3, 3));
                tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(3, 4));





                Tela.imprimirTabuleiro(tab);
               
            }
            catch (TabuleiroException e) {

                Console.WriteLine(e);
            
            }


            Console.WriteLine();

        }



    }




}