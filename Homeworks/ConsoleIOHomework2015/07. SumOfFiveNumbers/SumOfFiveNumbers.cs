//Problem 7. Sum of 5 Numbers

//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

using System;
using System.Globalization;
using System.Threading;

class SumOfFiveNumbers
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter 5 numbers separated by a space: ");
        string input = Console.ReadLine();
        string number = "";
        Console.WriteLine(number);
        double sum = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] != ' ')
            {
                number += input[i];
                if (i == input.Length - 1)
                {
                    sum += double.Parse(number);
                }
            }
            else
            {
                sum += double.Parse(number);
                number = "";
            }
        }
        Console.WriteLine("The sum of the entered numbers is {0}",sum);
    }
}
