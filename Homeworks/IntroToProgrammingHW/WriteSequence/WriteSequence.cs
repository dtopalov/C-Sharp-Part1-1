using System;

 class WriteSequence
    {
        static void Main()
        {
            for (int i = 2; i <= 10;)
            {
                Console.WriteLine(i++);
                Console.WriteLine(-i++);
            }
        }
    }

