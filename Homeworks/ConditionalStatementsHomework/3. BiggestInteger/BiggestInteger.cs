using System;

class BiggestInteger
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an integer a:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter an integer b:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter an integer c:");
        int c = int.Parse(Console.ReadLine());
        if ((a == b && b == c) || (a == b && a > c) || (a == c && a > b) || (b == c && b > a)) 
        {
            Console.WriteLine("Greatest number cannot be determined.");
        }
        if (a > b && a > c) 
        {
            Console.WriteLine("A is greatest.");
        }
        if (b > a && b > c) 
        {
            Console.WriteLine("B is greatest.");
        }
        if (c > a && c > b) 
        {
            Console.WriteLine("C is greatest.");
        }
    }
}
