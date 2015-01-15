using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondTrolls
{
    class DiamondTrolls
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write(new string('.', (n + 1) / 2));
            Console.Write(new string('*', n));
            Console.WriteLine(new string('.', (n + 1) / 2));

            for (int i = (n-1)/2; i < (n - 1); i++)
            {
                Console.Write(new string('.', n-i-1));
                Console.Write("*");
                Console.Write(new string('.', i));
                Console.Write("*");
                Console.Write(new string('.', i));
                Console.Write("*");
                Console.WriteLine(new string('.', n-i-1));
            }

            Console.WriteLine(new string('*', 2 * n + 1));
            
            for (int i = 1; i <= (n - 1); i++)
            {
                Console.Write(new string('.', i));
                Console.Write("*");
                Console.Write(new string('.', n-i-1));
                Console.Write("*");
                Console.Write(new string('.', n-i-1));
                Console.Write("*");
                Console.WriteLine(new string('.', i));
            }
            Console.Write(new string('.', n));
            Console.Write("*");
            Console.WriteLine(new string('.', n));
        }
    }
}
