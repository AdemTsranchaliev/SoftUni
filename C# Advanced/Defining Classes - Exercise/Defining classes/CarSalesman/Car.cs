using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        private string model;
        private Engine engine;
        private int weight;
        private string color;

        public Car(string model,Engine engine)
        {
            this.model = model;
            this.engine = engine;
        }
        public Car(string model, Engine engine,int weight)
        {
            this.model = model;
            this.engine = engine;
            this.weight = weight;
            this.color = null;
        }
        public Car(string model, Engine engine,string color)
        {
            this.model = model;
            this.engine = engine;
            this.color = color;
            this.weight = 0;
        }
        public Car(string model, Engine engine, int weight,string color)
        {
            this.model = model;
            this.engine = engine;
            this.color = color;
            this.weight = weight;
        }
        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine($"{this.model}:");
            builder.AppendLine(this.engine.ToString());
            if (this.weight!=0)
            {
                builder.AppendLine($"  Weight: {this.weight}");
            }
            else
            {
                builder.AppendLine($"  Weight: n/a");

            }
            if (this.color != null)
            {
                builder.Append($"  Color: {this.color}");
            }
            else
            {
                builder.Append($"  Color: n/a");

            }
            return builder.ToString();
        }
    }
}
