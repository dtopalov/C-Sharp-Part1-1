using System;

class DrunkenNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int vladkoBeers = 0;
        int mitkoBeers = 0;
        for (int i = 0; i < n; i++)
        {
            int drunkNumber = Math.Abs(int.Parse(Console.ReadLine()));
            string numberStr = drunkNumber.ToString();
            for (int j = 0; j < numberStr.Length; j++)
            {
                if (numberStr.Length%2 == 0)
                {
                    if (j < numberStr.Length/2)
                    {
                        mitkoBeers += int.Parse(numberStr[j].ToString());
                    }
                    else
                    {
                        vladkoBeers += int.Parse(numberStr[j].ToString());
                    }
                }
                else
                {
                    if (j <= numberStr.Length / 2)
                    {
                        mitkoBeers += int.Parse(numberStr[j].ToString());
                    }
                    if (j >= numberStr.Length / 2)
                    {
                        vladkoBeers += int.Parse(numberStr[j].ToString());
                    }
                }
            }
        }
        if (mitkoBeers > vladkoBeers)
        {
            Console.WriteLine("M {0}", mitkoBeers - vladkoBeers);
        }
        else if (vladkoBeers > mitkoBeers)
        {
            Console.WriteLine("V {0}", vladkoBeers - mitkoBeers);
        }
        else
        {
            Console.WriteLine("No {0}", mitkoBeers + vladkoBeers);
        }
    }
}
