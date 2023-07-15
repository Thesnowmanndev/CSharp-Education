using System.Collections.Generic;

namespace MiniProjectAbstractClass
{
    public class BlackjackDeck : Deck
    {
        private const int MaxCardsInHand = 2;

        public BlackjackDeck()
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

        public PlayingCardModel RequestCard()
        {
            return DrawOneCard();
        }
    }
}
