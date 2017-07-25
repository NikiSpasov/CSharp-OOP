using System;
using System.Collections;
using System.Collections.Generic;

public class StartUp
{
    static void Main()
    {
        for (int i = 0; i < 3; i++)
        {
            string[] input = Console.ReadLine().Split();
            if (i == 0)
            {
                string name = (input[0] + " " + input[1]);
                string place = input[2];
                string town = input[3];
                Threeuple<string, string, string> namePlaceTown = new Threeuple<string, string, string>(name, place, town);
                Console.WriteLine(namePlaceTown.Item1 + " -> " + namePlaceTown.Item2 + " -> " + namePlaceTown.Item3);
            }
            else if (i == 1)
            {
                bool drunk = input[2] == "drunk";
                Threeuple<string, int, bool> drinkBeers = new Threeuple<string, int, bool>(input[0], int.Parse(input[1]), drunk);
                Console.WriteLine(drinkBeers.Item1 + " -> " + drinkBeers.Item2 + " -> " + drinkBeers.Item3);
            }
            else
            {
                Threeuple<string, double, string> intDouble = 
                    new Threeuple<string, double, string>(input[0], double.Parse(input[1]), input[2]);
                Console.WriteLine(intDouble.Item1 + " -> " + intDouble.Item2 + " -> " + intDouble.Item3);
            }

        }
    }
}

