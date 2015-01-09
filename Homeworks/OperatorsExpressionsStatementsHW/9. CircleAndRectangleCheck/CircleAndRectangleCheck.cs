//Problem 10. Point Inside a Circle & Outside of a Rectangle

//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
//and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;
using System.Globalization;
using System.Threading;

class CircleAndRectangleCheck
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Please enter coordinate X: ");
        double coorX = Convert.ToDouble(Console.ReadLine());
        Console.Write("Please enter coordinate Y: ");
        double coorY = Convert.ToDouble(Console.ReadLine());
        double r = 1.5;
        bool withinCircle = ((coorX - 1) * (coorX - 1) + (coorY - 1) * (coorY - 1)) <= Math.Pow(r, 2);
        bool outsideRect = ((coorX < -1) || (coorX > 5) || (coorY > 1) || (coorY < -1));
        bool checkCond = withinCircle && outsideRect;
        Console.WriteLine("Point (x,y) with coordinates (" + coorX + "," + coorY + ") is within circle K and outside the rectangle R --> " + checkCond);
    }
}