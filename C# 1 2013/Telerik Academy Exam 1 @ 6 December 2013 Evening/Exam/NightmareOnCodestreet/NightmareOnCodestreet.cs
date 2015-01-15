using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightmareOnCodestreet
{
    class NightmareOnCodestreet
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            long sum = 0;
            int count = 0;
            int digit = 0;
            
            for (int i = 0; i < input.Length; i++)
            {
                bool check = int.TryParse(input[i].ToString(), out digit);
                if (i%2 != 0 && check)
                {
                    count++;
                    sum += digit;
                }
            }
            Console.WriteLine("{0} {1}", count, sum);
        }
    }
}
