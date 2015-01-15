//Problem 14. Decimal to Binary Number

//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

using System;

class DecimalToBinary
{
    static void Main(string[] args)
    {
        Console.Write("Decimal integer n: ");
        int input = int.Parse(Console.ReadLine());
        string binary = "";
        while (input > 0)
        {
            binary += input%2;
            input /= 2;
        }
        Console.Write("Binary: ");
        for (int i = binary.Length - 1; i >= 0; i--)
        {
            Console.Write(binary[i]);
        }
        Console.WriteLine();
    }
}
