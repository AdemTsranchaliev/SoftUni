using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniParking
{
    public class Car
    {
        private string make;
        private string model;
        private int horsePower;
        private string registrationNumber;

        public Car(string make,string model,int horsePower,string registrationNumber)
        {
            this.make = make;
            this.model = model;
            this.horsePower = horsePower;
            this.registrationNumber = registrationNumber;


        }
        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.AppendLine($"Make: {this.make}");
            builder.AppendLine($"Model: {this.model}");
            builder.AppendLine($"HorsePower: {this.horsePower}");
            builder.Append($"RegistrationNumber: {this.registrationNumber}");

            return builder.ToString().Trim();
        }
        public string Make
        {
            get
            {
                return this.make;
            }
            set
            {
                this.make = value;
            }
        }
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        
        }
        public int HorsePower
        {
            get
            {
                return this.horsePower;
            }
            set
            {
                this.horsePower = value;
            }
        }
        public string RegistrationNumber
        {
            get
            {
                return this.registrationNumber;
            }
            set
            {
                this.registrationNumber = value;
            }
        }
    }
}
