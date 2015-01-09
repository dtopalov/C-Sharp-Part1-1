//Problem 11. Bitwise: Extract Bit #3

//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.

using System;

class BitCheck
{
    static void Main(string[] args)
    {
        Console.Write("Please enter an integer: ");
        int input = Convert.ToInt32(Console.ReadLine());
        int check = (input >> 3) & 1;
        Console.WriteLine("The third bit of " + input + " is " + check);
    }
}