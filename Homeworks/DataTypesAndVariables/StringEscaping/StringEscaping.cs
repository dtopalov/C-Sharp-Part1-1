using System;

class StringEscaping
{
    static void Main(string[] args)
    {
        string quoted = @"The ""use"" of quotations causes difficulties.";
        string escaped = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine("The string using @: " + quoted);
        Console.WriteLine("The string using escaping: " + escaped);
    }
}