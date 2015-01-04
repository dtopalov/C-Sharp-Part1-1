using System;

class GreatestVariable
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number var1:");
        double var1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter a number var2:");
        double var2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter a number var3:");
        double var3 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter a number var4:");
        double var4 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter a number var5:");
        double var5 = double.Parse(Console.ReadLine());
        bool check = false;
        double maxvar = var1;
        int maxindex = 1;

        if (maxvar == var2) {
            check = true;
        }
        if (var2 > maxvar) {
            maxvar = var2;
            check = false;
            maxindex = 2;
        }
        if (maxvar == var3) {
            check = true;
        }
        if (var3 > maxvar) {
            maxvar = var3;
            check = false;
            maxindex = 3;
        }
        if (maxvar == var4) {
            check = true;
        }
        if (var4 > maxvar) {
            maxvar = var4;
            check = false;
            maxindex = 4;
        }
        if (maxvar == var5) {
            check = true;
        }
        if (var5 > maxvar) {
            maxvar = var5;
            check = false;
            maxindex = 5;
        }
        if (check) {
            Console.WriteLine("Two or more of the greatest variables are equal.");
        }
        else {
            switch (maxindex) {
                case 1: Console.WriteLine("Var 1 is the greatest."); break;
                case 2: Console.WriteLine("Var 2 is the greatest."); break;
                case 3: Console.WriteLine("Var 3 is the greatest."); break;
                case 4: Console.WriteLine("Var 4 is the greatest."); break;
                case 5: Console.WriteLine("Var 5 is the greatest."); break;
            }
        }
    }
}

