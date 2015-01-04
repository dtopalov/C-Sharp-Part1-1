using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngryBits
{
    class AngryBits
    {
        static void Main(string[] args)
        {
            int[,] grid = new int[8,16];
            int score = 0;
            int flight = 0;
            int pigs = 0;
            bool win = true;
            int curRow = 0;
            int curCol = 0;
            string direction = "up";
            for (int i = 0; i < 8; i++)
            {
                int input = int.Parse(Console.ReadLine());
                string inputStr = Convert.ToString(input, 2).PadLeft(16, '0');
                for (int j = 0; j < 16; j++)
                {
                    grid[i, j] = int.Parse(inputStr[j].ToString());
                }
            }
            for (int i = 7; i >= 0; i--)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (grid[j, i] == 1)
                    {
                        grid[j, i] = 0;
                        direction = "up";
                        flight = 0;
                        pigs = 0;
                        curRow = j;
                        curCol = i;
                        while (grid[curRow, curCol] == 0)
                        {
                            if (curRow == 0)
                            {
                                direction = "down";
                            }
                            switch (direction)
                            {
                                case "up":
                                    curRow--;
                                    curCol++;
                                    flight++;
                                    break;
                                case "down":
                                    curRow++;
                                    curCol++;
                                    flight++;
                                    break;
                            }
                            if (curRow == 7 || curCol == 15)
                            {
                                break;
                            }
                        }
                        if (grid[curRow, curCol] == 1)
                        {
                            grid[curRow, curCol] = 0;
                            pigs++;
                            if (curRow > 0 && curRow < 7 && curCol > 8 && curCol < 15)
                            {
                                if (grid[curRow - 1, curCol - 1] == 1)
                                {
                                    grid[curRow - 1, curCol - 1] = 0;
                                    pigs++;
                                }
                                if (grid[curRow - 1, curCol] == 1)
                                {
                                    grid[curRow - 1, curCol] = 0;
                                    pigs++;
                                }
                                if (grid[curRow - 1, curCol + 1] == 1)
                                {
                                    grid[curRow - 1, curCol + 1] = 0;
                                    pigs++;
                                }
                                if (grid[curRow, curCol - 1] == 1)
                                {
                                    grid[curRow, curCol - 1] = 0;
                                    pigs++;
                                }
                                if (grid[curRow, curCol + 1] == 1)
                                {
                                    grid[curRow, curCol + 1] = 0;
                                    pigs++;
                                }
                                if (grid[curRow + 1, curCol - 1] == 1)
                                {
                                    grid[curRow + 1, curCol - 1] = 0;
                                    pigs++;
                                }
                                if (grid[curRow + 1, curCol] == 1)
                                {
                                    grid[curRow + 1, curCol] = 0;
                                    pigs++;
                                }
                                if (grid[curRow + 1, curCol + 1] == 1)
                                {
                                    grid[curRow + 1, curCol + 1] = 0;
                                    pigs++;
                                }
                            }
                            else if (curRow == 0)
                            {
                                if (curCol == 8)
                                {
                                    if (grid[curRow, curCol + 1] == 1)
                                    {
                                        grid[curRow, curCol + 1] = 0;
                                        pigs++;
                                    }
                                    if (grid[curRow + 1, curCol + 1] == 1)
                                    {
                                        grid[curRow + 1, curCol + 1] = 0;
                                        pigs++;
                                    }
                                    if (grid[curRow + 1, curCol] == 1)
                                    {
                                        grid[curRow + 1, curCol] = 0;
                                        pigs++;
                                    }
                                }
                                else if (curCol > 8 && curCol < 15)
                                {
                                    if (grid[curRow, curCol + 1] == 1)
                                    {
                                        grid[curRow, curCol + 1] = 0;
                                        pigs++;
                                    }
                                    if (grid[curRow + 1, curCol + 1] == 1)
                                    {
                                        grid[curRow + 1, curCol + 1] = 0;
                                        pigs++;
                                    }
                                    if (grid[curRow + 1, curCol] == 1)
                                    {
                                        grid[curRow + 1, curCol] = 0;
                                        pigs++;
                                    }
                                    if (grid[curRow, curCol - 1] == 1)
                                    {
                                        grid[curRow, curCol - 1] = 0;
                                        pigs++;
                                    }
                                    if (grid[curRow + 1, curCol - 1] == 1)
                                    {
                                        grid[curRow + 1, curCol - 1] = 0;
                                        pigs++;
                                    }
                                }
                                if (curCol == 15)
                                {
                                    if (grid[curRow, curCol - 1] == 1)
                                    {
                                        grid[curRow, curCol - 1] = 0;
                                        pigs++;
                                    }
                                    if (grid[curRow + 1, curCol - 1] == 1)
                                    {
                                        grid[curRow + 1, curCol - 1] = 0;
                                        pigs++;
                                    }
                                    if (grid[curRow + 1, curCol] == 1)
                                    {
                                        grid[curRow + 1, curCol] = 0;
                                        pigs++;
                                    }
                                }
                            }
                            else if (curRow == 7)
                            {
                                if (curCol == 8)
                                {
                                    if (grid[curRow, curCol + 1] == 1)
                                    {
                                        grid[curRow, curCol + 1] = 0;
                                        pigs++;
                                    }
                                    if (grid[curRow - 1, curCol + 1] == 1)
                                    {
                                        grid[curRow - 1, curCol + 1] = 0;
                                        pigs++;
                                    }
                                    if (grid[curRow - 1, curCol] == 1)
                                    {
                                        grid[curRow - 1, curCol] = 0;
                                        pigs++;
                                    }
                                }
                                else if (curCol > 8 && curCol < 15)
                                {
                                    if (grid[curRow, curCol + 1] == 1)
                                    {
                                        grid[curRow, curCol + 1] = 0;
                                        pigs++;
                                    }
                                    if (grid[curRow - 1, curCol + 1] == 1)
                                    {
                                        grid[curRow - 1, curCol + 1] = 0;
                                        pigs++;
                                    }
                                    if (grid[curRow - 1, curCol] == 1)
                                    {
                                        grid[curRow - 1, curCol] = 0;
                                        pigs++;
                                    }
                                    if (grid[curRow, curCol - 1] == 1)
                                    {
                                        grid[curRow, curCol - 1] = 0;
                                        pigs++;
                                    }
                                    if (grid[curRow - 1, curCol - 1] == 1)
                                    {
                                        grid[curRow - 1, curCol - 1] = 0;
                                        pigs++;
                                    }
                                }
                                if (curCol == 15)
                                {
                                    if (grid[curRow, curCol - 1] == 1)
                                    {
                                        grid[curRow, curCol - 1] = 0;
                                        pigs++;
                                    }
                                    if (grid[curRow - 1, curCol - 1] == 1)
                                    {
                                        grid[curRow - 1, curCol - 1] = 0;
                                        pigs++;
                                    }
                                    if (grid[curRow - 1, curCol] == 1)
                                    {
                                        grid[curRow - 1, curCol] = 0;
                                        pigs++;
                                    }
                                }
                            }
                            else if (curRow > 0 && curRow < 7 && curCol == 8)
                            {
                                if (grid[curRow - 1, curCol] == 1)
                                {
                                    grid[curRow - 1, curCol] = 0;
                                    pigs++;
                                }
                                if (grid[curRow - 1, curCol + 1] == 1)
                                {
                                    grid[curRow - 1, curCol + 1] = 0;
                                    pigs++;
                                }
                                if (grid[curRow, curCol + 1] == 1)
                                {
                                    grid[curRow, curCol + 1] = 0;
                                    pigs++;
                                }
                                if (grid[curRow + 1, curCol + 1] == 1)
                                {
                                    grid[curRow + 1, curCol + 1] = 0;
                                    pigs++;
                                }
                                if (grid[curRow + 1, curCol] == 1)
                                {
                                    grid[curRow + 1, curCol] = 0;
                                    pigs++;
                                }
                            }
                            else if (curRow > 0 && curRow < 7 && curCol == 15)
                            {
                                if (grid[curRow - 1, curCol] == 1)
                                {
                                    grid[curRow - 1, curCol] = 0;
                                    pigs++;
                                }
                                if (grid[curRow - 1, curCol - 1] == 1)
                                {
                                    grid[curRow - 1, curCol - 1] = 0;
                                    pigs++;
                                }
                                if (grid[curRow, curCol - 1] == 1)
                                {
                                    grid[curRow, curCol - 1] = 0;
                                    pigs++;
                                }
                                if (grid[curRow + 1, curCol - 1] == 1)
                                {
                                    grid[curRow + 1, curCol - 1] = 0;
                                    pigs++;
                                }
                                if (grid[curRow + 1, curCol] == 1)
                                {
                                    grid[curRow + 1, curCol] = 0;
                                    pigs++;
                                }
                            }
                            score += flight * pigs;
                        }
                    }
                }
            }
            for (int i = 0; i < 8; i++)
            {
                for (int j = 8; j < 16; j++)
                {
                    if (grid[i, j] == 1)
                    {
                        win = false;
                    }
                }
            }
            if (win)
            {
                Console.WriteLine("{0} {1}", score, "Yes");
            }
            else
            {
                Console.WriteLine("{0} {1}", score, "No");
            }
        }
    }
}
