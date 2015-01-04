using System;

class ProductSign
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number a:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter a number b:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter a number c:");
        double c = double.Parse(Console.ReadLine());
        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("The product a*b*c = 0");
        }
        if ((a > 0 && b > 0 && c > 0)||
            (a > 0 && b < 0 && c < 0)||
            (a < 0 && b < 0 && c > 0)||
            (a < 0 && b > 0 && c < 0))
        {
            Console.WriteLine("The product a*b*c > 0");
        }
        if ((a < 0 && b < 0 && c < 0) ||
            (a > 0 && b > 0 && c < 0) ||
            (a > 0 && b < 0 && c > 0) ||
            (a > 0 && b > 0 && c < 0))
        {
            Console.WriteLine("The product a*b*c < 0");
        }
    }
}

