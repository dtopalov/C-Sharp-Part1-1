//Problem 14. Modify a Bit at Given Position

//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold
//the value v at the position p from the binary representation of n while preserving all other bits in n.

using System;

class SetBits
{
    static void Main(string[] args)
    {
        Console.Write("Please enter an integer n: ");
        int input = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please enter 0 or 1 for v: ");
        int v = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please enter position for v: ");
        int position = Convert.ToInt32(Console.ReadLine());
        if (v == 1)
        {
            int mask = 1 << position;
            int result = input | mask;
            Console.WriteLine("n = " + input + "(" + Convert.ToString(input, 2).PadLeft(16, '0') + ")" + ", p = " + position
                            + ", v = " + v + " --> " + result + "(" + Convert.ToString(result, 2).PadLeft(16, '0') + ")");
        }
        else if (v == 0)
        {
            int mask = ~(1 << position);
            int result = input & mask;
            Console.WriteLine("n = " + input + "(" + Convert.ToString(input, 2).PadLeft(16, '0') + ")" + ", p = " + position 
                            + ", v = " + v + " --> " + result + "(" + Convert.ToString(result, 2).PadLeft(16, '0') + ")");
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}
