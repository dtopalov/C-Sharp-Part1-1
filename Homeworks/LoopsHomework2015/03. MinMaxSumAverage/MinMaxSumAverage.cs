//Problem 3. Min, Max, Sum and Average of N Numbers

//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, 
//the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.

using System;

class MinMaxSumAverage
{
    static void Main(string[] args)
    {
        int min = int.MaxValue;
        int max = int.MinValue;
        long sum = 0;
        
        Console.Write("Please enter a positive integer N: ");
        int input = int.Parse(Console.ReadLine());

        for (int i = 0; i < input; i++)
        {
            Console.Write("Enter integer {0}: ", i + 1);
            int number = int.Parse(Console.ReadLine());
            if (number > max)
            {
                max = number;
            }
            if (number < min)
            {
                min = number;
            }
            sum += number;
        }
        double average = (double)sum / input;

        Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\naverage = {3:F2}", min, max, sum, average);
    }
}

