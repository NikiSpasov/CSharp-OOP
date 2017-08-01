using System;

public class StartUp
{
    public static void Main()
    {
        string rank = Console.ReadLine();
        string suit = Console.ReadLine();
        string rankSecondCard = Console.ReadLine();
        string suitSecondCard = Console.ReadLine();

        Card firstCard = new Card(rank, suit);
        Card secondCard = new Card(rankSecondCard, suitSecondCard);

        if (firstCard.CompareTo(secondCard) < 0)
        {
            Console.WriteLine(secondCard);
            return;
        }
        Console.WriteLine(firstCard);

    }
}

