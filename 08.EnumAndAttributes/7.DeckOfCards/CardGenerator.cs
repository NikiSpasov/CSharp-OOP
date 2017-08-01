using System;

public class CardGenerator
{
    public void Run()
    {
        for (int i = 0; i < 4; i++)
        {
            var suit = (Suit)Enum.Parse(typeof(Suit), i.ToString());
            for (int j = 1; j < 14; j++)
            {
                var rank = (Rank)Enum.Parse(typeof(Rank), j.ToString());
                Console.WriteLine($"{rank} of {suit}");
            }
        }
    }
}

