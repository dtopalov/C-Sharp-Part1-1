using System;
using System.Net.Configuration;

namespace Warhead
{
    class Warhead
    {
        static void Main(string[] args)
        {
            int[,] board = new int[16,16];
            string command = "";
            int commandRow, commandCol;
            bool gameOver = false;
            for (int i = 0; i < 16; i++)
            {
                string row = Console.ReadLine();
                
                for (int j = 0; j < 16; j++)
                {
                    board[i, j] = int.Parse(row[j].ToString());
                }
            }
            
            
            while (gameOver == false)
            {
                int bombsLeft = 0;
                int bombsRight = 0;
                for (int i = 1; i < 15; i++)
                {
                    for (int j = 1; j < 15; j++)
                    {
                        if (j <= 7)
                        {
                            if (board[i, j] == 0 && board[i - 1, j - 1] == 1 && board[i - 1, j] == 1 && board[i + 1, j - 1] == 1 &&
                                board[i, j - 1] == 1 && board[i, j + 1] == 1 && board[i + 1, j - 1] == 1 && board[i + 1, j] == 1 && board[i + 1, j + 1] == 1)
                            {
                                bombsLeft++;
                            }
                        }
                        else
                        {
                            if (board[i, j] == 0 && board[i - 1, j - 1] == 1 && board[i - 1, j] == 1 && board[i + 1, j - 1] == 1 &&
                                board[i, j - 1] == 1 && board[i, j + 1] == 1 && board[i + 1, j - 1] == 1 && board[i + 1, j] == 1 && board[i + 1, j + 1] == 1)
                            {
                                bombsRight++;
                            }
                        }
                    }
                }
                command = Console.ReadLine();
                switch (command)
                {
                    case "hover":
                        commandRow = int.Parse(Console.ReadLine());
                        commandCol = int.Parse(Console.ReadLine());
                        if (board[commandRow, commandCol] == 1)
                        {
                            Console.WriteLine("*");
                        }
                        else
                        {
                            Console.WriteLine("-");
                        }
                        break;
                    case "operate":
                        commandRow = int.Parse(Console.ReadLine());
                        commandCol = int.Parse(Console.ReadLine());
                        if (board[commandRow, commandCol] == 0)
                        {
                            if (commandRow > 0 && commandCol > 0 && commandRow < 15 && commandCol < 15)
                            {
                                if (board[commandRow, commandCol] == 0 && board[commandRow - 1, commandCol - 1] == 1 &&
                                    board[commandRow - 1, commandCol] == 1 && board[commandRow + 1, commandCol - 1] == 1 &&
                                    board[commandRow, commandCol - 1] == 1 && board[commandRow, commandCol + 1] == 1 &&
                                    board[commandRow + 1, commandCol - 1] == 1 && board[commandRow + 1, commandCol] == 1 &&
                                    board[commandRow + 1, commandCol + 1] == 1)
                                {
                                    board[commandRow - 1, commandCol - 1] = 0;
                                    board[commandRow - 1, commandCol] = 0;
                                    board[commandRow + 1, commandCol - 1] = 0;
                                    board[commandRow, commandCol - 1] = 0;
                                    board[commandRow, commandCol + 1] = 0;
                                    board[commandRow + 1, commandCol - 1] = 0;
                                    board[commandRow + 1, commandCol] = 0;
                                    board[commandRow + 1, commandCol + 1] = 0;

                                    if (commandCol <= 7)
                                    {
                                        bombsLeft--;
                                    }
                                    else
                                    {
                                        bombsRight--;
                                    }
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        
                        if (board[commandRow, commandCol] == 1)
                        {
                            Console.WriteLine("missed");
                            Console.WriteLine(bombsLeft + bombsRight);
                            Console.WriteLine("BOOM");
                            gameOver = true;
                        }
                        break;
                    case "cut":
                        string wire = Console.ReadLine();
                        if (wire == "red")
                        {
                            if (bombsLeft > 0)
                            {
                                Console.WriteLine(bombsLeft);
                                Console.WriteLine("BOOM");
                                gameOver = true;
                            }
                            else
                            {
                                Console.WriteLine(bombsRight);
                                Console.WriteLine("disarmed");
                                gameOver = true;
                            }
                        }
                        else
                        {
                            if (bombsRight > 0)
                            {
                                Console.WriteLine(bombsRight);
                                Console.WriteLine("BOOM");
                                gameOver = true;
                            }
                            else
                            {
                                Console.WriteLine(bombsLeft);
                                Console.WriteLine("disarmed");
                                gameOver = true;
                            }
                        }
                        break;
                }
            }
        }
    }
}
