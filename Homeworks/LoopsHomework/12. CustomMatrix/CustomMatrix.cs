using System;
using System.Globalization;

class CustomMatrix
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int[,] matrix = new int[input, input];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = row + col + 1;
                    Console.Write(matrix[row, col].ToString().PadLeft(3, ' '));
                }
                Console.WriteLine();
            }
        }
    }
