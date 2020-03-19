using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string,List<string>>>();

            var input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                var input2 = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (!dict.ContainsKey(input2[0]))
                {
                    dict[input2[0]] = new Dictionary<string, List<string>>();
                }
                if (!dict[input2[0]].ContainsKey(input2[1]))
                {
                    dict[input2[0]][input2[1]] = new List<string>();
                }
                dict[input2[0]][input2[1]].Add(input2[2]);
            }

            foreach (var (key, value) in dict)
            {
                Console.WriteLine($"{key}:");
                foreach (var (key2,value2) in value)
                {
                    Console.WriteLine($"{key2} -> {string.Join(", ",value2)}");
                }
            }

        }
    }
}
