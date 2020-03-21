using System;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new SortedDictionary<char, int>();

            var word = Console.ReadLine();


            foreach (var item in word)
            {
                if (!dict.ContainsKey(item))
                {
                    dict[item] = 0;
                }
                dict[item]++;
            }

            foreach (var (key,value) in dict)
            {
                Console.WriteLine($"{key}: {value} time/s");
            }
        }
    }
}
