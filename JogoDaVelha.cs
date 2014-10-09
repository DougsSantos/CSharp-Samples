using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JogoDaVelha
{
    class Program
    {
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };        
        static int player = 1;
        static int escolha;
        static int flag = 0;

        static void Main(string[] args)
        {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Player1:X e Player2:O");
                    Console.WriteLine("\n");

                    if (player % 2 == 0)
                    {
                        Console.WriteLine("Vez do Player 2");
                    }

                    else
                    {
                        Console.WriteLine("Vez do Player 1");
                    }

                    Console.WriteLine("\n");
                    tabuleiro();
                    escolha = int.Parse(Console.ReadLine());

                    if (arr[escolha] != 'X' && arr[escolha] != 'O')
                    {
                        if (player % 2 == 0)
                        {
                            arr[escolha] = 'O';
                            player++;
                        }
                        else
                        {
                            arr[escolha] = 'X';
                            player++;
                        }
                    }

                    else
                    {
                        Console.WriteLine("Desculpe a posição {0}ja esta marcada com um {1}", escolha, arr[escolha]);
                        Console.WriteLine("\n");
                        Console.WriteLine("Espere..");
                        Thread.Sleep(2000);
                    }
                    flag = vitoria();
                }

                while (flag != 1 && flag != -1);

                Console.Clear();
                tabuleiro();

                if (flag == 1)
                {
                    Console.WriteLine("Player {0} Ganhou", (player % 2) + 1);
                }

                else
                {
                    Console.WriteLine("EMPATE");
                }

                Console.ReadLine();

                flag = vitoria();

                } 


        

        private static int vitoria(){

            if (arr[1] == arr[2] && arr[2] == arr[3]){
                return 1;
            }
            
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                return 1;
            }
            
            else if (arr[6] == arr[7] && arr[7] == arr[8])
            {
                return 1;
            }
            
            else if (arr[1] == arr[4] && arr[4] == arr[7]){
                return 1;
            }
            
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }
            
            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                return 1;
            }

            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return 1;
            }

            else if (arr[3] == arr[5] && arr[5] == arr[7])

            {
                return 1;
            }

            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
            {
                return -1;
            }

            else
            {
                return 0;
            }


        }

        public static void tabuleiro()
        {

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);

            Console.WriteLine("     |     |      ");
        }
    }

}






