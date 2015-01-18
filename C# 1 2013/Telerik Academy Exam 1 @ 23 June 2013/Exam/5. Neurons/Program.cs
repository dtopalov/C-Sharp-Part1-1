using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _5.Neurons
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputList = new List<string>();
            List<string> output = new List<string>();
            int curRow = 0;
            int curCol = 0;
            string state = "left";

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "-1")
                {
                    break;
                }
                inputList.Add(input);
            }
            
            int rows = inputList.Count;
            uint[,] board = new uint[rows, 32];
            int change = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < 32; j++)
                {
                    board[i, j] = uint.Parse(Convert.ToString(uint.Parse(inputList[i]), 2).PadLeft(32, '0')[j].ToString());
                }
            }
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < 32; j++)
            //    {
            //        Console.Write(board[i,j]);
            //    }
            //    Console.WriteLine();
            //}

            while (output.Count < inputList.Count)
            {
                if (rows == 1)
                {
                    Console.WriteLine(0);
                    break;
                }
                for (int i = 0; i < inputList.Count; i++)
                {
                    change = 0;
                    output.Add("");
                    state = "left";
                    for (int j = 1; j < 32; j++)
                    {
                        if (board[i, j] != board[i, j - 1])
                        {
                            change++;
                        }
                    }
                    for (int j = 0; j < 32; j++)
                    {
                        if (change < 3)
                        {
                            if (change == 2 && board[i, 0] == 1 && board[i, 1] == 0)
                            {
                                output[i] = new string('1', 30);
                                output[i] += 0;
                            }
                            else
                            {
                                output[i] = 0.ToString().PadLeft(32, '0');    
                            }
                            break;
                        }
                        switch (state)
                        {
                            case "left":
                                if (board[i, j] == 1)
                                {
                                    state = "left border";
                                }
                                break;
                            case "left border":
                                if (board[i, j] == 0)
                                {
                                    state = "neuron";
                                    output[i] += 1;
                                }
                                break;
                            case "neuron":
                                if (board[i, j] == 1)
                                {
                                    state = "right";
                                    output[i] += 0;
                                }
                                else
                                {
                                    output[i] += 1;    
                                }
                                break;
                            case "right":
                                output[i] += 0;
                                break;
                        }
                    }
                    Console.WriteLine(Convert.ToUInt32(output[i], 2));
                }
            }
        }
    }
}
