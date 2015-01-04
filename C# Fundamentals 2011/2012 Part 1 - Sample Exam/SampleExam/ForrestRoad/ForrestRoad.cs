using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForrestRoad
{
    class ForrestRoad
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < 2 * N - 1; i++)
            {
                if (i < N)
                {
                    Console.Write(new string('.', i));
                    Console.Write("*");
                    Console.WriteLine(new string('.', N - i - 1));
                }
                else
                {
                    Console.Write(new string('.', 2*N - i - 2));
                    Console.Write("*");
                    Console.WriteLine(new string('.', i - N + 1));
                }
            }
        }
    }
}
