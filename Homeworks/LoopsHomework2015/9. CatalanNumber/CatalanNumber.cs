//Problem 8. Catalan Numbers

using System;
using System.Numerics;

class CatalanNumber
{
    static void Main()
    {
        Console.WriteLine("Enter an integer N >= 0:");
        int N = int.Parse(Console.ReadLine());
        int inputN = N;
        BigInteger fact2N = 1;
        int doubleN = 2*N;
        BigInteger factN = 1;

        while (doubleN > 1)
        {
            fact2N *= doubleN;
            doubleN--;
        }
        while (N > 1)
        {
            factN *= N;
            N--;
        }
        BigInteger result = fact2N/(factN*factN*(inputN + 1));
        Console.WriteLine("The Nth Catalan number for N = {0} is {1}.", inputN, result);
    }
}
