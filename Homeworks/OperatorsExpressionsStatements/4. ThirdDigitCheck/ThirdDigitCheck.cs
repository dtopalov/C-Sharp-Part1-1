using System;

class ThirdDigitCheck
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter an integer:");
        int input = Math.Abs(Convert.ToInt32(Console.ReadLine()));
        bool check = (input / 100) % 10 == 7;
        Console.WriteLine("The third digit (right-to-left) of " + input + " is 7 --> " + check);
    }
}
