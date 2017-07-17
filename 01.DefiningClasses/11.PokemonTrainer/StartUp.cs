using System;
using System.Collections.Generic;
using System.Linq;
public class StartUp
{
    public static void Main()
    {
        List<Trainer> trainers = new List<Trainer>();
        Dictionary<string, Trainer> trainersPokemons = new Dictionary<string, Trainer>();


        string textLine = Console.ReadLine();
        while (textLine != "Tournament")
        {
            string[] input = textLine
                .Split(separator: new[] { ' ', ',', '\n', '\t', '\r' },
                    options: StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Pokemon currentPokemon = new Pokemon(input[1], input[2], int.Parse(input[3]));

            if (!trainersPokemons.ContainsKey(input[0]))
            {
                List<Pokemon> currentList = new List<Pokemon> { currentPokemon };
                Trainer currentTrainer = new Trainer(input[0],  0, currentList);
                trainersPokemons.Add(key: input[0], value: currentTrainer);
                textLine = Console.ReadLine();
                continue;
            }
            trainersPokemons[key: input[0]].Pokemons.Add(item: currentPokemon);
            textLine = Console.ReadLine();
        }

        string command = Console.ReadLine();

        while (command != "End")
        {
            foreach (var trainer in trainersPokemons)
            {
                Pokemon isHere = trainer.Value.Pokemons.Find(x => x.Element == command);

                if (isHere != null)
                {
                    trainer.Value.NumberOfBadges += 1;
                    continue;
                }

                foreach (var pockemon in trainer.Value.Pokemons)
                {
                    pockemon.Health -= 10;
                }
                for (int i = 0; i < trainer.Value.Pokemons.Count; i++)   
                {
                    if (trainer.Value.Pokemons[i].Health <= 0)
                    {
                        trainer.Value.Pokemons.Remove(trainer.Value.Pokemons[i]);
                    }      
                }
            }
            command = Console.ReadLine();
        }
        foreach (var trainer in trainersPokemons.OrderByDescending(x => x.Value.NumberOfBadges))
        {
            Console.WriteLine($"{trainer.Value.Name} {trainer.Value.NumberOfBadges} {trainer.Value.Pokemons.Count}");
        }
    }
}