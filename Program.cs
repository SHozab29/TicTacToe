using System;

namespace TicTacToe
{
    internal class Program
    {
        static char[,] field =
            {
                {'1','2','3'}, 
                {'4','5','6'}, 
                {'7','8','9'}, 
            };

        static int currentPlayer = 1;
        static bool gameEnd = false;
        static void Main(string[] args)
        {
            
            do
            {
                PlayerField();

                if(currentPlayer == 1)
                {
                    Console.WriteLine("\nPlayer 1 Enter your field");
                }
                else if(currentPlayer == 2)
                {
                    Console.WriteLine("\nPlayer 2 Enter your field");
                }
                
                PlayerInputField(currentPlayer);
                ChangePlayer();
                

                IfWin();
           
            } while (!gameEnd);


        }
        static void PlayerField()
        {
            

            Console.WriteLine("    |     |     ");
            Console.WriteLine("{0}   | {1}   |  {2} ", field[0, 0], field[0, 1], field[0, 2]);

            Console.WriteLine("    |     |     ");
            Console.WriteLine("{0}   | {1}   |  {2} ", field[1, 0], field[1, 1], field[1, 2]);

            Console.WriteLine("    |     |     ");
            Console.WriteLine("{0}   | {1}   |  {2} ", field[2, 0], field[2, 1], field[2, 2]);

        }

        static void PlayerInputField(int player)
        {
            int playerInput=0;
            try
            {
                playerInput = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {

                Console.WriteLine("Player "+currentPlayer+" please enter the correct integer value.");
                PlayerInputField(currentPlayer);
            }
            
            switch (player)
            {
                case 1:
                    switch (playerInput)
                    {
                        case 1:
                            field[0, 0] = 'X';
                            break;

                        case 2:
                            field[0, 1] = 'X';
                            break;

                        case 3:
                            field[0, 2] = 'X';
                            break;

                        case 4:
                            field[1, 0] = 'X';
                            break;

                        case 5:
                            field[1, 1] = 'X';
                            break;

                        case 6:
                            field[1, 2] = 'X';
                            break;

                        case 7:
                            field[2, 0] = 'X';
                            break;

                        case 8:
                            field[2, 1] = 'X';
                            break;

                        case 9:
                            field[2, 2] = 'X';
                            break;

                    }
                    break;


                case 2:
                    switch (playerInput)
                    {
                        case 1:
                            field[0, 0] = 'O';
                            break;

                        case 2:
                            field[0, 1] = 'O';
                            break;

                        case 3:
                            field[0, 2] = 'O';
                            break;

                        case 4:
                            field[1, 0] = 'O';
                            break;

                        case 5:
                            field[1, 1] = 'O';
                            break;

                        case 6:
                            field[1, 2] = 'O';
                            break;

                        case 7:
                            field[2, 0] = 'O';
                            break;

                        case 8:
                            field[2, 1] = 'O';
                            break;

                        case 9:
                            field[2, 2] = 'O';
                            break;

                    }
                    break;
            }


           

            Console.Clear();
        }

        static void IfWin()
        {
            // 00, 01, 02 
            // 10, 11, 12
            // 20, 21, 22


            if (   
                   (field[0, 0] == 'X' && field[0, 1] == 'X' && field[0, 2] == 'X') //horizontal
                || (field[1, 0] == 'X' && field[1, 1] == 'X' && field[1, 2] == 'X') 
                || (field[2, 0] == 'X' && field[2, 1] == 'X' && field[2, 2] == 'X')

                || (field[0, 0] == 'X' && field[1, 0] == 'X' && field[2, 0] == 'X') //vertical
                || (field[0, 1] == 'X' && field[1, 1] == 'X' && field[2, 1] == 'X')
                || (field[0, 2] == 'X' && field[1, 2] == 'X' && field[2, 2] == 'X')

                || (field[0, 0] == 'X' && field[1, 1] == 'X' && field[2, 2] == 'X') //diagonal
                || (field[2, 0] == 'X' && field[1, 1] == 'X' && field[0, 2] == 'X')
                
                )
            {
                currentPlayer = 1;
                Console.WriteLine("Player " + currentPlayer + " Has Won The Game!!");
                gameEnd = true;
            }

            else if(
                   (field[0, 0] == 'O' && field[0, 1] == 'O' && field[0, 2] == 'O') //horizontal
                || (field[1, 0] == 'O' && field[1, 1] == 'O' && field[1, 2] == 'O')
                || (field[2, 0] == 'O' && field[2, 1] == 'O' && field[2, 2] == 'O')

                || (field[0, 0] == 'O' && field[1, 0] == 'O' && field[2, 0] == 'O') //vertical
                || (field[0, 1] == 'O' && field[1, 1] == 'O' && field[2, 1] == 'O')
                || (field[0, 2] == 'O' && field[1, 2] == 'O' && field[2, 2] == 'O')

                || (field[0, 0] == 'O' && field[1, 1] == 'O' && field[2, 2] == 'O') //diagonal
                || (field[2, 0] == 'O' && field[1, 1] == 'O' && field[0, 2] == 'O')
                 
                )
            {
                currentPlayer = 2;
                Console.WriteLine("Player " + currentPlayer + " Has Won The Game!!");
                gameEnd = true;
            }

   
        }
        static int ChangePlayer()
        {
            if (currentPlayer == 2)
            {
                currentPlayer = 1;
            }
            else if (currentPlayer == 1)
            {
                currentPlayer = 2;
            }
            return currentPlayer;
        }

    }
}
