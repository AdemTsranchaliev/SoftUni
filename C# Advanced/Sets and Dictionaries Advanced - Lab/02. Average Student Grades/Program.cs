using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<decimal>>();
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (!dict.ContainsKey(input[0]))
                {
                    dict[input[0]] = new List<decimal>();
                }

                dict[input[0]].Add(decimal.Parse(input[1]));

            }

            foreach (var (key, value) in dict)
            {
                Console.WriteLine($"{key} -> {string.Join(" ",value.Select(x=>x.ToString("F2")))} (avg: {value.Average():f2})");
            }
        }
    }
}
