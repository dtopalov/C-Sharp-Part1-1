using System;
using System.Numerics;

class TrailingZeroes
{
    static void Main()
    {
        Console.WriteLine("Enter an integer N:");
        int input = int.Parse(Console.ReadLine());
        int i = input;
        BigInteger NFact = 1;
        int count = 0;
        while (i > 1)
        {
            NFact *= i;
            i--;
        }
        while (NFact%10 == 0)
        {
            NFact /= 10;
            count++;
        }
        Console.WriteLine("The trailing zeroes in {0}! is {1}.", input, count);
    }
}
