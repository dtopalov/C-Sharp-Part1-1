//Problem 1. Declare Variables

//Declare five variables choosing for each of them the most appropriate of the types 
//byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
//Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
//Submit the source code of your Visual Studio project as part of your homework submission.

using System;

class DeclareVariables
{
    static void Main(string[] args)
    {
        ushort firstVar = 52130;
        sbyte secondVar = -115;
        int thirdVar = 4825932;
        byte fourthVar = 97;
        short fifthVar = -10000;
        Console.WriteLine("Ushort variable: " + firstVar + "; \nsbyte variable: "
                            + secondVar + "; \nint variable: "
                            + thirdVar + "; \nbyte variable: "
                            + fourthVar + "; \nshort variable: "
                            + fifthVar);
    }
}
