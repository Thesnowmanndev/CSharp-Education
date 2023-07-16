using CardGameLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameLibrary
{
    public class Holdem : DeckModel
    {
        private const int MaxCardsInHand = 2;
        private const int MinBoardCards = 2;
        private const int MaxBoardCards = 5;

        public Holdem() 
        {
            CreateDeck();
            ShuffleDeck();
        }

        public override List<PlayingCardModel> DealCards()
        {
            List<PlayingCardModel> playersHand = new List<PlayingCardModel>();
            for (int i = 0; i < MaxCardsInHand; i++)
            {
                playersHand.Add(DrawOneCard());
            }

            return playersHand;
        }

        public List<PlayingCardModel> DealOpponentsCards()
        {
            List<PlayingCardModel> opponentsHand = new List<PlayingCardModel>();
            for (int i = 0; i < MaxCardsInHand; i++)
            {
                opponentsHand.Add(DrawOneCard());
            }

            return opponentsHand;
        }

        public List<PlayingCardModel> DealBoardCards()
        {
            List<PlayingCardModel> board = new List<PlayingCardModel>();
            for ( int i = 0; i < MinBoardCards; i++)
            {
                board.Add(DrawOneCard());
            }

            return board;
        }
    }
}
