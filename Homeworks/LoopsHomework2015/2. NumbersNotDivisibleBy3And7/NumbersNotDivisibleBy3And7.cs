//Problem 2. Numbers Not Divisible by 3 and 7

//Write a program that enters from the console a positive integer n and prints all 
//the numbers from 1 to n not divisible by 3 and 7, on a single line, separated by a space.

using System;

class NumbersNotDivisibleBy3And7
{
    static void Main()
    {
        Console.Write("Enter a positive integer N: ");
        int N = int.Parse(Console.ReadLine());
        for (int i = 1; i <= N; i++)
        {
            if (!(i % 3 == 0 || i % 7 == 0))
            {
                Console.Write(i);
                if (i < N)
                {
                    Console.Write(" ");
                }
            }
        }
        Console.WriteLine();
    }
}
