using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_6_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            long result = 0;
            switch (b)
            {
                case 3:
                    result = a + c;
                    break;
                case 6:
                    result = (long)a*c;
                    break;
                case 9:
                    result = a%c;
                    break;
            }
            if (result%3 == 0)
            {
                Console.WriteLine(result/3);
            }
            else
            {
                Console.WriteLine(result%3);
            }
            Console.WriteLine(result);
        }
    }
}
