using System;
using System.Linq;

namespace _07._Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
            Func<string, bool> func = x => x.Length <= n;
            Console.ReadLine()
                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Where(func)
                 .ToList()
                 .ForEach(Console.WriteLine);
        }
    }
}
