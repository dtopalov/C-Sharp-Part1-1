using System;

class ExchangeBits
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a positive integer n:");
        int input = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(input + " binary: " + Convert.ToString(input, 2).PadLeft(32, '0'));
        for (int i = 3; i <= 5; i++)
        {
            int bit1 = (input >> i) & 1;
            int bit2 = (input >> (21+i)) & 1;
            input = input & (~(1 << (21 + i))) | (bit1 << (21 + i));
            input = input & (~(1 << i)) | (bit2 << i);
        }
        Console.WriteLine(input + " binary: " + Convert.ToString(input, 2).PadLeft(32, '0'));
    }
}