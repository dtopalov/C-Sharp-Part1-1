using System;

class Circle
{
    static void Main()
    {
        Console.WriteLine("Enter radius: ");
        double r = double.Parse(Console.ReadLine());
        double circlePerimeter = 2*Math.PI*r;
        double circleArea = Math.PI*r*r;
        Console.WriteLine("Circle:\nradius: " + r + "\nperimeter: " + circlePerimeter + "\narea: " + circleArea);
    }
}
