using System;

class PrintFirstNNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter an integer N:");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}

