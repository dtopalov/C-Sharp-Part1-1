using System;

class CompareNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a real number a:");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please enter a real number b:");
        double b = Convert.ToDouble(Console.ReadLine());
        bool equal = Math.Abs(a-b) < 0.000001;
        Console.WriteLine("a == b --> " + equal);
    }
}
