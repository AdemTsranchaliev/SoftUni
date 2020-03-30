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
                var tokens = Console.ReadLine().Split();

                string model = tokens[0];
                var fuelAmount = double.Parse(tokens[1]);
                var fuelConsuption = double.Parse(tokens[2]);
                if (cars.Find(x=>x.Model==model)==null)
                {
                    cars.Add(new Car(model, fuelAmount, fuelConsuption));

                }
            }

            var input = Console.ReadLine().Split();
            while (input[0]!="End")
            {
                if (input[0]=="Drive")
                {
                    var tempCar=cars.Where(x => x.Model == input[1]).FirstOrDefault();
                    tempCar.AddTraveledKilometers(double.Parse(input[2]));
                }

                input = Console.ReadLine().Split();
            }

            foreach (var item in cars)
            {
                item.Print();
            }
        }
    }
}
