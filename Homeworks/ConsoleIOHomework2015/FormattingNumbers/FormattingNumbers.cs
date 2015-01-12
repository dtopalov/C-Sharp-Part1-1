//Problem 5. Formatting Numbers

//Write a program that reads 3 numbers:
//integer a (0 <= a <= 500)
//floating-point b
//floating-point c
//The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
//The number a should be printed in hexadecimal, left aligned
//Then the number a should be printed in binary form, padded with zeroes
//The number b should be printed with 2 digits after the decimal point, right aligned
//The number c should be printed with 3 digits after the decimal point, left aligned.

using System;
using System.Globalization;
using System.Threading;

class FormattingNumbers
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter integer a (0 <= a <= 500): ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter float b: ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Enter float c: ");
        float c = float.Parse(Console.ReadLine());
        Console.WriteLine("|{0}|{1}|{2}|{3}|", Convert.ToString(a, 16).ToUpper().PadRight(10), Convert.ToString(a, 2).PadLeft(10,'0'), b.ToString("0.00").PadLeft(10), c.ToString("0.000").PadRight(10));
    }
}
