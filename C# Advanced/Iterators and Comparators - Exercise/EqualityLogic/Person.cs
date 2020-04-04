using System;
using System.Collections.Generic;
using System.Text;

namespace EqualityLogic
{
    public class Person :IComparable<Person>
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Person(string name,int age)
        {
            this.Age = age;
            this.Name = name;
        }

        public int CompareTo(Person other)
        {
            var result = this.Name.CompareTo(other.Name);

            if (result == 0)
            {
                result=this.Age.CompareTo(other.Age);
            }


            return result;
        }
        public override bool Equals(object obj)
        {
            var result = 1;
            if (obj is Person person)
            {
                 result = this.Name.CompareTo(person.Name);

                if (result == 0)
                {
                    result = this.Age.CompareTo(person.Age);
                }

            }

            if (result==0)
            {
                return true;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return this.Name.GetHashCode() + this.Age.GetHashCode();
        }
    }
}
