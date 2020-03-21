using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string,int>>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(" -> ",StringSplitOptions.RemoveEmptyEntries);
                if (!dict.ContainsKey(input[0]))
                {
                    dict[input[0]] = new Dictionary<string, int>();
                }
                var input2 = input[1].Split(new[] { ','},StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int j = 0; j < input2.Length; j++)
                {
                    if (!dict[input[0]].ContainsKey(input2[j]))
                    {
                        dict[input[0]][input2[j]] = 0;
                    }
                    dict[input[0]][input2[j]]++;
                }

            
            }
            var find = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var (key,value) in dict)
            {
                Console.WriteLine($"{key} clothes:");
                foreach (var item2 in value)
                {
                    Console.Write($"* {item2.Key} - {item2.Value}");
                    if (key==find[0]&&item2.Key==find[1])
                    {
                        Console.Write(" (found!)");
                    }
                    Console.WriteLine();

                }
            }

        }
    }
}
