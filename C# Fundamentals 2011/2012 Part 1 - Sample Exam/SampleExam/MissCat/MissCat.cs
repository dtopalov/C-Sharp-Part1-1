using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissCat
{
    class MissCat
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] cats = new int[10];
            int bestCat = 0;
            int curCat = 0;
            int bestCatIndex = 0;
            for (int i = 0; i < N; i++)
            {
                int vote = int.Parse(Console.ReadLine());
                cats[vote - 1]++;
            }
            for (int i = 0; i < cats.Length; i++)
            {
                curCat = cats[i];
                if (curCat > bestCat)
                {
                    bestCat = curCat;
                    bestCatIndex = i;
                }
            }
            Console.WriteLine(bestCatIndex + 1);
        }
    }
}
