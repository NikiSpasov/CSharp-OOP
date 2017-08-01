using System;

public class StartUp
{
    static void Main()
    {
        string input = Console.ReadLine();
        if (input == "Card Ranks")
        {
            var cardSuits = Enum.GetValues(typeof(CardRanks));
            Console.WriteLine("Card Ranks:");
            foreach (var cardSuit in cardSuits)
            {
                Console.WriteLine(
                    $"Ordinal value: {(int)cardSuit}; Name value: {cardSuit}");
            }
        }
    }
}

