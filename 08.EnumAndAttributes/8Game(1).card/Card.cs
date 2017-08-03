using System;
using System.Collections.Generic;
using System.Threading;

public class Card : IComparable<Card>
{
    public Rank Rank;
    public Suit Suit;
    public int CardPower;
 

    public Card(string card, string suit)
    {
        if (Enum.TryParse(card, false, out Rank) && Enum.TryParse(suit, false, out Suit))
        {
            CardPower = GetPower();
        }
        else
        {
            throw new ArgumentException("No such card exists.");
        }
    }

    public int GetPower()
    {
        int pointFromRank = (int)Rank;
        int pointsFromSuit = (int)Suit;
        return pointsFromSuit + pointFromRank;
    }

    public int CompareTo(Card other)
    {
        int result = this.CardPower.CompareTo(other.CardPower);
        return result;
    }

    public override string ToString()
    {
        return $"Card name: {Rank} of {Suit}; Card power: {CardPower}";
    }
}

