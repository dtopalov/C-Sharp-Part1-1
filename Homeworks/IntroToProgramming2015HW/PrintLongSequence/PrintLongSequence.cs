using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintLongSequence
{
    class PrintLongSequence
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 1001; i++)
            {
                if (i%2 == 0)
                {
                    Console.Write(i + ", ");
                }
                else
                {
                    Console.Write(-i);
                    if (i < 1001)
                    {
                        Console.Write(", ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
