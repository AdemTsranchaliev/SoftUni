using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] {' ' },StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var set1 = new HashSet<int>();
            var set2 = new HashSet<int>();


            for (int i = 0; i < input[0]; i++)
            {
                var num = int.Parse(Console.ReadLine());
                set1.Add(num);
            }

            for (int i = 0; i < input[1]; i++)
            {
                var num = int.Parse(Console.ReadLine());
                set2.Add(num);
            }

            foreach (var item in set1)
            {
                if (set2.Contains(item))
                {
                    Console.Write(item+" ");
                }
            }


        }
    }
}
