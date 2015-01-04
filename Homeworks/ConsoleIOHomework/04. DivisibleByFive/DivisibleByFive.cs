using System;

class DivisibleByFive
{
    static void Main()
    {
        Console.WriteLine("Enter positive integer number a: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter positive integer number b: ");
        int b = int.Parse(Console.ReadLine());
        int count = 0;
        if (a <= b)
        {
            for (int i = a; i <= b; i++)
            {
                if (i%5 == 0)
                {
                    count++;
                }
            }
        }
        else
        {
            for (int i = b; i <= a; i++)
            {
                if (i % 5 == 0)
                {
                    count++;
                }
            }
        }
        Console.WriteLine("p(" + a + "," + b + ")" + "=" + count);
    }
}
