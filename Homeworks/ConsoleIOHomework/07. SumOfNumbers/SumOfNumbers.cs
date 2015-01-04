using System;

class SumOfNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter an integer N:");
        int n = int.Parse(Console.ReadLine());
        double sum = 0.0;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter a number:");
            double input = double.Parse(Console.ReadLine());
            sum += input;
        }
        Console.WriteLine("The sum of entered numbers is: " + sum);
    }
}
