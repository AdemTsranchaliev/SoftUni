using System;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> pred;
            var input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Reverse()
                .ToList();
            var n = int.Parse(Console.ReadLine());

            pred = x => x % n != 0;

            for (int i = 0; i < input.Count; i++)
            {
                if (!pred(input[i]))
                {
                    input.RemoveAt(i);
                    i--;
                }
            }
            Console.WriteLine(string.Join(" ",input));
        }
    }
}
