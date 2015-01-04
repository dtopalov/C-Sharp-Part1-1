using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikLogo
{
    class TelerikLogo
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[,] logo = new string[(3 * n)-2, 3*n - 2];
            int row = n/2;
            int col = 0;

            for (int i = 0; i < logo.GetLength(0); i++)
            {
                for (int j = 0; j < logo.GetLength(1); j++)
                {
                    logo[i, j] = ".";
                }
            }
            for (int i = 0; i <= n/2; i++)
            {
                logo[row, col] = "*";
                row--;
                col++;
            }
            row++;
            col--; 
            for (int i = 0; i < (n*2) - 1; i++)
            {
                logo[row, col] = "*";
                row++;
                col++;
            }
            row--;
            col--;
            for (int i = 0; i < n; i++)
            {
                logo[row, col] = "*";
                row++;
                col--;
            }
            row--;
            col++;
            for (int i = 0; i < n; i++)
            {
                logo[row, col] = "*";
                row--;
                col--;
            }
            row++;
            col++;
            for (int i = 0; i < (n * 2) - 1; i++)
            {
                logo[row, col] = "*";
                row--;
                col++;
            }
            row++;
            col--;
            for (int i = 0; i <= n / 2; i++)
            {
                logo[row, col] = "*";
                row++;
                col++;
            }
            for (int i = 0; i < logo.GetLength(0); i++)
            {
                for (int j = 0; j < logo.GetLength(1); j++)
                {
                    Console.Write(logo[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
