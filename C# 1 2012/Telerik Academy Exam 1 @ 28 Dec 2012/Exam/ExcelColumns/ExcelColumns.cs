using System;
using System.Numerics;

namespace ExcelColumns
{
    class ExcelColumns
    {
        static void Main(string[] args)
        {
            string number = "";
            BigInteger output = 0;
            int n = int.Parse(Console.ReadLine());
            
            
            for (int i = 0; i < n; i++)
            {
                number += Console.ReadLine();
            }
            
            for (int i = number.Length - 1; i >= 0; i--)
            {
                int change = number[i] - 64;
                output += change * ((BigInteger) Math.Pow(26.0, number.Length - i - 1));
            }
            Console.WriteLine(output);
        }
    }
}
