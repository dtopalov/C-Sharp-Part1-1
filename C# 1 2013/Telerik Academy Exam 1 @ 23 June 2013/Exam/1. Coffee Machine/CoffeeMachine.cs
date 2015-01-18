using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class CoffeeMachine
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double moneyInMachine = 0;
        moneyInMachine += int.Parse(Console.ReadLine()) * 0.05;
        moneyInMachine += int.Parse(Console.ReadLine()) * 0.1;
        moneyInMachine += int.Parse(Console.ReadLine()) * 0.2;
        moneyInMachine += int.Parse(Console.ReadLine()) * 0.5;
        moneyInMachine += int.Parse(Console.ReadLine()) * 1.0;
        double moneyPaid = double.Parse(Console.ReadLine());
        double price = double.Parse(Console.ReadLine());
        double change = moneyPaid - price;
        if (change >= 0)
        {
            if (moneyInMachine >= change)
            {
                Console.WriteLine("{0} {1:F2}", "Yes", moneyInMachine - change);   
            }
            else
            {
                Console.WriteLine("{0} {1:F2}", "No", Math.Abs(moneyInMachine - change));
            }
        }
        else
        {
            Console.WriteLine("{0} {1:F2}", "More", Math.Abs(price - moneyPaid));
        }
    }
}

