using CardGameLibrary.Enums;

namespace CardGameLibrary.Models
{
    public abstract class DeckModel
    {
        protected List<PlayingCardModel> fullDeck = new();
        protected List<PlayingCardModel> drawPile = new();
        protected List<PlayingCardModel> discardPile = new();

        private const int MaxNumberOfSuits = 4;
        private const int MaxValueOfCards = 13;

        protected void CreateDeck()
        {
            fullDeck.Clear();

            for (int suit = 0; suit < MaxNumberOfSuits; suit++)
            {
                for (int value = 0; value < MaxValueOfCards; value++)
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

        protected virtual PlayingCardModel DrawOneCard()
        {
            PlayingCardModel output = drawPile.Take(1).First();
            drawPile.Remove(output);
            return output;
        }

        public abstract List<PlayingCardModel> DealCards();
    }
}
