//Problem 8. Isosceles Triangle

//Write a program that prints an isosceles triangle of 9 copyright symbols ©

using System;

class CopyrightTriangle
{
    static void Main(string[] args)
    {
        char copyright = '\u00a9';
        string line = copyright.ToString();
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        for (int i = 0; i <= 5; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 2 - i/2; j > 0; j--)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(line);
            }
            line += copyright.ToString();
        }
        Console.WriteLine("Another triangle:");
        Console.WriteLine(new string(' ', 3) + copyright + new string(' ', 3));
        Console.WriteLine();
        Console.WriteLine(new string(' ', 2) + copyright + new string(' ', 1) + copyright + new string(' ', 2));
        Console.WriteLine();
        Console.WriteLine(new string(' ', 1) + copyright + new string(' ', 3) + copyright + new string(' ', 1));
        Console.WriteLine();
        Console.WriteLine(copyright + new string(' ', 1) + copyright + new string(' ', 1) + copyright + new string(' ', 1) + copyright);
    }
}
