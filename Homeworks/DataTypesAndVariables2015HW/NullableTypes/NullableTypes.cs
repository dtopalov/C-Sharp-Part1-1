//Problem 12. Null Values Arithmetic

//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

using System;

class NullableTypes
{
    static void Main(string[] args)
    {
        int? nullableInteger = null;
        double? nullableDouble = null;
        bool nullCheck = nullableInteger == null && nullableDouble == null;

        Console.WriteLine("Integer with value Null: " + nullableInteger);
        Console.WriteLine("Double with value Null: " + nullableDouble);
        Console.WriteLine("nullableInteger == null && nullableDouble == null --> " + nullCheck);

        nullableInteger = 10;
        nullableDouble = 10.25;

        Console.WriteLine("Integer with new value: " + nullableInteger);
        Console.WriteLine("Double with new value: " + nullableDouble);
    }
}