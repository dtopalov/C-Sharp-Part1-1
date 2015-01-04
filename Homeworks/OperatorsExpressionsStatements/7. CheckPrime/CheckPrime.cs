using System;

class CheckPrime
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter an integer >= 2:");
        int input = Convert.ToInt32(Console.ReadLine());
        bool isPrime = true;
        for (int i = 2; i <= Math.Sqrt(input); i++)
        {
            if (input%i == 0)
            {
                isPrime = false;
            }
        }
        if (isPrime)
        {
            Console.WriteLine(input + " is prime.");
        }
        else
        {
            Console.WriteLine(input + " is not prime.");
        }
    }
}
