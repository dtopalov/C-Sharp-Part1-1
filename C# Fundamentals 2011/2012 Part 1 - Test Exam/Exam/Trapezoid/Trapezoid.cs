using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoid
{
    class Trapezoid
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write(new string('.', n));
            Console.WriteLine(new string('*', n));
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(new string('.', n - i - 1));
                Console.Write('*');
                Console.Write(new string('.', i));
                Console.Write(new string('.', n - 1));
                Console.WriteLine('*');
            }
            Console.WriteLine(new string('*', 2 * n));
        }
    }
}
