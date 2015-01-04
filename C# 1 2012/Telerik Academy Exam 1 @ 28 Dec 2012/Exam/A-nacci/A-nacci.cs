using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_nacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] code = new int[2, 26];
            int temp = 0;
            int letter1code = 0;
            int letter2code = 0;
            int nextLetter = 0;
            
            for (int i = 0; i < 26; i++)
            {
                code[0, i] = i + 1;
                code[1, i] = i + 65;
            }
            
            char input1 = Console.ReadLine()[0];
            char input2 = Console.ReadLine()[0];
            int L = int.Parse(Console.ReadLine());

            Console.WriteLine(input1);
            for (int j = 0; j < 26; j++)
            {
                if ((char)code[1, j] == input1)
                {
                    letter1code = code[0, j];
                }
                if (input2 == ((char)code[1, j]))
                {
                    letter2code = code[0, j];
                }
            }
            for (int i = 0; i < 2 * L - 2; i++)
            {
                temp = letter1code;
                letter1code = letter2code;

                if (temp + letter2code <= 26)
                {
                    letter2code = temp + letter1code;
                }
                else
                {
                    letter2code = (temp + letter1code) % 26;
                }
                if (i%2 == 0)
                {
                    Console.Write((char)(letter1code + 64));
                    Console.Write(new string(' ', i/2));
                    Console.WriteLine((char)(letter2code + 64));   
                }
            }
        }
    }
}
