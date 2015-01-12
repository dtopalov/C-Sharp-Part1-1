//Problem 9. Play with Int, Double and String

//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.

using System;
using System.Globalization;
using System.Threading;

class DifferentTypesInput
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Please enter number or string: ");
        string input = Console.ReadLine();
        double number;
        bool numberCheck = double.TryParse(input, out number);
        if (numberCheck)
        {
            Console.WriteLine("Input number + 1 is " + (number + 1));
        }
        else
        {
            Console.WriteLine("Input string with appended * is: " + input + "*");
        }
    }
}
