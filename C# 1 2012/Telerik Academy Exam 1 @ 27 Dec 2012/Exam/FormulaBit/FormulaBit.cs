using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaBit
{
    class FormulaBit
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[8,8];
            int curRow = 0;
            int curCol = 7;
            string direction = "down";
            int countPath = 1;
            int countTurns = 0;
            bool up = true;
            for (int i = 0; i < 8; i++)
            {
                int input = int.Parse(Console.ReadLine());
                string inputBin = Convert.ToString(input, 2);
                string inputBin1 = inputBin.PadLeft(8, '0');
                for (int j = 0; j < 8; j++)
                {
                    matrix[i, j] = int.Parse(inputBin1[j].ToString());
                }
            }
            if (matrix[0, 7] == 1)
            {
                Console.WriteLine("No 0");
            }
            else
            {
                while (matrix[curRow, curCol] == 0 && curRow >= 0 && curRow < 8 && curCol >= 0 && curCol < 8)
                {
                    switch (direction)
                    {
                        case "down":
                            curRow++;
                            countPath++;
                            break;
                        case "left":
                            curCol--;
                            countPath++;
                            break;
                        case "up":
                            curRow--;
                            countPath++;
                            break;
                    }
                    if (direction == "down" && (curRow == 7 || matrix[curRow + 1, curCol] == 1))
                    {
                        direction = "left";
                        if (curCol > 0 && matrix[curRow, curCol - 1] == 0)
                        {
                            countTurns++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (direction == "up" && (curRow == 0 || matrix[curRow - 1, curCol] == 1))
                    {
                        direction = "left";
                        if (curCol > 0 && matrix[curRow, curCol - 1] == 0)
                        {
                            countTurns++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (direction == "left" && (curCol == 0 || matrix[curRow, curCol - 1] == 1))
                    {
                        if (curCol == 0 && curRow == 7)
                        {
                            break;
                        }
                        if (up)
                        {
                            direction = "up";
                            up = false;
                            if (curRow > 0 && matrix[curRow - 1, curCol] == 0)
                            {
                                countTurns++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        else
                        {
                            direction = "down";
                            up = true;
                            if (curRow < 7 && matrix[curRow + 1, curCol] == 0)
                            {
                                countTurns++;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
                if (curRow == 7 && curCol == 0)
                {
                    Console.WriteLine("{0} {1}", countPath, countTurns);
                }
                else
                {
                    Console.WriteLine("No {0}", countPath);
                }
            }
        }
    }
}
