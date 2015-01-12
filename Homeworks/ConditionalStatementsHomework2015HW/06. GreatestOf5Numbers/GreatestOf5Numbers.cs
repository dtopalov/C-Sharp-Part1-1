//Problem 6. The Biggest of Five Numbers

//Write a program that finds the biggest of five numbers by using only five if statements.

using System;
using System.Globalization;
using System.Threading;

class GreatestOf5Numbers
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double[] numbers = new double[5];
        double greatestNumber = double.MinValue;
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Please enter number {0}: ", i + 1);
            numbers[i] = double.Parse(Console.ReadLine());
        }
        for (int i = 0; i < 5; i++)
        {
            if (numbers[i] > greatestNumber)
            {
                greatestNumber = numbers[i];
            }
        }
        Console.WriteLine("Greatest number is {0}.", greatestNumber);
    }
}
