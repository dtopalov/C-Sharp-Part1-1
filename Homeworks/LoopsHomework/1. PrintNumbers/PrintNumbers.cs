using System;

class PrintNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter a number N:");
        int N = int.Parse(Console.ReadLine());
        for (int i = 0; i <= N; i++)
        {
            Console.WriteLine(i);
        }
    }
}

