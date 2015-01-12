//Problem 7. Sort 3 Numbers with Nested Ifs

//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.

using System;
using System.Globalization;
using System.Threading;

class SortNumbers
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

        if (a > b)
        {
            if (a > c)
            {
                if (b >= c)
                {
                    Console.WriteLine("{0} {1} {2}", a, b, c);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", a, c, b);
                }
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", c, a, b);
            }
        }
        else
        {
            if (a > c)
            {
                Console.WriteLine("{0} {1} {2}", b, a, c);
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine("{0} {1} {2}", b, c, a);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", c, b, a);
                }
            }
        }
    }
}

