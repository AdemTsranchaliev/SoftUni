using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<int,int>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = int.Parse(Console.ReadLine());
                if (!dict.ContainsKey(input))
                {
                    dict[input] = 0;
                }
                dict[input]++;
            }
         
            Console.WriteLine(dict.Where(x => x.Value % 2 == 0).First().Key);
        }
    }
}
