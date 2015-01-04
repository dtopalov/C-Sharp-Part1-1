using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleRotationOfDigits
{
    class TripleRotation
    {
        static void Main(string[] args)
        {
            string K = Console.ReadLine();
            string K1 = "";
            string K2 = "";
            string K3 = "";

            if (K.Length == 1)
            {
                Console.WriteLine(K);
            }
            else
            {
                for (int i = K.Length - 1; i >= 1; i--)
                {
                    if (i == K.Length - 1)
                    {
                        K1 += K[K.Length - 1];
                    }
                    K1 += K[K.Length - 1 - i];
                }

                int K1a = int.Parse(K1);
                //Console.WriteLine(K1a);
                K1 = K1a.ToString();
                if (K1.Length == 1)
                {
                    Console.WriteLine(K1);
                }
                else
                {
                    for (int i = K1.Length - 1; i >= 1; i--)
                    {
                        if (i == K1.Length - 1)
                        {
                            K2 += K1[K1.Length - 1];
                        }
                        K2 += K1[K1.Length - 1 - i];
                    }
                    int K2a = int.Parse(K2);
                    //Console.WriteLine(K2a);
                    K2 = K2a.ToString();
                    if (K2.Length == 1)
                    {
                        Console.WriteLine(K2);
                    }
                    else
                    {
                        for (int i = K2.Length - 1; i >= 1; i--)
                        {
                            if (i == K2.Length - 1)
                            {
                                K3 += K2[K2.Length - 1];
                            }
                            K3 += K2[K2.Length - 1 - i];
                        }

                        int K3a = int.Parse(K3);
                        Console.WriteLine(K3a);
                    }
                }
            }
        }
    }
}
