using System;

class WithinCircle
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter coordinate X:");
        double coorX = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please enter coordinate Y:");
        double coorY = Convert.ToDouble(Console.ReadLine());
        int r = 5;
        bool checkK = (Math.Pow(coorX, 2) + Math.Pow(coorY, 2)) <= Math.Pow(r, 2);
        Console.WriteLine("The point (x,y) with coordinates (" + coorX + "," + coorY + ") is within circle K(0,5) --> " + checkK);
    }
}
