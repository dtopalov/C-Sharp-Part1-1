using System;

class TrapezoidArea
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter length of side a:");
        double sideA = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please enter length of side b:");
        double sideB = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please enter height h:");
        double height = Convert.ToDouble(Console.ReadLine());
        double trapezoidArea = height * (sideA + sideB) / 2;
        Console.WriteLine("The area of a trapezoid with sides a = " + sideA + ", b = " + sideB + ", and height = " + height + " is " + trapezoidArea);
    }
}
