//Problem 17.* Calculate GCD

//Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
//Use the Euclidean algorithm (find it in Internet).

using System;

class EuclideanAlgorithm
{
    static void Main()
    {
        Console.Write("Enter an integer X: ");
        int inputX = int.Parse(Console.ReadLine());
        Console.Write("Enter an integer Y: ");
        int inputY = int.Parse(Console.ReadLine());
        int X = Math.Abs(inputX);
        int Y = Math.Abs(inputY);

        while (true)
        {
            if (X < Y)
            {
                int temp = X;
                X = Y;
                Y = temp;
            }
            int remainder = X%Y;
            if (remainder == 0)
            {
                Console.WriteLine("{0} is the greatest common divisor of {1} and {2}.", Y, inputX, inputY);
                break;
            }
            X = Y;
            Y = remainder;
        }
    }
}
