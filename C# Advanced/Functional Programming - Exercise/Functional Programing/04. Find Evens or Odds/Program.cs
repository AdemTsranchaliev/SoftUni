using System;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> pred;
            var input = Console.ReadLine()
                .Split(new char[] { ' '},StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var command = Console.ReadLine();

            if (command.ToLower()=="odd")
            {
                pred = (int x) => x % 2 != 0;
            }
            else
            {
                pred = (int x) => x % 2 == 0;
            }

            for (int i = input[0]; i <= input[1]; i++)
            {
                if (pred(i))
                {
                    Console.Write(i+" ");
                }
            }

        }



    }
}
