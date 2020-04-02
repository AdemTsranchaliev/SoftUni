using System;
using System.Collections.Generic;
using System.Text;

namespace ThreeupleExercise
{
    public class Threeuple<T,K,Y>
    {

        private T item1;
        private K item2;
        private Y item3;

        public T Item1
        {
            get
            {
                return this.item1;     
            }
            set
            {
                this.item1 = value;
            }
        }
        public K Item2
        {
            get
            {
                return this.item2;
            }
            set
            {
                this.item2 = value;
            }
        }
        public Y Item3
        {
            get
            {
                return this.item3;
            }
            set
            {
                this.item3 = value;
            }
        }

        public Threeuple(T item1, K item2,Y item3)
        {
            this.item1 = item1;
            this.item2 = item2;
            this.item3 = item3;
        }
        public override string ToString()
        {
            return $"{this.item1} -> {this.item2} -> {this.item3}";
        }

    }
}
