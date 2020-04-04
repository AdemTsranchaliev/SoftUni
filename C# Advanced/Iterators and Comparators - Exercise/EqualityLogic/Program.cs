using System;
using System.Collections.Generic;
using System.Linq;

namespace EqualityLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
       
            var setSorted = new SortedSet<Person>();
            var setHashed = new HashSet<Person>();

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine();
                var sep = command.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).ToArray();
                var person = new Person(sep[0], int.Parse(sep[1]));
                setSorted.Add(person);
                setHashed.Add(person);
            }
            Console.WriteLine(setHashed.Count);
            Console.WriteLine(setSorted.Count);

        }
    }
}
