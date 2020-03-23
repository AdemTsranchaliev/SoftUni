using System;
using System.Linq;

namespace _01._Sort_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .Where(isEven)
                .OrderBy(x => x)
                .ToList();

            Console.WriteLine(string.Join(", ",input));
                
        }

        static bool isEven(int x) => x % 2 == 0;
    }
}
