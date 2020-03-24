using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<List<int>, int> func = FindMinNumber;

            var number = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();

            Console.WriteLine(func(number));
        }
        static int FindMinNumber(List<int> list) => list.Min();
    }
}
