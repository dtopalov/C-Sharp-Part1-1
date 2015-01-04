using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinDigitsCount
{
    class BinDigitsCount
    {
        static void Main(string[] args)
        {
            string bit = Console.ReadLine();
            int N = int.Parse(Console.ReadLine());
            int count = 0;
            int[] output = new int[N];
            for (int i = 0; i < N; i++)
            {
                long number = long.Parse(Console.ReadLine());
                string binNumber = Convert.ToString(number, 2);
                count = 0;
                for (int j = 0; j < binNumber.Length; j++)
                {
                    if (binNumber[j].ToString() == bit[0].ToString())
                    {
                        count++;
                    }
                }
                output[i] = count;
            }
            for (int i = 0; i < output.Length; i++)
            {
                Console.WriteLine(output[i]);
            }
        }
    }
}
