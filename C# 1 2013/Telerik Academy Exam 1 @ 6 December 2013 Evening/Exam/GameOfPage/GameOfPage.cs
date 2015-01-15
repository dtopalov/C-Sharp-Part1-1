using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameOfPage
{
    class GameOfPage
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            int[,] tray = new int[16,16];
            string input = "";
            List< string> answers = new List<string>();
            int row;
            int col;
            double check = 0.0;
            for (int i = 0; i < 16; i++)
            {
                input = Console.ReadLine();
                for (int j = 0; j < 16; j++)
                {
                    tray[i, j] = int.Parse(input[j].ToString());
                }
            }
            //for (int i = 0; i < 16; i++)
            //{
            //    for (int j = 0; j < 16; j++)
            //    {
            //        Console.Write(tray[i,j]);
            //    }
            //    Console.WriteLine();
            //}
            while (input != "paypal")
            {
                input = Console.ReadLine();
                switch (input)
                {
                    case "what is":
                        row = int.Parse(Console.ReadLine());
                        col = int.Parse(Console.ReadLine());
                        if (row > 0 && row < 15 & col > 0 && col < 15)
                        {
                            if (tray[row, col] == 0)
                            {
                                Console.WriteLine("smile");
                            }
                            else
                            {
                                if (tray[row - 1, col - 1] == 1 && tray[row - 1, col] == 1 && tray[row - 1, col + 1] == 1 &&
                                    tray[row, col - 1] == 1 && tray[row, col + 1] == 1 &&
                                    tray[row + 1, col - 1] == 1 && tray[row + 1, col] == 1 && tray[row + 1, col + 1] == 1)
                                {
                                    Console.WriteLine("cookie");
                                }
                                else if (tray[row - 1, col - 1] == 0 && tray[row - 1, col] == 0 && tray[row - 1, col + 1] == 0 &&
                                    tray[row, col - 1] == 0 && tray[row, col + 1] == 0 &&
                                    tray[row + 1, col - 1] == 0 && tray[row + 1, col] == 0 && tray[row + 1, col + 1] == 0)
                                {
                                    Console.WriteLine("cookie crumb");
                                }
                                else
                                {
                                    Console.WriteLine("broken cookie");
                                }
                            }
                        }
                        else if (row == 0)
                        {
                            if (col == 0)
                            {
                                if (tray[row, col] == 1)
                                {
                                    if (tray[row + 1, col] == 0 && tray[row + 1, col + 1] == 0 && tray[row, col + 1] == 0)
                                    {
                                        Console.WriteLine("cookie crumb");
                                    }
                                    else
                                    {
                                        Console.WriteLine("broken cookie");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("smile");
                                }
                            }
                            else if (col > 0 && col < 15)
                            {
                                if (tray[row, col] == 1)
                                {
                                    if (tray[row + 1, col] == 0 && tray[row + 1, col + 1] == 0 && tray[row, col + 1] == 0 &&
                                        tray[row + 1, col - 1] == 0 && tray[row, col - 1] == 0)
                                    {
                                        Console.WriteLine("cookie crumb");
                                    }
                                    else
                                    {
                                        Console.WriteLine("broken cookie");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("smile");
                                }
                            }
                            else if (col == 15)
                            {
                                if (tray[row, col] == 1)
                                {
                                    if (tray[row + 1, col] == 0 && tray[row + 1, col - 1] == 0 && tray[row, col - 1] == 0)
                                    {
                                        Console.WriteLine("cookie crumb");
                                    }
                                    else
                                    {
                                        Console.WriteLine("broken cookie");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("smile");
                                }
                            }
                        }
                        else if (row == 15)
                        {
                            if (col == 0)
                            {
                                if (tray[row, col] == 1)
                                {
                                    if (tray[row - 1, col] == 0 && tray[row - 1, col + 1] == 0 && tray[row, col + 1] == 0)
                                    {
                                        Console.WriteLine("cookie crumb");
                                    }
                                    else
                                    {
                                        Console.WriteLine("broken cookie");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("smile");
                                }
                            }
                            else if (col > 0 && col < 15)
                            {
                                if (tray[row, col] == 1)
                                {
                                    if (tray[row - 1, col] == 0 && tray[row - 1, col + 1] == 0 && tray[row, col + 1] == 0 &&
                                        tray[row - 1, col - 1] == 0 && tray[row, col - 1] == 0)
                                    {
                                        Console.WriteLine("cookie crumb");
                                    }
                                    else
                                    {
                                        Console.WriteLine("broken cookie");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("smile");
                                }
                            }
                            else if (col == 15)
                            {
                                if (tray[row, col] == 1)
                                {
                                    if (tray[row - 1, col] == 0 && tray[row - 1, col - 1] == 0 && tray[row, col - 1] == 0)
                                    {
                                        Console.WriteLine("cookie crumb");
                                    }
                                    else
                                    {
                                        Console.WriteLine("broken cookie");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("smile");
                                }
                            }
                        }
                        else if (col == 0 && row > 0 && row < 15)
                        {
                            if (tray[row, col] == 1)
                            {
                                if (tray[row - 1, col] == 0 && tray[row - 1, col + 1] == 0 && tray[row, col + 1] == 0 &&
                                    tray[row + 1, col] == 0 && tray[row + 1, col + 1] == 0)
                                {
                                    Console.WriteLine("cookie crumb");
                                }
                                else
                                {
                                    Console.WriteLine("broken cookie");
                                }
                            }
                            else
                            {
                                Console.WriteLine("smile");
                            }
                        }
                        else if (col == 15 && row > 0 && row < 15)
                        {
                            if (tray[row, col] == 1)
                            {
                                if (tray[row - 1, col] == 0 && tray[row - 1, col - 1] == 0 && tray[row, col - 1] == 0 &&
                                    tray[row + 1, col] == 0 && tray[row + 1, col - 1] == 0)
                                {
                                    Console.WriteLine("cookie crumb");
                                }
                                else
                                {
                                    Console.WriteLine("broken cookie");
                                }
                            }
                            else
                            {
                                Console.WriteLine("smile");
                            }
                        }
                        break;
                    case "buy":
                        row = int.Parse(Console.ReadLine());
                        col = int.Parse(Console.ReadLine());
                        if (row > 0 && row < 15 && col > 0 && col < 15)
                        {
                            if (tray[row, col] == 0)
                            {
                                Console.WriteLine("smile");
                            }
                            else
                            {
                                if (tray[row - 1, col - 1] == 1 && tray[row - 1, col] == 1 &&
                                    tray[row - 1, col + 1] == 1 &&
                                    tray[row, col - 1] == 1 && tray[row, col + 1] == 1 &&
                                    tray[row + 1, col - 1] == 1 && tray[row + 1, col] == 1 &&
                                    tray[row + 1, col + 1] == 1)
                                {
                                    check += 1.79;
                                    tray[row, col] = 0;
                                    tray[row - 1, col - 1] = 0;
                                    tray[row - 1, col] = 0;
                                    tray[row - 1, col + 1] = 0;
                                    tray[row, col - 1] = 0;
                                    tray[row, col + 1] = 0;
                                    tray[row + 1, col - 1] = 0;
                                    tray[row + 1, col] = 0;
                                    tray[row + 1, col + 1] = 0;
                                }
                                else
                                {
                                    Console.WriteLine("page");
                                }
                            }
                        }
                        else if (row == 0)
                        {
                            if (col == 0)
                            {
                                if (tray[row, col] == 1)
                                {
                                    Console.WriteLine("page");
                                }
                                else
                                {
                                    Console.WriteLine("smile");
                                }
                            }
                            else if (col > 0 && col < 15)
                            {
                                if (tray[row, col] == 1)
                                {
                                    Console.WriteLine("page");
                                }
                                else
                                {
                                    Console.WriteLine("smile");
                                }
                            }
                            else if (col == 15)
                            {
                                if (tray[row, col] == 1)
                                {
                                    Console.WriteLine("page");
                                }
                                else
                                {
                                    Console.WriteLine("smile");
                                }
                            }
                        }
                        else if (row == 15)
                        {
                            if (col == 0)
                            {
                                if (tray[row, col] == 1)
                                {
                                    Console.WriteLine("page");
                                }
                                else
                                {
                                    Console.WriteLine("smile");
                                }
                            }
                            else if (col > 0 && col < 15)
                            {
                                if (tray[row, col] == 1)
                                {
                                    Console.WriteLine("page");
                                }
                                else
                                {
                                    Console.WriteLine("smile");
                                }
                            }
                            else if (col == 15)
                            {
                                if (tray[row, col] == 1)
                                {
                                    Console.WriteLine("page");
                                }
                                else
                                {
                                    Console.WriteLine("smile");
                                }
                            }
                        }
                        else if (col == 0 && row > 0 && row < 15)
                        {
                            if (tray[row, col] == 1)
                            {
                                Console.WriteLine("page");
                            }
                            else
                            {
                                Console.WriteLine("smile");
                            }
                        }
                        else if (col == 15 && row > 0 && row < 15)
                        {
                            if (tray[row, col] == 1)
                            {
                                Console.WriteLine("page");
                            }
                            else
                            {
                                Console.WriteLine("smile");
                            }
                        }
                        break;
                }
            }
            Console.WriteLine("{0:F2}", check);
        }
    }
}
