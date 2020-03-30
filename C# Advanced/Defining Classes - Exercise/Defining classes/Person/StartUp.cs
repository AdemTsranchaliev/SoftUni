using DefiningClasses;
using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    static void Main(string[] args)
    {
        var  people = new List<Person>();

        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            var tokens = Console.ReadLine().Split();

            string name = tokens[0];
            int age = int.Parse(tokens[1]);

            people.Add(new Person(name, age));
        }

        people.Where(x => x.Age > 30).OrderBy(x => x.Name).ToList().ForEach(x => Console.WriteLine($"{x.Name} - {x.Age}"));


    }
}