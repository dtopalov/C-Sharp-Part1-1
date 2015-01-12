//Problem 2. Bonus Score

//Write a program that applies bonus score to given score in the range [1…9] by the following rules:
//If the score is between 1 and 3, the program multiplies it by 10.
//If the score is between 4 and 6, the program multiplies it by 100.
//If the score is between 7 and 9, the program multiplies it by 1000.
//If the score is 0 or more than 9, the program prints “invalid score”.

using System;

class BonusScores
{
    static void Main(string[] args)
    {
        Console.Write("Enter a digit (1-9): ");
        var digit = Console.ReadLine();
        dynamic result;
        switch (digit)
        {
            case "1":
            case "2":
            case "3":
                result = int.Parse(digit)*10;
                break;
            case "4":
            case "5":
            case "6":
                result = int.Parse(digit) * 100;
                break;
            case "7":
            case "8":
            case "9":
                result = int.Parse(digit) * 1000;
                break;
            default:
                result = "Invalid score";
                break;
        }
        Console.WriteLine(result);
    }
}

