using System;

class ExchangeValues
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an integer a:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter an integer b:");
        int b = int.Parse(Console.ReadLine());
        int c;
        Console.WriteLine("Number a = " + a + ", number b = " + b);
        if (a > b)
        {
            c = a;
            a = b;
            b = c;
            Console.WriteLine("a > b, therefore their values are exchanged and now a = " + a + ", and b = " + b);
        }
    }
}

