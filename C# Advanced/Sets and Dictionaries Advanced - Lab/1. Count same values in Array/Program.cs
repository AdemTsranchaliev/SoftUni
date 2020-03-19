using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Count_same_values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<double, int>();

            var input = Console.ReadLine().Split().Select(double.Parse).ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                if (!dict.ContainsKey(input[i]))
                {
                    dict[input[i]] = 0;
                }
                dict[input[i]]++;
            }

            foreach (var (key,value) in dict)
            {
                Console.WriteLine($"{key} - {value} times");
            }

        }
    }
}
