using System;
using System.Numerics;

class FactorielDivision
{
    static void Main()
    {
        Console.WriteLine("Enter an integer N > 1:");
        int N = int.Parse(Console.ReadLine()); 
        Console.WriteLine("Enter an integer K (1 < K < N):");
        int K = int.Parse(Console.ReadLine());
        BigInteger KFact = 1;
        BigInteger NFact = 1;
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
        Console.WriteLine(NFact /KFact);
    }
}
