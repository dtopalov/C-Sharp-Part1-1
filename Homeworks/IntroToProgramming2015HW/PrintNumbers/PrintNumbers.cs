using System;

namespace PrintNumbers
{
    class PrintNumbers
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine(Math.Pow(10, i));
                }
                else
                {
                    Console.WriteLine("{0}{1}", Math.Pow(10, i), 1);      
                }
            }
        }
    }
}
