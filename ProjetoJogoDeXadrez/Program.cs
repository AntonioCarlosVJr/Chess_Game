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

                    try
                    {

                        Console.Clear();
                        Tela.imprimirPartida(partida);
                        
                        Console.WriteLine();
                        



                        Console.WriteLine("   ");

                        Console.Write("Origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                        partida.validarPosicaoDeOrigem(origem);
                      

                        bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();



                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

                        Console.WriteLine("   ");
                        Console.Write("Destino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeDestino(origem, destino);





                        partida.realizaJogada(origem, destino);

                    } catch (TabuleiroException ex) { 
                     
                        Console.WriteLine(ex.Message);
                        Console.ReadKey();
                        

                    }

                }




            }
            catch (TabuleiroException e) {

                Console.WriteLine(e);
            
            }


            Console.WriteLine();

        }



    }




}