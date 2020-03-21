using System;
using System.Collections.Generic;

namespace _01._Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var uniqueNicknames = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();

                uniqueNicknames.Add(input);
            }

            foreach (var name in uniqueNicknames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
