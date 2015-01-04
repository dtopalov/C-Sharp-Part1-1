using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartesianCoord
{
    class CartCoordSys
    {
        static void Main(string[] args)
        {
            long X = long.Parse(Console.ReadLine());
            long Y = long.Parse(Console.ReadLine());

            if (X == 0)
            {
                if (Y == 0)
                {
                    Console.WriteLine(0); 
                }
                else
                {
                    Console.WriteLine(5);
                }
            }
            else if (X > 0)
            {
                if (Y == 0)
                {
                    Console.WriteLine(6);
                }
                else if (Y > 0)
                {
                    Console.WriteLine(1);
                }
                else
                {
                    Console.WriteLine(4);
                }
            }
            else
            {
                if (Y == 0)
                {
                    Console.WriteLine(6);
                }
                else if (Y > 0)
                {
                    Console.WriteLine(2);
                }
                else
                {
                    Console.WriteLine(3);
                }
            }
        }
    }
}
