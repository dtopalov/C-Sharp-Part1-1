using System;

class SortNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number a:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter a number b:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter a number c:");
        double c = double.Parse(Console.ReadLine());
        if ((a == b) || (a == c) || (b == c)) {
            Console.WriteLine("The three numbers cannot be sorted because two or more are equal.");
        }
        if (a > b) {
            if (b > c) {
                Console.WriteLine("1st > 2nd > 3rd");
            }
            else {
                if (a > c) {
                    Console.WriteLine("1st > 3rd > 2nd");
                }
                else {
                    Console.WriteLine("3rd > 1st > 2nd");
                }
            }
        }
        if (b > c) {
            if (c > a) {
                Console.WriteLine("2nd > 3rd > 1st");
            }
            else {
                if (b > a) {
                    Console.WriteLine("2nd > 1st > 3rd");
                }
            }
        }
        if (c > b && b > a) {
            Console.WriteLine("3rd > 2nd > 1st");
        }
    }
}

