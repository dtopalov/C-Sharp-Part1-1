//Problem 19.** Spiral Matrix

//Write a program that reads from the console a positive integer number n (1 = n = 20) and prints a matrix 
//holding the numbers from 1 to n*n in the form of square spiral like in the examples below.

using System;

class MatrixSpiral
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int input = int.Parse(Console.ReadLine());
        int[,] matrix = new int[input, input];
        int currentRow = 0;
        int currentCol = 0;
        string direction = "right";
        for (int i = 0; i < input * input; i++)
        {
            switch (direction)
            {
                case "right":
                    if (currentCol == input || matrix[currentRow, currentCol] != 0)
                    {
                        direction = "down";
                        currentCol--;
                        currentRow++;
                        if (i < input * input - 1)
                        {
                            i--;
                        }
                        else
                        {
                            matrix[currentRow, currentCol] = i + 1;
                        }
                    }
                    else
                    {
                        matrix[currentRow, currentCol] = i + 1;
                        currentCol++;
                    }
                    break;
                case "down":
                    if (currentRow == input || matrix[currentRow, currentCol] != 0)
                    {
                        direction = "left";
                        currentCol--;
                        currentRow--;
                        if (i < input * input - 1)
                        {
                            i--;
                        }
                        else
                        {
                            matrix[currentRow, currentCol] = i + 1;
                        }
                    }
                    else
                    {
                        matrix[currentRow, currentCol] = i + 1;
                        currentRow++;
                    }
                    break;
                case "left":
                    if (currentCol < 0 || matrix[currentRow, currentCol] != 0)
                    {
                        direction = "up";
                        currentRow--;
                        currentCol++;
                        if (i < input * input - 1)
                        {
                            i--;
                        }
                        else
                        {
                            matrix[currentRow, currentCol] = i + 1;
                        }
                    }
                    else
                    {
                        matrix[currentRow, currentCol] = i + 1;
                        currentCol--;
                    }
                    break;
                case "up":
                    if (currentRow < 1 || matrix[currentRow, currentCol] != 0)
                    {
                        direction = "right";
                        currentCol++;
                        currentRow++;
                        if (i < input * input - 1)
                        {
                            i--;
                        }
                        else
                        {
                            matrix[currentRow, currentCol] = i + 1;
                        }
                    }
                    else
                    {
                        matrix[currentRow, currentCol] = i + 1;
                        currentRow--;
                    }
                    break;
            }
        }

        for (int row = 0; row < input; row++)
        {
            for (int col = 0; col < input; col++)
            {
                Console.Write(matrix[row, col].ToString().PadLeft(4, ' '));
            }
            Console.WriteLine();
        }
    }
}