using System;

namespace PrintNumbers
{
    class PrintNumbers
    {
        static void Main(string[] args)
        {
            string zeros = "";
            for (int i = 0; i < 4; i++)
            {
                if (i != 1)
                {
                    Console.WriteLine(zeros + 1);
                    Console.Write(1);
                    zeros += 0;
                }
            }
        }
    }
}
