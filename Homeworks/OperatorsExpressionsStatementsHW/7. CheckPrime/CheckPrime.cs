//Problem 8. Prime Number Check

//Write an expression that checks if given positive integer number n (n = 100) is prime 
//(i.e. it is divisible without remainder only to itself and 1).

using System;

class CheckPrime
{
    static void Main(string[] args)
    {
        Console.Write("Please enter an integer >= 2: ");
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
