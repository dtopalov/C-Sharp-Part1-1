//Problem 15.* Bits Exchange

//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class ExchangeBits
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a positive integer n: ");
        uint input = Convert.ToUInt32(Console.ReadLine());
        Console.WriteLine(input + " binary: " + Convert.ToString(input, 2).PadLeft(32, '0'));
        for (int i = 3; i <= 5; i++)
        {
            int bit1 = (int)(input >> i) & 1;
            int bit2 = (int)(input >> (21+i)) & 1;
            input = (uint)(input & (~(1 << (21 + i))) | (bit1 << (21 + i)));
            input = (uint)(input & (~(1 << i)) | (bit2 << i));
        }
        Console.WriteLine(input + " binary: " + Convert.ToString(input, 2).PadLeft(32, '0'));
    }
}