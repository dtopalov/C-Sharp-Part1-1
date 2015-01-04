using System;

class ExchangeValues
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Integer a = " + a + ", integer b = " + b);
        int c = a;
        a = b;
        b = c;
        Console.WriteLine("After value exchange: a = " + a + ", b = " + b);
    }
}