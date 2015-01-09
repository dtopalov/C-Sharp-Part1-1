//Problem 9. Trapezoids

//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;
using System.Globalization;
using System.Threading;

class TrapezoidArea
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Please enter length of side a: ");
        double sideA = Convert.ToDouble(Console.ReadLine());
        Console.Write("Please enter length of side b: ");
        double sideB = Convert.ToDouble(Console.ReadLine());
        Console.Write("Please enter height h: ");
        double height = Convert.ToDouble(Console.ReadLine());
        double trapezoidArea = height * (sideA + sideB) / 2;
        Console.WriteLine("The area of a trapezoid with sides a = " + sideA + ", b = " + sideB + ", and height = " + height + " is " + trapezoidArea);
    }
}
