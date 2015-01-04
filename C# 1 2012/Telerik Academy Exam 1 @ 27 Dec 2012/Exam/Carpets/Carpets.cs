using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpets
{
    class Carpets
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                if (i < n/2)
                {
                    Console.Write(new string('.', n/2 - i - 1));
                    //Console.Write("/");
                    for (int j = 0; j <= i; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write("/");
                        }
                        else
                        {
                            Console.Write(" ");
                        }    
                    }
                    for (int k = i; k >= 0; k--)
                    {
                        if (k % 2 == 0)
                        {
                            Console.Write("\\");
                        }
                        else
                        {
                            Console.Write(" ");
                        }    
                    }
                    //Console.Write("\\");
                    Console.WriteLine(new string('.', n / 2 - i - 1));
                }
                else
                {
                    Console.Write(new string('.', i - n/2));
                    for (int j = 0; j <= n - i - 1; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write("\\");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    for (int j = n - i - 1; j >= 0; j--)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write("/");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine(new string('.', i - n/2));
                }
            }
        }
    }
}
