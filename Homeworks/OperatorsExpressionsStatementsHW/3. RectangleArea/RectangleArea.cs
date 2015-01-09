//Problem 4. Rectangles

//Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;
using System.Globalization;
using System.Threading;

class RectangleArea
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Please enter width: ");
        double rectangleWidth = Convert.ToDouble(Console.ReadLine());
        Console.Write("Please enter height: ");
        double rectangleHeight = Convert.ToDouble(Console.ReadLine());
        double rectangleArea = rectangleWidth * rectangleHeight;
        Console.WriteLine("The area of a rectangle with width " + rectangleWidth + " and height " + rectangleHeight + " is " + rectangleArea);
    }
}