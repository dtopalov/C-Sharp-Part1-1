using System;

class GreaterNumber
{
    static void Main()
    {
        Console.WriteLine("Enter number a: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter number b: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("The greater number is " + Math.Max(a, b));
    }
}
