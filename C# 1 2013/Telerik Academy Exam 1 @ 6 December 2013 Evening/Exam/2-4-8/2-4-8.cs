using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_4_8
{
    class _248
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());

            long R = 0;

            switch (B)
            {
                case 2:
                    R = A%C;
                    break;
                case 4:
                    R = A + C;
                    break;
                case 8:
                    R = (long)A*C;
                    break;
            }
            if (R%4 == 0)
            {
                Console.WriteLine(R/4);
                Console.WriteLine(R);
            }
            else
            {
                Console.WriteLine(R%4);
                Console.WriteLine(R);
            }
        }
    }
}
