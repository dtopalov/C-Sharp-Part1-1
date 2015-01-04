using System;

class SumOfSequence
{
    static void Main()
    {
        double lastSum = 1;
        double currentSum = 1;
        int i = 1;
        do
        {
            lastSum = currentSum;
            i++;
            if (i%2 == 0)
            {
                currentSum = lastSum + 1.0 / i;
            }
            else
            {
                currentSum = lastSum - 1.0 / i;
            }
        } while (Math.Abs(currentSum - lastSum) > 0.001);
        Console.WriteLine("The sum (with accuracy of 0.001) of 1+1/2-1/3+1/4-1/5... = " + currentSum);
    }
}
