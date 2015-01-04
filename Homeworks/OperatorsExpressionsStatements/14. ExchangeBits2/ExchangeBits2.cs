using System;

class ExchangeBits2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a positive integer n:");
        int input = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("How many bits to exchange?");
        int bitsNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("First sequence of bits starting bit number:");
        int fisrtSequenceStart = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Second sequence of bits starting bit number:");
        int secondSequenceStart = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(input + " binary: " + Convert.ToString(input, 2).PadLeft(32, '0'));
        for (int i = fisrtSequenceStart; i < (fisrtSequenceStart + bitsNumber); i++)
        {
            int bit1 = (input >> i) & 1;
            int bit2 = (input >> ((secondSequenceStart - fisrtSequenceStart) + i)) & 1;
            input = input & (~(1 << ((secondSequenceStart - fisrtSequenceStart) + i))) | (bit1 << ((secondSequenceStart - fisrtSequenceStart) + i));
            input = input & (~(1 << i)) | (bit2 << i);
        }
        Console.WriteLine(input + " binary: " + Convert.ToString(input, 2).PadLeft(32, '0'));
    }
}
