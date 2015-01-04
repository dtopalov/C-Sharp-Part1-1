using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MathExpression
{
    class MathExpression
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            string N1 = Console.ReadLine();
            string M1 = Console.ReadLine();
            string P1 = Console.ReadLine();

            double N = Double.Parse(N1);
            double M = Double.Parse(M1);
            double P = Double.Parse(P1);

            double result = ((N*N + (1.0/(M * P)) + 1337)/(N - 128.523123123 * P)) + Math.Sin((int)M % 180);
            Console.WriteLine(result.ToString("0.000000", CultureInfo.InvariantCulture));
        }
    }
}
