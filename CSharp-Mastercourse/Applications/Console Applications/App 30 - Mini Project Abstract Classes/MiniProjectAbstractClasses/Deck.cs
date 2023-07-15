using System;
using System.Collections.Generic;
using System.Linq;

namespace MiniProjectAbstractClass
{
    public abstract class Deck
    {
        protected List<PlayingCardModel> fullDeck = new List<PlayingCardModel>();
        protected List<PlayingCardModel> drawPile = new List<PlayingCardModel>();
        protected List<PlayingCardModel> discardPile = new List<PlayingCardModel>();

        private const int MaxNumberOfSuits = 4;
        private const int MaxValueOfCard = 13;

        protected void CreateDeck()
        {
            fullDeck.Clear();

            for (int suit = 0; suit < MaxNumberOfSuits; suit++)
            {
                for(int value = 0; value < MaxValueOfCard; value++)
                {
                    fullDeck.Add(new PlayingCardModel { Suit = (CardSuit)suit, Value = (CardValue)value });
                }
            }
        }

        public virtual void ShuffleDeck()
        {
            var rand = new Random();
            drawPile = fullDeck.OrderBy(x => rand.Next()).ToList();
        }

        public abstract List<PlayingCardModel> DealCards();

        protected virtual PlayingCardModel DrawOneCard()
        {
            PlayingCardModel output = drawPile.Take(1).First();
            drawPile.Remove(output);
            return output;
        }
    }
}
