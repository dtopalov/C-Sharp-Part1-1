using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadronacciRect
{
    class QuadronacciRect
    {
        static void Main(string[] args)
        {
            long q1 = long.Parse(Console.ReadLine());
            long q2 = long.Parse(Console.ReadLine());
            long q3 = long.Parse(Console.ReadLine());
            long q4 = long.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            long[,] matrix = new long[rows,cols];
            matrix[0, 0] = q1;
            matrix[0, 1] = q2;
            matrix[0, 2] = q3;
            matrix[0, 3] = q4;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i == 0 && j < 4)
                    {
                        continue;
                    }
                    if (j >= 4)
                    {
                        matrix[i, j] = matrix[i, j - 4] + matrix[i, j - 3] + matrix[i, j - 2] + matrix[i, j - 1];
                    }
                    else if(j == 0)
                    {
                        matrix[i, j] = matrix[i - 1, cols - 4] + matrix[i - 1, cols - 3] + matrix[i - 1, cols - 2] + matrix[i - 1, cols - 1];
                    }
                    else if (j == 1)
                    {
                        matrix[i, j] = matrix[i, 0] + matrix[i - 1, cols - 3] + matrix[i - 1, cols - 2] + matrix[i - 1, cols - 1];
                    }
                    else if (j == 2)
                    {
                        matrix[i, j] = matrix[i, 0] + matrix[i, 1] + matrix[i - 1, cols - 2] + matrix[i - 1, cols - 1];
                    }
                    else if (j == 3)
                    {
                        matrix[i, j] = matrix[i, 0] + matrix[i, 1] + matrix[i, 2] + matrix[i - 1, cols - 1];
                    }
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j < cols - 1)
                    {
                        Console.Write(matrix[i, j] + " ");   
                    }
                    else
                    {
                        Console.Write(matrix[i, j]); 
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
