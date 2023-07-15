# Mini Project - Practice Abstract Classes

This project was created while following along with Tim Corey's C Sharp Mastercourse. It is the Mini Project at the end of the Modifiers, Abstract, and Overrides section. The goal of the project is to practice using protected keywords, abstract classes, and virtual classes.

## Preview 

![Application](https://github.com/Thesnowmanndev/CSharp-Education/blob/main/CSharp-Mastercourse/Applications/Console%20Applications/App%2030%20-%20Mini%20Project%20Abstract%20Classes/Application.png?raw=true)

## Enums
```C#
public enum CardSuit
{
    Clubs,
    Diamonds,
    Hearts,
    Spades
}

public enum CardValue
{
    Ace,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten,
    Jack,
    Queen,
    King
}
```

## Deck Class

```C#
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
```

## Poker Deck

```C#
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
```

## Blackjack Deck

```C#
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
```

## PlayingCardModel

```C#
public class PlayingCardModel
{
    public CardSuit Suit { get; set; }
    public CardValue Value { get; set; }
}
```

## Program

```C#
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

```

### References - 

Private : https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/private

Protected : https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/public

Protected : https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/protected

Virtual : https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/virtual

Abstract: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/abstract 

Internal : https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/internal

Const : https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/const 

Override : https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/override 

List : https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-7.0 

