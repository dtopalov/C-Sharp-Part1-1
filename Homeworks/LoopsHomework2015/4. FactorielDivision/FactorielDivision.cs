//Problem 6. Calculate N! / K!

//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.

using System;
using System.Numerics;

class FactorielDivision
{
    static void Main()
    {
        Console.Write("Enter an integer N > 1: ");
        int N = int.Parse(Console.ReadLine()); 
        Console.Write("Enter an integer K (1 < K < N): ");
        int K = int.Parse(Console.ReadLine());
        BigInteger result = 1;

        while (N - K >= 1)
        {
            result *= N;
            N--;
        }
        Console.WriteLine(result);
    }
}
