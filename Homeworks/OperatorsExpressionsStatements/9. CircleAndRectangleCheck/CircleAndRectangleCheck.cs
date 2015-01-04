using System;

class CircleAndRectangleCheck
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter coordinate X:");
        double coorX = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please enter coordinate Y:");
        double coorY = Convert.ToDouble(Console.ReadLine());
        int r = 3;
        bool withinCircle = ((coorX - 1) * (coorX - 1) + (coorY - 1) * (coorY - 1)) <= Math.Pow(r, 2);
        bool outsideRect = ((coorX < -1) || (coorX > 5) || (coorY > 1) || (coorY < -1));
        bool checkCond = withinCircle && outsideRect;
        Console.WriteLine("Point (x,y) with coordinates (" + coorX + "," + coorY + ") is within circle K and outside the rectangle R --> " + checkCond);
    }
}