using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TribonacciTriangle
{
    class TribonacciTrangle
    {
        static void Main(string[] args)
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            long c = long.Parse(Console.ReadLine());
            long temp = 0;
            long trib = 0;
            int l = int.Parse(Console.ReadLine());
            //Console.WriteLine(a);
            //Console.WriteLine(b + " " + c);
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    temp = a;
                    a = b;
                    b = c;
                    c = temp + a + b;
                    Console.Write(temp);
                    if (j < i)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
