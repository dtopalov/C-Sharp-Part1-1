//Problem 6. Quadratic Equation

//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

using System;
using System.Globalization;
using System.Threading;

class QuadraticEquation
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter coefficient a different from 0: ");
        double aCoef = double.Parse(Console.ReadLine());
        if (aCoef == 0)
        {
            Console.Write("Enter coefficient a different from 0: ");
            aCoef = double.Parse(Console.ReadLine());
        }
        Console.Write("Enter coefficient b: ");
        double bCoef = double.Parse(Console.ReadLine()); 
        Console.Write("Enter coefficient c: ");
        double cCoef = double.Parse(Console.ReadLine());
        double d = bCoef * bCoef - 4 * aCoef * cCoef;
        double xOnlyRoot = -bCoef / (2 * aCoef);
        double xRoot1 = (-bCoef + Math.Sqrt(d)) / (2 * aCoef);
        double xRoot2 = (-bCoef - Math.Sqrt(d)) / (2 * aCoef);

        if (d < 0) 
        {
            Console.WriteLine(aCoef + "x^2 + " + bCoef + "x + " + cCoef + " = 0 doesn't have any real roots.");
        }
        else 
        {
            if (d == 0) 
            {
                Console.WriteLine(aCoef + "x^2 + " + bCoef + "x + " + cCoef + " = 0 one real root x=" + xOnlyRoot);
            }
            else 
            {
                Console.WriteLine(aCoef + "x^2 + " + bCoef + "x + " + cCoef + " = 0 has two real roots x1=" + xRoot1 + " and x2=" + xRoot2);
            }
        }
    }
}
