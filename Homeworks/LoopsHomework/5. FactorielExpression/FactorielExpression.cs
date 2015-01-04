using System;
using System.Numerics;

class FactorielExpression
{
    static void Main()
    {
        Console.WriteLine("Enter an integer K > 1:");
        int K = int.Parse(Console.ReadLine()); 
        Console.WriteLine("Enter an integer N (1 < N < K):");
        int N = int.Parse(Console.ReadLine());
        int KMinusN = K - N;
        BigInteger KFact = 1;
        BigInteger NFact = 1;
        BigInteger KMinusNFact = 1;
        while (K > 1)
        {
            KFact *= K;
            K--;
        }
        while (N > 1)
        {
            NFact *= N;
            N--;
        }
        while (K - N > 1)
        {
            KMinusNFact *= KMinusN;
            KMinusN--;
        }
        Console.WriteLine((KFact * NFact)/KMinusNFact);
    }
}

