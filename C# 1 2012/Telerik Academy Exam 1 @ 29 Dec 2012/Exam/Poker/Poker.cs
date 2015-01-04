using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    class Poker
    {
        static void Main(string[] args)
        {
            int[] hand = new int[5];
            int equal1 = 1;
            int equal2 = 1;

            for (int i = 0; i < 5; i++)
            {
                string card = Console.ReadLine();
                if (card == "A")
                {
                    hand[i] = 1;
                }
                else if (card == "J")
                {
                    hand[i] = 11;
                }
                else if (card == "Q")
                {
                    hand[i] = 12;
                }
                else if (card == "K")
                {
                    hand[i] = 13;
                }
                else
                {
                    hand[i] = int.Parse(card);
                }
            }
            Array.Sort(hand);
            if (hand[0] == hand[4])
            {
                Console.WriteLine("Impossible");
            }
            else if (hand[0] == hand[3] || hand[1] == hand[4])
            {
                Console.WriteLine("Four of a Kind");
            }
            else if ((hand[0] == hand[2] && hand[3] == hand[4]) || (hand[0] == hand[1] && hand[2] == hand[4]))
            {
                Console.WriteLine("Full House");
            }
            else if (hand[0] + 1 == hand[1] && hand[1] + 1 == hand[2] &&
                hand[2] + 1 == hand[3] && hand[3] + 1 == hand[4]||
                (hand[0] == 1 && hand[1] == 10 &&
                hand[2] == 11 && hand[3] == 12 && hand[4] == 13))
            {
                Console.WriteLine("Straight");
            }
            else if (hand[0] == hand[2] || hand[1] == hand[3] || hand[2] == hand[4])
            {
                Console.WriteLine("Three of a Kind");
            }
            else if (hand[0] == hand[1] && (hand[2] == hand[3] || 
                hand[3] == hand[4]) || hand[1] == hand[2] && hand[3] == hand[4])
            {
                Console.WriteLine("Two Pairs");
            }
            else if (hand[0] == hand[1] || hand[1] == hand[2] || hand[2] == hand[3] || hand[3] == hand[4])
            {
                Console.WriteLine("One Pair");
            }
            else
            {
                Console.WriteLine("Nothing");
            }
        }
    }
}
