using System;


class AgeAfterTenYears
    {
        static void Main()
        {
            Console.WriteLine("Enter your age:");
            int myage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("In ten years you will be " + (myage + 10));
        }
    }
