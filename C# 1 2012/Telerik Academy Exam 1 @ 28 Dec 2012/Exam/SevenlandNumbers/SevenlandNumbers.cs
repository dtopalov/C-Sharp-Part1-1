using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenlandNumbers
{
    class SevenlandNumbers
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();
            int input = int.Parse(inputStr);
            
            if (input%10 <= 5)
            {
                Console.WriteLine(input + 1);
            }
            else
            {
                if (input == 66)
                {
                    Console.WriteLine(100);
                }
                else if (input == 666)
                {
                    Console.WriteLine(1000);
                }
                else if (input < 100)
                {
                    Console.WriteLine(input + 4);
                }
                else if (input > 100 && int.Parse(inputStr[inputStr.Length - 2].ToString()) <= 5)
                {
                    Console.WriteLine(input + 4);
                }
                else if (input > 100 && int.Parse(inputStr[inputStr.Length - 2].ToString()) == 6)
                {
                    Console.WriteLine(input + 34);
                }
            }
        }
    }
}
