//Problem 13. Check a Bit at Given Position

//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) 
//in given integer number n, has value of 1.

using System;

class CheckBitValue
{
    static void Main(string[] args)
    {
        Console.Write("Please enter an integer n: ");
        int input = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please enter an integer for position p: ");
        int position = Convert.ToInt32(Console.ReadLine());
        bool bitCheck = ((input >> position) & 1) == 1;
        Console.WriteLine("n = " + input + "; value of bit at index p = " + position + " --> " + bitCheck);
    }
}
