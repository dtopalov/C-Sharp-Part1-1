//Problem 4. Multiplication Sign

//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.

using System;
using System.Globalization;
using System.Threading;

class ProductSign
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter a number a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter a number b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter a number c: ");
        double c = double.Parse(Console.ReadLine());
        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("The product a*b*c = 0");
        }
        if ((a > 0 && b > 0 && c > 0)||
            (a > 0 && b < 0 && c < 0)||
            (a < 0 && b < 0 && c > 0)||
            (a < 0 && b > 0 && c < 0))
        {
            Console.WriteLine("The product a*b*c > 0");
        }
        if ((a < 0 && b < 0 && c < 0) ||
            (a > 0 && b > 0 && c < 0) ||
            (a > 0 && b < 0 && c > 0) ||
            (a > 0 && b > 0 && c < 0))
        {
            Console.WriteLine("The product a*b*c < 0");
        }
    }
}

