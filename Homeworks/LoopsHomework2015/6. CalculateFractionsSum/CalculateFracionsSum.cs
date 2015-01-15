//Problem 5. Calculate 1 + 1!/X + 2!/X2 + … + N!/XN

//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x^2 + … + n!/x^n.

using System;
using System.Numerics;

class CalculateFracionsSum
{
    static void Main()
    {
        Console.Write("Enter an integer N: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Enter an integer X: ");
        int X = int.Parse(Console.ReadLine());
        double sum = 1;
        BigInteger iFact = 1;
        int temp;

        for (int i = 1; i <= N; i++)
        {
            temp = i;
            while (temp > 1)
            {
                iFact *= temp;
                temp--;
            }
            sum += (double)iFact / Math.Pow(X, i);
            iFact = 1;
        }
        Console.WriteLine("Sum = {0:F5}", sum);
    }
}
