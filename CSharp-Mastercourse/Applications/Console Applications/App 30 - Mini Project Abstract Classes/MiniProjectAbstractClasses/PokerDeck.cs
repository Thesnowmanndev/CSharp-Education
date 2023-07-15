using System.Collections.Generic;

namespace MiniProjectAbstractClass
{
    public class PokerDeck : Deck
    {
        private const int MaxCardsInHand = 5;

        public PokerDeck()
        {
            CreateDeck();
            ShuffleDeck();
        }

        public override List<PlayingCardModel> DealCards()
        {
            List<PlayingCardModel> handOfCards = new List<PlayingCardModel>();
            for (int i = 0; i < MaxCardsInHand; i++)
            {
                handOfCards.Add(DrawOneCard());
            }

            return handOfCards;
        }

        public List<PlayingCardModel> RequestCards(List<PlayingCardModel> cardsToDiscard)
        {
            List<PlayingCardModel> handOfCards = new List<PlayingCardModel>();

            foreach (var card in cardsToDiscard)
            {
                handOfCards.Add(DrawOneCard());
                discardPile.Add(card);
            }

            return handOfCards;
        }
    }
}
