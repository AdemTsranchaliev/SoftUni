using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var engines = new List<Engine>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new[] { ' '},StringSplitOptions.RemoveEmptyEntries).ToList();
                Engine tempEngine;
                if (input.Count==3)
                {
                    int displacement;
                    bool isDisplacement = int.TryParse(input[2],out displacement);
                    if (isDisplacement)
                    {
                        tempEngine = new Engine(input[0], int.Parse(input[1]), displacement);
                    }
                    else
                    {
                        tempEngine = new Engine(input[0], int.Parse(input[1]), input[2]);

                    }
                }
                else if(input.Count==4)
                {
                    tempEngine = new Engine(input[0], int.Parse(input[1]), int.Parse(input[2]),input[3]);

                }
                else
                {
                    tempEngine = new Engine(input[0], int.Parse(input[1]));
                }
                engines.Add(tempEngine);
            }
            var cars = new List<Car>();
            var m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                Car tempCar;
                var engineForCar = engines.FirstOrDefault(x => x.Model == input[1]);
                if (input.Count == 2)
                {
                    tempCar = new Car(input[0], engineForCar);
                }
                else if (input.Count == 4)
                {
                    tempCar = new Car(input[0], engineForCar, int.Parse(input[2]), input[3]);

                }
                else
                {
                    int weight = 0;
                    bool isWeight=int.TryParse(input[2], out weight);

                    if (isWeight)
                    {
                        tempCar = new Car(input[0], engineForCar, weight);
                    }
                    else
                    {
                        tempCar = new Car(input[0], engineForCar, input[2]);

                    }
                }
                cars.Add(tempCar);
            }
            foreach (var item in cars)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
