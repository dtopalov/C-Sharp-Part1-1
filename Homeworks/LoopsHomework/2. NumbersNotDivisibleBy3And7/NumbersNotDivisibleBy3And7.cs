using System;

class NumbersNotDivisibleBy3And7
{
    static void Main()
    {
        Console.WriteLine("Enter a number N:");
        int N = int.Parse(Console.ReadLine());
        for (int i = 0; i <= N; i++)
        {
            if (!(i % 3 == 0 && i % 7 == 0))
            {
                Console.WriteLine(i);
            }
        }
    }
}
