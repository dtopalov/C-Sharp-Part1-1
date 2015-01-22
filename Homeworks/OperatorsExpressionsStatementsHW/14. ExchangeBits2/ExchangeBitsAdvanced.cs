//Problem 16.** Bit Exchange (Advanced)

//Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
//The first and the second sequence of bits may not overlap.

using System;

class ExchangeBitsAdvanced
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a positive integer n: ");
        long input = 0;
        bool isInRange = long.TryParse(Console.ReadLine(), out input);
        Console.Write("How many bits to exchange? ");
        int numberOfBits = Convert.ToInt32(Console.ReadLine());
        Console.Write("First sequence of bits starting bit number: ");
        int firstSequenceStart = Convert.ToInt32(Console.ReadLine());
        Console.Write("Second sequence of bits starting bit number: ");
        int secondSequenceStart = Convert.ToInt32(Console.ReadLine());
        if (input <= uint.MaxValue)
        {
            Console.WriteLine("n: " + input + "; n(binary): " + Convert.ToString(input, 2).PadLeft(32, '0'));
        }
        else
        {
            Console.WriteLine("n: " + input + "; n(binary): " + Convert.ToString(input, 2).PadLeft(64, '0')); 
        }
        if (isInRange == false || Math.Min(firstSequenceStart, secondSequenceStart) < 0 || Math.Max(firstSequenceStart, secondSequenceStart) + numberOfBits > 32)
        {
            Console.WriteLine("out of range");
        }
        else
        {
            if (Math.Min(firstSequenceStart, secondSequenceStart) + numberOfBits > Math.Max(firstSequenceStart, secondSequenceStart))
            {
                Console.WriteLine("Overlapping");
            }
            else
            {
                
                for (int i = firstSequenceStart; i < (firstSequenceStart + numberOfBits); i++)
                {
                    long bit1 = (input >> i) & 1;
                    long bit2 = (input >> ((secondSequenceStart - firstSequenceStart) + i)) & 1;
                    input = (uint)(input & (~(1 << ((secondSequenceStart - firstSequenceStart) + i))) | (bit1 << ((secondSequenceStart - firstSequenceStart) + i)));
                    input = (uint)(input & (~(1 << i)) | (bit2 << i));
                }
                Console.WriteLine("result: " + input + "; result(binary): " + Convert.ToString(input, 2).PadLeft(32, '0'));
            }
        }
    }
}