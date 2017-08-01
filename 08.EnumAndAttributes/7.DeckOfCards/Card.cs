using System;

public class Card : IComparable<Card>
{
    public Rank Rank;
    public Suit Suit;
    public int CardPower;

    public Card(string card, string suit)
    {
        if (Enum.TryParse(card, true, out Rank) && Enum.TryParse(suit, true, out Suit))
        {
            CardPower = GetPower();
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

