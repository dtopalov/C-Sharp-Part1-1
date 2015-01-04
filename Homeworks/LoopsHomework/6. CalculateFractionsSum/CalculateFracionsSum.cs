using System;
using System.Numerics;

class CalculateFracionsSum
{
    static void Main()
    {
        Console.WriteLine("Enter an integer N:");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter an integer X:");
        int X = int.Parse(Console.ReadLine());
        decimal sum = 1;
        decimal iFact = 1;
        int temp;

        for (int i = 1; i < N; i++)
        {
            temp = i;
            while (i > 1)
            {
                iFact *= i;
                i--;
            }
            i = temp;
            sum += iFact / (i * X);
            iFact = 1;
        }
        Console.WriteLine(sum);
    }
}
