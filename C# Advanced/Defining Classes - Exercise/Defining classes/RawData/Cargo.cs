using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Cargo
    {
        private string type;
        private int weight;

        public Cargo(string cargoType,int cargoWeight)
        {
            this.type = cargoType;
            this.weight = cargoWeight;
        }

        public string Type
        {
            get
            {
                return this.type;
            }
        }
    }
}
