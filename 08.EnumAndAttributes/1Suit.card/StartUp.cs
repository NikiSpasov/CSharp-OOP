using System;

public class StartUp
{
    static void Main()
    {
        string input = Console.ReadLine();
        if (input == "Card Suits")
        {
            var cardSuits = Enum.GetValues(typeof(CardSuits));
            Console.WriteLine("Card Suits:");
            foreach (var cardSuit in cardSuits)
            {

                Console.WriteLine(
                    $"Ordinal value: {(int)cardSuit}; Name value: {cardSuit}");
            }
        }
    }
}

