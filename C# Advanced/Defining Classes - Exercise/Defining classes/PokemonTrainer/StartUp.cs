using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var trainers = new List<Trainer>();

            var command = Console.ReadLine();

            while (command!="Tournament")
            {
                var sep = command.Split().ToArray();
                var trainerName = sep[0];
                var pokemonName = sep[1];
                var element = sep[2];
                var health = int.Parse(sep[3]);
                var trainer = trainers.FirstOrDefault(x=>x.Name==trainerName);
                if (trainer!=null)
                {
                    trainer.Pokemons.Add(new Pokemon(pokemonName,element,health));
                }
                else
                {
                    var newTrainer = new Trainer(trainerName);
                    newTrainer.Pokemons.Add(new Pokemon(pokemonName, element, health));
                    trainers.Add(newTrainer);
                }
                command = Console.ReadLine();
            }

            command = Console.ReadLine();
            while (command!="End")
            {

                 GoThrowAllChechIfTherePokemonWithGivenElementAndChange(command, trainers);
              
                command = Console.ReadLine();
            }
            foreach (var item in trainers)
            {
              
                var removePokemons = item.Pokemons.Where(x=>x.Health<=0).ToArray();
                foreach (var item2 in removePokemons)
                {
                    item.Pokemons.Remove(item2);
                }
               
            }
            trainers.OrderByDescending(x=>x.NumberOfBadges).ToList().ForEach(x => Console.WriteLine($"{x.Name} {x.NumberOfBadges} {x.Pokemons.Count}"));

        }

        static void GoThrowAllChechIfTherePokemonWithGivenElementAndChange(string command,List<Trainer> trainers)
        {
            for (int i = 0; i < trainers.Count; i++)
            {
                var isPokemonWithGivenElement = trainers[i].Pokemons.FirstOrDefault(x=>x.Element==command);
                if (isPokemonWithGivenElement==null)
                {
                    for (int j = 0; j < trainers[i].Pokemons.Count; j++)
                    {
                        trainers[i].Pokemons[j].ReduceHealth();
                    }
                }
                else
                {
                    trainers[i].IncreaceNumberOfBadges();
                }
            }

        }

    }
}
