using System;

class AddThreeIntegers
{
    static void Main()
    {
        Console.WriteLine("Enter integer a: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter integer b: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter integer c: ");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine(a + "+" + b + "+" + c + "=" + (a + b + c));
    }
}
