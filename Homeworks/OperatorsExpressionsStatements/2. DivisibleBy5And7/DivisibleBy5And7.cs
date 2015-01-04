using System;

class DivisibleBy5And7
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter an integer:");
        int input = Convert.ToInt32(Console.ReadLine());
        bool check = (input % 7 == 0) && (input % 5 == 0);
        Console.WriteLine(input + " can be divided (without remainder) by 7 and 5 at the same time --> " + check);
    }
}
