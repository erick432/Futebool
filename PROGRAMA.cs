using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjFutebol_01
{
    class Program
    {
        static void Main(string[] args)
        {

            int opc;
            do
            {

                Console.WriteLine("Selecione uma das opções: ");
                Console.WriteLine(" 1 - Atribuir partida ");
                Console.WriteLine(" 2 - Sair ");

                opc = Convert.ToInt32(Console.ReadLine());
                Console.Clear();


                do
                {
                    switch (opc)
                    {
                        case 1:


                            Console.Write("\n ------Atribuindo Partida------");
                            Console.Write("\n Digite o nome do primeiro time: ");
                            string ttime1 = System.Console.ReadLine();

                            Console.Write("\n Digite o nome do segundo time: ");
                            string ttime2 = System.Console.ReadLine();

                            Time Time1 = new Time(ttime1, ttime2);
                            Time Time2 = new Time(ttime2, ttime1);

                            Partida Partida = new Partida(DateTime.Now, Time1, Time2);
                            Console.Clear();

                            Console.Write("\n ------RESULTADO------");
                            Partida.jogar();

                            Console.WriteLine(Partida.getPlacar());
                            Console.WriteLine(Time1.getStatus());
                            Console.WriteLine(Time2.getStatus());

                            Console.WriteLine("\n Deseja conferir quais eram os jogadores da partida? [S/N] : ");
                            string Escalacao = System.Console.ReadLine();
                            Console.Clear();

                            switch (Escalacao)
                            {

                                case "S":
                                    
                                    Time1.contratarJogadores(new Jogador("Alex", 20, 99, 1));
                                    Time1.contratarJogadores(new Jogador("Pedro", 22, 96, 2));
                                    Time1.contratarJogadores(new Jogador("Leandro", 37, 91, 3));
                                    Time1.contratarJogadores(new Jogador("Bruno", 21, 90, 4));
                                    Time1.contratarJogadores(new Jogador("Jorge", 23, 92, 5));
                                    Time1.contratarJogadores(new Jogador("Eleno", 30, 97, 6));
                                    Time1.contratarJogadores(new Jogador("Rodrigo", 33, 80, 7));
                                    Time1.contratarJogadores(new Jogador("Antonio", 29, 88, 8));
                                    Time1.contratarJogadores(new Jogador("Migel", 25, 79, 9));
                                    Time1.contratarJogadores(new Jogador("Luciano", 28, 90, 10));
                                    Time1.contratarJogadores(new Jogador("Alencar", 38, 95, 11));
                                    Console.WriteLine("\n Jogadores Escalados - " + ttime1);
                           
                                    Time1.getDescricaoJogadores();
                                    Time2.contratarJogadores(new Jogador("Juliano", 20, 99, 1));
                                    Time2.contratarJogadores(new Jogador("Matias", 22, 96, 2));
                                    Time2.contratarJogadores(new Jogador("Roberto", 27, 91, 3));
                                    Time2.contratarJogadores(new Jogador("Carlos", 21, 90, 4));
                                    Time2.contratarJogadores(new Jogador("Renato", 23, 92, 5));
                                    Time2.contratarJogadores(new Jogador("Fabiano", 30, 97, 6));
                                    Time2.contratarJogadores(new Jogador("Regis", 33, 80, 7));
                                    Time2.contratarJogadores(new Jogador("Otavio", 29, 88, 8));
                                    Time2.contratarJogadores(new Jogador("Marcio", 25, 79, 9));
                                    Time2.contratarJogadores(new Jogador("Wilson", 28, 90, 10));
                                    Time2.contratarJogadores(new Jogador("Marcos", 38, 95, 11));
                                    Console.WriteLine("\n Jogadores Escalados - " + ttime2);
                                    Time2.getDescricaoJogadores();
                                    Console.Write("\n ---Pressione qualquer tecla para continuar---");
                                    Console.ReadKey();
                                    break;


                                case "N":
                                    Console.Write("\n   [ < Voltar]");
                                    Console.ReadKey();
                                    break;
                            }
                            break;


                        case 2:
                            break;
                    }
                    break;


                } while (opc != 2);
                Console.Clear();


            } while (opc != 2);
        }
    }
}