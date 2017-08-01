using System;

public class Card
{
    public CardRanks Rank;
    public CardSuit Suit;
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

    public override string ToString()
    {
        return $"Card name: {Rank} of {Suit}; Card power: {CardPower}";
    }
}

