using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitBall
{
    class BitBall
    {
        static void Main(string[] args)
        {
            int[,] field = new int[8,8];
            int t1score = 0;
            int t2score = 0;
            bool goalt1 = true;
            bool goalt2 = true;
            for (int i = 0; i < 16; i++)
            {
                int input = int.Parse(Console.ReadLine());
                string inputStr = Convert.ToString(input, 2).PadLeft(8, '0');
                if (i < 8)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        field[i, j] = int.Parse(inputStr[j].ToString());
                    }       
                }
                else
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (field[i - 8, j] == 1)
                        {
                            if (int.Parse(inputStr[j].ToString()) == 1)
                            {
                                field[i - 8, j] = 0;
                            }
                            //else
                            //{
                            //    field[i - 8, j] = 1;
                            //}
                        }
                        else
                        {
                            if (int.Parse(inputStr[j].ToString()) == 1)
                            {
                                field[i - 8, j] = 2;
                            }
                            //else
                            //{
                            //    field[i - 8, j] = 0;
                            //}
                        }
                    } 
                }
            }
            for (int i = 7; i >= 0; i--)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (field[i, j] == 1)
                    {
                        goalt1 = true;
                        if (i <= 6)
                        {
                            for (int k = i + 1; k < 8; k++)
                            {
                                if (field[k, j] != 0)
                                {
                                    goalt1 = false;
                                    break;
                                }
                            }
                            if (goalt1)
                            {
                                t1score++;
                            }
                        }
                        else
                        {
                            t1score++;
                        }
                    }
                }
            }
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (field[i, j] == 2)
                    {
                        goalt2 = true;
                        if (i > 0)
                        {
                            for (int k = i - 1; k >= 0; k--)
                            {
                                if (field[k, j] != 0)
                                {
                                    goalt2 = false;
                                    break;
                                }
                            }
                            if (goalt2)
                            {
                                t2score++;
                            }
                        }
                        else
                        {
                            t2score++;
                        }
                    }
                }
            }
            //for (int i = 0; i < 8; i++)
            //{
            //    for (int j = 0; j < 8; j++)
            //    {
            //        Console.Write(field[i,j]);
            //    }
            //    Console.WriteLine();
            //}
            Console.WriteLine("{0}:{1}",t1score, t2score);
        }
    }
}
