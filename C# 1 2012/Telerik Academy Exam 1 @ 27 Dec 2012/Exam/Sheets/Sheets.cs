using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheets
{
    class Sheets
    {
        static void Main(string[] args)
        {
            string[] sheets = {"A10", "A9", "A8", "A7", "A6", "A5", "A4", "A3", "A2", "A1", "A0"};
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                string nBin = Convert.ToString(n, 2);
                sheets[nBin.Length - 1] = "";
                n -= (int)Math.Pow(2.0, nBin.Length - 1);
            }
            for (int i = sheets.Length - 1; i >=0; i--)
            {
                if (sheets[i] != "")
                {
                    Console.WriteLine(sheets[i]);
                }
            }
        }
    }
}
