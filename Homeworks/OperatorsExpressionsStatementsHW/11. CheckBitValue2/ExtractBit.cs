//Problem 12. Extract Bit from Integer

//Write an expression that extracts from given integer n the value of given bit at index p.

using System;

class ExtractBit
{
    static void Main(string[] args)
    {
        Console.Write("Please enter an integer n: ");
        int input = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please enter an integer for bit number p: ");
        int position = Convert.ToInt32(Console.ReadLine());
        int bitValue = ((input >> position) & 1);
        Console.WriteLine("n = " + input + "; the bit at position p = " + position + " is " + bitValue);
    }
}
