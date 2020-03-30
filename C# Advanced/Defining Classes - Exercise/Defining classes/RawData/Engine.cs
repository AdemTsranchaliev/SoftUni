using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Engine
    {
        private int enginePower;
        private int engineSpeed;

        public Engine(int engineSpeed, int enginePower)
        {
            this.enginePower = enginePower;
            this.engineSpeed = engineSpeed;
        }

        public int EnginePower
        {
            get
            {
                return this.enginePower;
            }
        }
    }
}
