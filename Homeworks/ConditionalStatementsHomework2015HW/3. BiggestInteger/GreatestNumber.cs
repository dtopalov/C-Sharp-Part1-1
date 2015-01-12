//Problem 5. The Biggest of 3 Numbers

//Write a program that finds the biggest of three numbers.

using System;
using System.Globalization;
using System.Threading;

class GreatestNumber
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter number a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter number b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter number c: ");
        double c = double.Parse(Console.ReadLine());
        if ((a == b && b == c) || (a == b && a > c) || (a == c && a > b) || (b == c && b > a)) 
        {
            Console.WriteLine("Greatest number cannot be determined.");
        }
        else if (a > b && a > c) 
        {
            Console.WriteLine("A({0}) is greatest.", a);
        }
        else if (b > a && b > c) 
        {
            Console.WriteLine("B({0}) is greatest.", b);
        }
        else if (c > a && c > b) 
        {
            Console.WriteLine("C({0}) is greatest.", c);
        }
    }
}
