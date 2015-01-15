//Problem 4. Print a Deck of 52 Cards

//Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). 
//The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//The card faces should start from 2 to A.
//Print each card face in its four possible suits: clubs, diamonds, hearts and spades. 

using System;

class DeckOfCards
{
    static void Main(string[] args)
    {
        string[] suit = {"spades", "clubs", "hearts", "diamonds"};
        string[] value = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};

        for (int i = 0; i < value.Length; i++)
        {
            for (int j = 0; j < suit.Length; j++)
            {
                Console.Write("{0} of {1}", value[i], suit[j]);
                if (j < suit.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }
}
