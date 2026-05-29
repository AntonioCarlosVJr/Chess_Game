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
                
               PartidaDeXadrez partida = new PartidaDeXadrez();

              

                while (!partida.terminada)
                {

                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine("   ");

                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();


                    partida.executaMovimento(origem, destino);


                }




            }
            catch (TabuleiroException e) {

                Console.WriteLine(e);
            
            }


            Console.WriteLine();

        }



    }




}