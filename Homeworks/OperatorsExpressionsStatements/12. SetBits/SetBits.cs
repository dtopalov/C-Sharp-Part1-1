using System;

class SetBits
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter an integer n:");
        int input = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter 0 or 1 for v:");
        int v = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter position for v:");
        int position = Convert.ToInt32(Console.ReadLine());
        if (v == 1)
        {
            int mask = 1 << position;
            int result = input | mask;
            Console.WriteLine("n = " + input + "(" + Convert.ToString(input, 2).PadLeft(8, '0') + ")" + ", p = " + position
                            + ", v = " + v + " --> " + result + "(" + Convert.ToString(result, 2).PadLeft(8, '0') + ")");
        }
        else if (v == 0)
        {
            int mask = ~(1 << position);
            int result = input & mask;
            Console.WriteLine("n = " + input + "(" + Convert.ToString(input, 2).PadLeft(8, '0') + ")" + ", p = " + position 
                            + ", v = " + v + " --> " + result + "(" + Convert.ToString(result, 2).PadLeft(8, '0') + ")");
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}
