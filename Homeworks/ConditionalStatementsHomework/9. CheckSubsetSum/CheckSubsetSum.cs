using System;

class CheckSubsetSum
{
    static void Main(string[] args)
    {
        int[] input = new int[5];
        int sum;
        string join = ", ";
        bool zeroSubset = false;
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Please enter integer " + (i+1));
            input[i] = int.Parse(Console.ReadLine());
        }
        if (input[0] <= 0 || input[1] <= 0 || input[2] <= 0 || input[3] <= 0 || input[4] <= 0)
        {
            if (input[0] + input[1] + input[2] + input[3] + input[4] == 0)
            {
                Console.WriteLine("Subset {0}{5}{1}{5}{2}{5}{3}{5}{4} = 0", input[0], input[1], input[2], input[4], input[5], "+");
                zeroSubset = true;
            }
            if (input[0] + input[1] + input[2] + input[3] == 0)
            {
                Console.WriteLine("Subset {0}{4}{1}{4}{2}{4}{3} = 0", input[0], input[1], input[2], input[3], "+");
                zeroSubset = true;
            }
            if (input[0] + input[1] + input[2] + input[4] == 0)
            {
                Console.WriteLine("Subset {0}{4}{1}{4}{2}{4}{3} = 0", input[0], input[1], input[2], input[4], "+");
                zeroSubset = true;
            }
            if (input[0] + input[1] + input[3] + input[4] == 0)
            {
                Console.WriteLine("Subset {0}{4}{1}{4}{2}{4}{3} = 0", input[0], input[1], input[3], input[4], "+");
                zeroSubset = true;
            }
            if (input[0] + input[2] + input[3] + input[4] == 0)
            {
                Console.WriteLine("Subset {0}{4}{1}{4}{2}{4}{3} = 0", input[0], input[2], input[3], input[4], "+");
                zeroSubset = true;
            }
            if (input[1] + input[2] + input[3] + input[4] == 0)
            {
                Console.WriteLine("Subset {0}{4}{1}{4}{2}{4}{3} = 0", input[1], input[2], input[3], input[4], "+");
                zeroSubset = true;
            }
            if (input[0] + input[1] + input[2] == 0)
            {
                Console.WriteLine("Subset {0}{3}{1}{3}{2} = 0", input[0], input[1], input[2], "+");
                zeroSubset = true;
            }
            if (input[0] + input[1] + input[3] == 0)
            {
                Console.WriteLine("Subset {0}{3}{1}{3}{2} = 0", input[0], input[1], input[3], "+");
                zeroSubset = true;
            }
            if (input[0] + input[1] + input[4] == 0)
            {
                Console.WriteLine("Subset {0}{3}{1}{3}{2} = 0", input[0], input[1], input[4], "+");
                zeroSubset = true;
            }
            if (input[0] + input[2] + input[3] == 0)
            {
                Console.WriteLine("Subset {0}{3}{1}{3}{2} = 0", input[0], input[2], input[3], "+");
                zeroSubset = true;
            }
            if (input[0] + input[2] + input[4] == 0)
            {
                Console.WriteLine("Subset {0}{3}{1}{3}{2} = 0", input[0], input[2], input[4], "+");
                zeroSubset = true;
            }
            if (input[0] + input[3] + input[4] == 0)
            {
                Console.WriteLine("Subset {0}{3}{1}{3}{2} = 0", input[0], input[3], input[4], "+");
                zeroSubset = true;
            }
            if (input[1] + input[2] + input[3] == 0)
            {
                Console.WriteLine("Subset {0}{3}{1}{3}{2} = 0", input[1], input[2], input[3], "+");
                zeroSubset = true;
            }
            if (input[1] + input[2] + input[4] == 0)
            {
                Console.WriteLine("Subset {0}{3}{1}{3}{2} = 0", input[1], input[2], input[4], "+");
                zeroSubset = true;
            }
            if (input[1] + input[3] + input[4] == 0)
            {
                Console.WriteLine("Subset {0}{3}{1}{3}{2} = 0", input[1], input[3], input[4], "+");
                zeroSubset = true;
            }
            if (input[2] + input[3] + input[4] == 0)
            {
                Console.WriteLine("Subset {0}{3}{1}{3}{2} = 0", input[2], input[3], input[4], "+");
                zeroSubset = true;
            }
            if (input[0] + input[1] == 0)
            {
                Console.WriteLine("Subset {0}{2}{1} = 0", input[0], input[1], "+");
                zeroSubset = true;
            }
            if (input[0] + input[2] == 0)
            {
                Console.WriteLine("Subset {0}{2}{1} = 0", input[0], input[2], "+");
                zeroSubset = true;
            }
            if (input[0] + input[3] == 0)
            {
                Console.WriteLine("Subset {0}{2}{1} = 0", input[0], input[3], "+");
                zeroSubset = true;
            }
            if (input[0] + input[4] == 0)
            {
                Console.WriteLine("Subset {0}{2}{1} = 0", input[0], input[4], "+");
                zeroSubset = true;
            }
            if (input[1] + input[2] == 0)
            {
                Console.WriteLine("Subset {0}{2}{1} = 0", input[1], input[2], "+");
                zeroSubset = true;
            }
            if (input[1] + input[3] == 0)
            {
                Console.WriteLine("Subset {0}{2}{1} = 0", input[1], input[3], "+");
                zeroSubset = true;
            }
            if (input[1] + input[4] == 0)
            {
                Console.WriteLine("Subset {0}{2}{1} = 0", input[1], input[4], "+");
                zeroSubset = true;
            }
            if (input[2] + input[3] == 0)
            {
                Console.WriteLine("Subset {0}{2}{1} = 0", input[2], input[3], "+");
                zeroSubset = true;
            }
            if (input[2] + input[4] == 0)
            {
                Console.WriteLine("Subset {0}{2}{1} = 0", input[2], input[4], "+");
                zeroSubset = true;
            }
            if (input[3] + input[4] == 0)
            {
                Console.WriteLine("Subset {0}{2}{1} = 0", input[3], input[4], "+");
                zeroSubset = true;
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 0)
                {
                    Console.WriteLine("Subset {0} = 0", input[i]);
                    zeroSubset = true;
                }
            }
            if (!zeroSubset)
            {
                Console.WriteLine("No subset of {0}{5}{1}{5}{2}{5}{3}{5}{4} has a sum of 0.", input[0], input[1], input[2], input[3], input[4], join);
            }
        }
        else
        {
            Console.WriteLine("No subset of {0}{5}{1}{5}{2}{5}{3}{5}{4} has a sum of 0.", input[0], input[1], input[2], input[3], input[4], join);
        }
    }
}
