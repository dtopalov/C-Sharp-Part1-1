using System;

class BitCheck
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter an integer:");
        int input = Convert.ToInt32(Console.ReadLine());
        int check = (input >> 3) & 1;
        Console.WriteLine("The third bit of " + input + " is " + check);
    }
}