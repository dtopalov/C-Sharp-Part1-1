using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallDown
{
    class FallDown
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[8,8];
            int[] col = new int[8];
            string number = "";
            string number1 = "";
            for (int i = 0; i < 8; i++)
            {
                int input = int.Parse(Console.ReadLine());
                string inputStr = Convert.ToString(input, 2);
                string inputStr1 = inputStr.PadLeft(8, '0');
                for (int j = 0; j < 8; j++)
                {
                    matrix[i, j] = int.Parse(inputStr1[j].ToString());
                }
            }
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    col[j] = matrix[j, i];
                }
                Array.Sort(col);
                for (int j = 0; j < 8; j++)
                {
                    matrix[j, i] = col[j];
                }
            }
            for (int i = 0; i < 8; i++)
            {
                number = "";
                for (int j = 0; j < 8; j++)
                {
                    number += matrix[i, j];
                }
                number1 = Convert.ToInt32(number, 2).ToString();
                Console.WriteLine(number1);
            }
        }
    }
}
