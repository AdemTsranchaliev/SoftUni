﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        private string model;
        private Tire[] tires;
        private Cargo cargo;
        private Engine engine;

        public Car(string model,int engineSpeed,int enginePower,int cargoWeight,string cargoType,double tire1Pressure,int tire1Age, double tire2Pressure, int tire2Age, double tire3Pressure, int tire3Age, double tire4Pressure, int tire4Age)
        {
            this.model = model;
            this.engine = new Engine(engineSpeed,enginePower);
            this.cargo = new Cargo(cargoType,cargoWeight);
            this.tires = new Tire[4];
            this.tires[0] = new Tire(tire1Pressure,tire1Age);
            this.tires[1] = new Tire(tire2Pressure, tire2Age);
            this.tires[2] = new Tire(tire3Pressure, tire3Age);
            this.tires[3] = new Tire(tire4Pressure, tire4Age);

        }
        public Tire[] Tires
        {
            get
            {
                return this.tires;
            }
        }
        public Cargo Cargo
        {
            get
            {
                return this.cargo;
            }
        }
        public Engine Engine
        {
            get
            {
                return this.engine;
            }
        }
        public string Model
        {
            get
            {
                return this.model;
            }
        }
    }
}
