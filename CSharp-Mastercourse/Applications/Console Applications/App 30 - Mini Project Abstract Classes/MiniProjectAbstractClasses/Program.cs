using System;

namespace MiniProjectAbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PokerDeck pokerDeck = new PokerDeck();

            var pokerHand = pokerDeck.DealCards();

            Console.WriteLine("\nCards in your poker hand:\n");
            foreach (var card in pokerHand)
            {
                Console.WriteLine($"{card.Value.ToString()} of {card.Suit.ToString()}");
            }

            BlackjackDeck blackjackDeck = new BlackjackDeck();

            var blackjackHand = blackjackDeck.DealCards();

            Console.WriteLine("\nCards in your Blackjack hand:\n");
            foreach (var card in blackjackHand)
            {
                Console.WriteLine($"{card.Value.ToString()} of {card.Suit.ToString()}");
            }

            Console.ReadLine();
        }
    }
}
