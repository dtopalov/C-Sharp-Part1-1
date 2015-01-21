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
        double rectanglePerimeter = 2*(rectangleWidth + rectangleHeight);
        Console.WriteLine("Width: {0}\nHeight: {1}\nPerimeter: {2}\nArea: {3}", rectangleWidth, rectangleHeight, rectanglePerimeter, rectangleArea);
    }
}