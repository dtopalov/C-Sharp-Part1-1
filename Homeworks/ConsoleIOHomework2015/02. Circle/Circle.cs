//Problem 3. Circle Perimeter and Area

//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

using System;
using System.Globalization;
using System.Threading;

class Circle
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter radius: ");
        double r = double.Parse(Console.ReadLine());
        double circlePerimeter = 2*Math.PI*r;
        double circleArea = Math.PI*r*r;
        Console.WriteLine("Radius: {0} --> Perimeter: {1:F2}, Area: {2:F2}", r, circlePerimeter, circleArea);
    }
}
