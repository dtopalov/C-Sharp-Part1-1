using System;

class CheckBitValue2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter an integer i:");
        int input = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter an integer for bit number b:");
        int position = Convert.ToInt32(Console.ReadLine());
        int bitValue = ((input >> position) & 1);
        Console.WriteLine("i = " + input + "; b = " + position + " --> " + bitValue);
    }
}
