//Problem 9. Play with Int, Double and String

//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.

using System;
using System.Globalization;
using System.Threading;

class DifferentTypesOfInput
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Choose type:\n1 for int\n2 for double\n3 for string");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Please enter an integer: ");
                    int input1 = int.Parse(Console.ReadLine());
                    Console.WriteLine(input1 + 1);
                    break;
                case 2: 
                    Console.Write("Please enter a double: ");
                    double input2 = double.Parse(Console.ReadLine());
                    Console.WriteLine(input2 + 1);
                    break;
                case 3:
                    Console.Write("Please, enter a string: ");
                    string input3 = Console.ReadLine();
                    Console.WriteLine(input3 + "*");
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
