using System;

class DifferentTypesInput
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter int, double or string:");
        string input = Console.ReadLine();
        double number;
        bool numberCheck = double.TryParse(input, out number);
        switch (numberCheck)
        {
            case true:
                Console.WriteLine("Input number + 1 is " + (number + 1));
                break;
            case false:
                Console.WriteLine("Input string with appended * is: " + input + "*");
                break;
        }
    }
}
