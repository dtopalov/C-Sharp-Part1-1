using System;
using System.Threading;

class Cards
{
    static void Main()
    {
        string suit;
        int rank = 2;
        int count = 1;
        string name = "";

        while (count <= 52)
        {
            switch (rank)
            {
                case 2:
                    name = "two";
                    break;
                case 3:
                    name = "three";
                    break;
                case 4:
                    name = "four";
                    break;
                case 5:
                    name = "five";
                    break;
                case 6:
                    name = "six";
                    break;
                case 7:
                    name = "seven";
                    break;
                case 8:
                    name = "eight";
                    break;
                case 9:
                    name = "nine";
                    break;
                case 10:
                    name = "ten";
                    break;
                case 11:
                    name = "jack";
                    break;
                case 12:
                    name = "queen";
                    break;
                case 13:
                    name = "king";
                    break;
                case 14:
                    name = "ace";
                    break;
            }
            if (rank < 14)
            {
                rank++;
            }
            else
            {
                rank = 2;
            }
            if (count < 14)
            {
                suit = "spades";
            }
            else if (count >= 14 && count < 27)
            {
                suit = "hearts";
            }
            else if (count >= 27 && count < 40)
            {
                suit = "diamonds";
            }
            else
            {
                suit = "clubs";
            }
            count++;
            if ((count-2)%13 == 0)
            {
                Console.WriteLine(new string('=', 8) + suit.ToUpper() + new string('=', 8));
            }
            Console.WriteLine("{0} of {1}", name, suit);
        }
    }
}
