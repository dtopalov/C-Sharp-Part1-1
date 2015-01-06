using System;


class AgeAfterTenYears
    {
        static void Main()
        {
            Console.WriteLine("Enter your birthday(DD/MM/YYYY):");
            DateTime birthday = Convert.ToDateTime(Console.ReadLine());
            DateTime today = DateTime.Today;
            int age = 0;
            if (today.Month < birthday.Month)
            {
                age = today.Year - birthday.Year - 1;
            }
            else if (today.Month > birthday.Month)
            {
                age = today.Year - birthday.Year;
            }
            else
            {
                if (today.Day < birthday.Day)
                {
                    age = today.Year - birthday.Year - 1;
                }
                else
                {
                    age = today.Year - birthday.Year;
                }
            }
            Console.WriteLine("Your age is {0} and in 10 years it will be {1}", age, age + 10);
        }
    }
