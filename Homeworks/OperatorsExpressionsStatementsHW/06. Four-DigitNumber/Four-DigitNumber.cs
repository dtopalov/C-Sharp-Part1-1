//Problem 6. Four-Digit Number

//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Puts the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0.

using System;

class FourDigitNumber
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a 4-digit number: ");
        string inputNumber = Console.ReadLine();
        int sum = 0;
        string lastDigitFirst = "";
        string reversedNumber = "";
        string secondAndThirdExchanged = "";
        for (int i = 0; i < inputNumber.Length; i++)
        {
            sum += int.Parse(inputNumber[i].ToString());
            reversedNumber += inputNumber[inputNumber.Length - i - 1];
            if (i > 0 && i < inputNumber.Length - 1)
            {
                secondAndThirdExchanged += inputNumber[inputNumber.Length - i - 1];
            }
            else
            {
                secondAndThirdExchanged += inputNumber[i];
            }
        }
        for (int i = inputNumber.Length - 1; i >= 1; i--)
        {
            if (i == inputNumber.Length - 1)
            {
                lastDigitFirst += inputNumber[inputNumber.Length - 1];
            }
            lastDigitFirst += inputNumber[inputNumber.Length - 1 - i];
        }
        Console.WriteLine("Number: {0}\nSum of digits: {1}\nReversed: {2}\nLast digit in front: {3}\n2nd and 3rd digit in front: {4}"
            , inputNumber, sum, reversedNumber, lastDigitFirst, secondAndThirdExchanged);
    }
}