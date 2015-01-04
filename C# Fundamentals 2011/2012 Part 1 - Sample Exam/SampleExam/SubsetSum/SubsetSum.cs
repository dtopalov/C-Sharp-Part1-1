using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SubsetSum
{
    class SubsetSum
    {
        static void Main(string[] args)
        {
            long S = long.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            long[] input = new long[N];
            long curSum = 0;
            int count = 0;
            for (int i = 0; i < N; i++)
            {
                input[i] = long.Parse(Console.ReadLine());
            }
            for (int i = 1; i <= (int)Math.Pow(2, (double)N) - 1; i++)
            {
                curSum = 0;
                string template = Convert.ToString(i, 2);
                string template1 = template.PadLeft(N, '0');
                //Console.WriteLine(template1);
                for (int j = 0; j < template1.Length; j++)
                {
                    if (template1[j].ToString() == "1")
                    {
                        curSum += input[j];
                    }
                }
                if (curSum == S)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
