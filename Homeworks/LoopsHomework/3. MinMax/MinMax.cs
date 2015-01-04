using System;

class MinMax
{
    static void Main()
    {
        Console.WriteLine("Enter a number N:");
        int N = int.Parse(Console.ReadLine());
        int input;
        int min = int.MaxValue;
        int max = int.MinValue;
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine("Enter an integer:");
            input = int.Parse(Console.ReadLine());
            if (input <= min)
            {
                min = input;
            }
            if (input >= max)
            {
                max = input;
            }
        }
        Console.WriteLine("The smallest of the entered integers is: {0}\nThe greatest of the entered integers is: {1}", min, max);
    }
}

