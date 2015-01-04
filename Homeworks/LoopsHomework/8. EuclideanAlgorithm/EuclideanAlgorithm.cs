using System;

class EuclideanAlgorithm
{
    static void Main()
    {
        Console.WriteLine("Enter an integer X:");
        int inputX = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter an integer Y:");
        int inputY = int.Parse(Console.ReadLine());
        int X = inputX;
        int Y = inputY;

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
