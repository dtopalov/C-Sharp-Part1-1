//Problem 2. Gravitation on the Moon

//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

using System;
using System.Globalization;
using System.Threading;

class GravitationOnTheMoon
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Please enter weight: ");
        double weightOnTheEarth = double.Parse(Console.ReadLine());
        double gravityRatio = 0.17;
        double weightOnTheMoon = weightOnTheEarth*gravityRatio;
        Console.WriteLine("Weight on the Earth: {0}\nWeight on the Moon: {1}", weightOnTheEarth, weightOnTheMoon);
    }
}

