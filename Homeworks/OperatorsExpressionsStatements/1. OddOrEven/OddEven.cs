using System;

class OddEven
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter an integer:");
        int input = Convert.ToInt32(Console.ReadLine());
        if (input%2 == 0)
        {
            Console.WriteLine(input + " is even.");
        }
        else
        {
            Console.WriteLine(input + " is odd.");
        }
    }
}