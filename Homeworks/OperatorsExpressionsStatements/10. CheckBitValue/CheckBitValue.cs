using System;

class CheckBitValue
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter an integer v:");
        int input = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter an integer for position p:");
        int position = Convert.ToInt32(Console.ReadLine());
        bool bitCheck = ((input >> position) & 1) == 1;
        Console.WriteLine("v = " + input + "; p = " + position + " --> " + bitCheck);
    }
}
