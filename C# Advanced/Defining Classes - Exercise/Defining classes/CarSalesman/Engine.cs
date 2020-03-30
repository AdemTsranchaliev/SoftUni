using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Engine
    {
        private string model;
        private int power;
        private int displacement;
        public string efficiency;

        public Engine(string model, int power)
        {
            this.model = model;
            this.power = power;
            this.displacement = 0;
        }
        public Engine(string model,int power,int displacement)
        {
            this.model = model;
            this.power = power;
            this.displacement = displacement;
        }

        public Engine(string model, int power, string efficiency)
        {
            this.model = model;
            this.power = power;
            this.efficiency = efficiency;
            this.displacement = 0;

        }
        public Engine(string model, int power, int displacement,string efficiency)
        {
            this.model = model;
            this.power = power;
            this.displacement = displacement;
            this.efficiency = efficiency;
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine($"  {this.model}:");
            builder.AppendLine($"    Power: {this.power}");
            if (this.displacement == 0)
            {
                builder.AppendLine($"    Displacement: n/a");
            }
            else
            {
                builder.AppendLine($"    Displacement: {this.displacement}");

            }
            if (this.efficiency==null)
            {
                builder.Append($"    Efficiency: n/a");

            }
            else
            {
                builder.Append($"    Efficiency: {this.efficiency}");

            }

            return builder.ToString();
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
