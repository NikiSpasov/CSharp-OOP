using System;
using System.Collections.Generic;
using System.Linq;

public class CardGame
{
    public static List<Card> FirstPlayerCards = new List<Card>();
    public static List<Card> SecondPlayerCards = new List<Card>();
    private static readonly List<string> cardsThrown = new List<string>();

    public CardGame()
    {

    }

    public void StartGame()
    {
        string firstPlayer = Console.ReadLine();
        string secondPlayer = Console.ReadLine();

        int cnt = 0;

        while (cnt < 5)
        {
            Card currentCard;
            string input = "";
            try
            {
                input = Console.ReadLine();
                string[] inputArray = input.Split();
                currentCard = new Card(inputArray[0], inputArray[2]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); 
                continue;
            }
            //check if it's in the deck
            if (cardsThrown.Contains(input))
            {
                Console.WriteLine("Card is not in the deck.");
                continue;
            }
            cardsThrown.Add(input);
            FirstPlayerCards.Add(currentCard);
            cnt++;
        }
        cnt = 0;
        while (cnt < 5)
        {
            Card currentCard;
            string input = "";
            try
            {
                input = Console.ReadLine();
                string[] inputArray = input.Split();
                currentCard = new Card(inputArray[0], inputArray[2]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                continue;
            }
            //check if it's in the deck
            if (cardsThrown.Contains(input))
            {
                Console.WriteLine("Card is not in the deck.");
                continue;
            }
            cardsThrown.Add(input);
            SecondPlayerCards.Add(currentCard);
            cnt++;
        }

        Card firstPlayerHighestCard = FirstPlayerCards.OrderBy(x => x.CardPower).Last();
        Card secondPlayerHighestCard = SecondPlayerCards.OrderBy(x => x.CardPower).Last();
        if (firstPlayerHighestCard.CardPower < secondPlayerHighestCard.CardPower)
        {
            Console.WriteLine($"{secondPlayer} wins with {secondPlayerHighestCard.Rank} " +
                              $"of {secondPlayerHighestCard.Suit}.");
        }
        else
        {
            Console.WriteLine($"{firstPlayer} wins with {firstPlayerHighestCard.Rank} " +
                              $"of {firstPlayerHighestCard.Suit}.");
        }


    }
}

