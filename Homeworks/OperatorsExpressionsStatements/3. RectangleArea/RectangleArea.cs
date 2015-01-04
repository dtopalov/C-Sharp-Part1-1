using System;

class RectangleArea
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter width:");
        double rectangleWidth = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please enter height:");
        double rectangleHeight = Convert.ToDouble(Console.ReadLine());
        double rectangleArea = rectangleWidth * rectangleHeight;
        Console.WriteLine("The area of a rectangle with width " + rectangleWidth + " and height " + rectangleHeight + " is " + rectangleArea);
    }
}