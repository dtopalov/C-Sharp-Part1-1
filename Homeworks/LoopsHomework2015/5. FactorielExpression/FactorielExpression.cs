//Problem 7. Calculate N! / (K! * (N-K)!)

using System;
using System.Numerics;

class FactorielExpression
{
    static void Main()
    {
        Console.WriteLine("Enter an integer N > 1:");
        int N = int.Parse(Console.ReadLine()); 
        Console.WriteLine("Enter an integer K (1 < N < K):");
        int K = int.Parse(Console.ReadLine());
        int NminusK = N - K;

        BigInteger result1 = 1; // N!/K!
        BigInteger result2 = 1; // (N-K)!

        while (N - K >= 1)  // N!/K!
        {
            result1 *= N;
            N--;
        }
        while (NminusK > 1) // (N-K)!
        {
            result2 *= NminusK;
            NminusK--;
        }
        Console.WriteLine(result1/result2);
    }
}

