using System;

class FibonacciSum
{
    static void Main()
    {
        Console.WriteLine("Please enter an integer N:");
        int N = int.Parse(Console.ReadLine());
        long fibFirst = 0;
        long fibSecond = 1;
        long fibCurrent;
        long sum = 1; 

        for (int i = 2; i < N; i++)
        {
            fibCurrent = fibFirst + fibSecond;
            sum += fibCurrent;
            fibFirst = fibSecond;
            fibSecond = fibCurrent;
        }
        Console.WriteLine("The sum of the first {0} members of the sequence of Fibonacci is {1}.", N, sum);
    }
}