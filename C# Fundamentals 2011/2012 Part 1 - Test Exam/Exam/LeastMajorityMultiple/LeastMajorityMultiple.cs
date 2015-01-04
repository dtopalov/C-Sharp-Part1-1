using System;

namespace LeastMajorityMultiple
{
    class LeastMajorityMultiple
    {
        static void Main(string[] args)
        {
            int[] input = new int[5];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
            }
            int count = 0;
            int LMM = 1;

            while (count < 3)
            {
                count = 0;
                for (int i = 0; i < 5; i++)
                {
                    if (LMM % input[i] == 0)
                    {
                        count++;
                    }
                }
                LMM++;
            }
            Console.WriteLine(LMM - 1);
        }
    }
}
