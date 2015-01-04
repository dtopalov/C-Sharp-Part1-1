using System;

class BonusScores
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a digit (1-9):");
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
                result = "Wrong input!";
                break;
        }
        Console.WriteLine(result);
    }
}

