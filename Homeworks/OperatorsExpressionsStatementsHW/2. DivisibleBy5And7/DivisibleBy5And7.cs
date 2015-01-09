//Problem 3. Divide by 7 and 5

//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

using System;

class DivisibleBy5And7
{
    static void Main()
    {
        Console.Write("Please enter an integer: ");
        int input = Convert.ToInt32(Console.ReadLine());
        bool check = (input % 7 == 0) && (input % 5 == 0);
        Console.WriteLine(input + " can be divided (without remainder) by 7 and 5 at the same time --> " + check);
    }
}
