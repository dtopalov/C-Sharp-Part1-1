//Problem 11. Random Numbers in Given Range

//Write a program that enters 3 integers n, min and max (min < max) and prints n random numbers in the range [min...max].

using System;

class RandomNumbersInRange
{
    static void Main(string[] args)
    {
        Console.Write("How many random numbers? ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter an integer min for the bottom of the range: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Enter an integer max for the top of the range: ");
        int max = int.Parse(Console.ReadLine());
        Random rnd = new Random();
        for (int i = 0; i < n; i++)
        {
            Console.Write(rnd.Next(min, max+1));
            if (i < n - 1)
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}
