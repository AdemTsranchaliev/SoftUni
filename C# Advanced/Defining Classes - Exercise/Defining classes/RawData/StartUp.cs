using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var tokens = Console.ReadLine().Split(new char[] { ' '},StringSplitOptions.RemoveEmptyEntries);

                var model = tokens[0];
                var engineSpeed = int.Parse(tokens[1]);
                var enginePower = int.Parse(tokens[2]);
                var cargoWeight = int.Parse(tokens[3]);
                var cargoType = tokens[4];
                var tire1Pressure = double.Parse(tokens[5]);
                var tire1Age = int.Parse(tokens[6]);
                var tire2Pressure = double.Parse(tokens[7]);
                var tire2Age = int.Parse(tokens[8]);
                var tire3Pressure = double.Parse(tokens[9]);
                var tire3Age = int.Parse(tokens[10]);
                var tire4Pressure = double.Parse(tokens[11]);
                var tire4Age = int.Parse(tokens[12]);
                var newCar = new Car(model,engineSpeed,enginePower,cargoWeight,cargoType,tire1Pressure,tire1Age,tire2Pressure,tire2Age,tire3Pressure,tire3Age,tire4Pressure,tire4Age);
                cars.Add(newCar);
            }

            var command = Console.ReadLine();
            if (command=="fragile")
            {
                cars.Where(x => x.Cargo.Type == "fragile").Where(x=>FindIsTherePressureSmallerThan1(x.Tires)).ToList().ForEach(x=>Console.WriteLine(x.Model));
            }
            else
            {
                cars.Where(x => x.Cargo.Type == "flamable").Where(x => x.Engine.EnginePower>250).ToList().ForEach(x => Console.WriteLine(x.Model));

            }
        }

       static bool FindIsTherePressureSmallerThan1(Tire[] tires)
        {
            bool isFound = false;
            foreach (var item in tires)
            {
                if (item.Pressure<1)
                {
                    isFound = true;
                }
            }
            return isFound;
        }
    } 
}
