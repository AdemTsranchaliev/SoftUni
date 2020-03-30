using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private double travelledDistance;

        public Car(string model,double fuelAmount,double fuelConsumptionPerKilometer)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            this.travelledDistance = 0;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
        }

        public void AddTraveledKilometers(double traveledDistance)
        {
            double consumedFuel = this.fuelConsumptionPerKilometer * traveledDistance;
            if (consumedFuel <= this.fuelAmount)
            {
                this.fuelAmount -= consumedFuel;
                this.travelledDistance += traveledDistance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        public void Print()
        {
            Console.WriteLine($"{this.model} {this.fuelAmount:f2} {this.travelledDistance}");
        }
    }
}
