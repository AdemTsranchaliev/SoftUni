using System;
using System.Collections.Generic;
using System.Linq;

namespace People
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();
            var people = new List<Person>();
            while (command!="END")
            {
                var sep = command.Split().ToArray();

                people.Add(new Person(sep[0],int.Parse(sep[1]),sep[2]));

                command = Console.ReadLine();
            }
            var n = int.Parse(Console.ReadLine());
            var matches = 0;
            var unmatches = 0;
            for (int i = 0; i < people.Count; i++)
            {
                var result = people[n-1].CompareTo(people[i]);
                if (result==0)
                {
                    matches++;
                }
                else
                {
                    unmatches++;
                }
            }
            if (matches==1)
            {
                Console.WriteLine("No matches");
            }
            else
            Console.WriteLine($"{matches} {unmatches} {people.Count}");
        }
    }
}
