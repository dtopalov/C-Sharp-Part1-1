//Problem 13. Binary to Decimal Number

//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

using System;

class BinaryToDecimal
{
    static void Main(string[] args)
    {
        Console.Write("Enter binary number: ");
        string input = Console.ReadLine();
        long decimalNumber = 0;
        for (int i = 0; i < input.Length; i++)
        {
            decimalNumber += (long.Parse(input[input.Length - 1 - i].ToString()))*(long)Math.Pow(2, i);
        }
        Console.WriteLine("Binary: {0}\nDecimal: {1}", input, decimalNumber);
    }
}
