//Problem 9. Matrix of Numbers

//Write a program that reads from the console a positive integer number 
//n (1 = n = 20) and prints a matrix like in the examples below. Use two nested loops.

using System;
using System.Globalization;

class CustomMatrix
    {
        static void Main()
        {
            Console.Write("Enter an integer n [1, 20]: ");
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
