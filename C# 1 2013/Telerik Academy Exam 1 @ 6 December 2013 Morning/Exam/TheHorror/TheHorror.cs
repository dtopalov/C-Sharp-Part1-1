using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TheHorror
{
    class TheHorror
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int digit = 0;
            long sum = 0;
            int count = 0;
            bool check = false;
            for (int i = 0; i < input.Length; i++)
            {
                check = int.TryParse(input[i].ToString(), out digit);
                if (i%2 == 0 && check)
                {
                    sum += digit;
                    count++;
                }
            }
            Console.WriteLine("{0} {1}", count, sum);
        }
    }
}
