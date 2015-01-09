//Problem 7. Point in a Circle

//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

using System;
using System.Globalization;
using System.Threading;

class WithinCircle
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Please enter coordinate X: ");
        double coorX = Convert.ToDouble(Console.ReadLine());
        Console.Write("Please enter coordinate Y: ");
        double coorY = Convert.ToDouble(Console.ReadLine());
        int r = 2;
        bool checkK = (Math.Pow(coorX, 2) + Math.Pow(coorY, 2)) <= Math.Pow(r, 2);
        Console.WriteLine("The point (x,y) with coordinates (" + coorX + "," + coorY + ") is within circle K({0,0}, 2) --> " + checkK);
    }
}
