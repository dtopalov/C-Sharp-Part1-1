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
    }
}
