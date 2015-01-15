//Problem 10. Odd and Even Product

//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

using System;

class OddEvenProduct
{
    static void Main(string[] args)
    {
        Console.Write("Enter numbers: ");
        string input = Console.ReadLine();
        int count = 0;
        long productOdd = 1;
        long productEven = 1;
        string number = "";
        for (int i = 0; i < input.Length; i++)
        {
            number = "";
            while (input[i] != ' ' && i < input.Length)
            {
                number += input[i];
                if (i < input.Length - 1)
                {
                    i++;
                }
                else
                {
                    break;
                }
            }
            count++;
            if (count % 2 == 0)
            {
                productEven *= int.Parse(number);
            }
            else
            {
                productOdd *= int.Parse(number);
            }
        }
        if (productEven == productOdd)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
