using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
                .Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries)
                .Where(isWordStartWithUpperCase)
                .ToList()
                .ForEach(Console.WriteLine);


            

        }

        static bool isWordStartWithUpperCase(string x) => x[0]==char.ToUpper(x[0]);
    }
}
