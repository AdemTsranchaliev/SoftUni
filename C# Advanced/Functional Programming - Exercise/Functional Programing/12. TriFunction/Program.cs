using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            var expectedSum = int.Parse(Console.ReadLine());
            var words = Console.ReadLine().Split().ToList();

            Func<string, int, bool> func = (x, y) => x.Sum(p=>p) >= y;

            Func<Func<string, int, bool>, List<string>, string> findResult = (a, b) => b.FirstOrDefault(x => a(x, expectedSum));

            Console.WriteLine(findResult(func, words));

            
        }

    }
}
