//Problem 11.* Numbers in Interval Dividable by Given Number

//Write a program that reads two positive integer numbers and prints how many numbers p exist between them 
//such that the reminder of the division by 5 is 0.

using System;

class DivisibleByFive
{
    static void Main()
    {
        Console.Write("Enter positive integer number a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter positive integer number b: ");
        int b = int.Parse(Console.ReadLine());
        int count = 0;
        if (a > b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        for (int i = a; i <= b; i++)
        {
            if (i%5 == 0)
            {
                count++;
            }
        }
        Console.WriteLine("Start = {0}, end = {1}, p = {2}.", a, b, count);
    }
}
