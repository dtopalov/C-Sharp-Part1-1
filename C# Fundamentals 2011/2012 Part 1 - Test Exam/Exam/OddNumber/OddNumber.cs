using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumber
{
    class OddNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[] matrix = new long[n];
            int count = 1;
            bool check = false;

            for (int i = 0; i < n; i++)
            {
                matrix[i] = long.Parse(Console.ReadLine());
            }
            if (n == 1)
            {
                Console.WriteLine(matrix[0]);
                check = true;
            }
            Array.Sort(matrix);
            for (int i = 1; i < n; i++)
            {
                count = 1;
                while (matrix[i] == matrix[i - 1] && i < n - 1)
                {
                    count++;
                    i++;
                }
                if (count % 2 != 0)
                {
                    Console.WriteLine(matrix[i - 1]);
                    check = true;
                    break;
                }
            }
            if (check == false)
            {
                Console.WriteLine(matrix[n - 1]);
            }
        }
    }
}
