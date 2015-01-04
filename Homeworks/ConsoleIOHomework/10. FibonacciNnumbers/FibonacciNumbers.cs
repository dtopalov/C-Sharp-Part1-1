using System;

class FibonacciNumbers
{
    static void Main()
    {
        decimal preLast = 0;
        decimal last = 1;
        decimal current = preLast + last;
        Console.Write("1. " + preLast + "\n2. " + last + "\n");
        for (int i = 2; i < 100; i++)
        {
            Console.Write((i+1) + ". " + current + "\n");
            preLast = last;
            last = current;
            current = preLast + last;
        }
        Console.WriteLine();
    }
}

