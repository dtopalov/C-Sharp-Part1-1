//Problem 9. Exchange Variable Values

//Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
//Print the variable values before and after the exchange.

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
        Console.WriteLine("After the exchange: a = " + a + ", b = " + b);
    }
}