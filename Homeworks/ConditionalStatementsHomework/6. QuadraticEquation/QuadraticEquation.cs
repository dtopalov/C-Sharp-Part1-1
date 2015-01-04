using System;

class QuadraticEquation
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a coefficient a:");
        double aCoef = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter a coefficient b:");
        double bCoef = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter a coefficient c:");
        double cCoef = double.Parse(Console.ReadLine());
        double d = bCoef * bCoef - 4 * aCoef * cCoef;
        double xOnlyRoot = -bCoef / (2 * aCoef);
        double xRoot1 = (-bCoef + Math.Sqrt(d)) / (2 * aCoef);
        double xRoot2 = (-bCoef - Math.Sqrt(d)) / (2 * aCoef);

        if (d < 0) {
            Console.WriteLine(aCoef + "x^2 + " + bCoef + "x + " + cCoef + " doesn't have any real roots.");
        }
        else {
            if (d == 0) {
                Console.WriteLine(aCoef + "x^2 + " + bCoef + "x + " + cCoef + " one real root x=" + xOnlyRoot);
            }
            else {
                Console.WriteLine(aCoef + "x^2 + " + bCoef + "x + " + cCoef + " has two real roots x1=" + xRoot1 + " and x2=" + xRoot2);
            }
        }
    }
}

