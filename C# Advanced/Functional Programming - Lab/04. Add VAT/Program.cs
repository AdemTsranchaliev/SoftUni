using System;
using System.Linq;

namespace _04._Add_VAT
{
    class Program
    {
        private static object isWordStartWithUpperCase;

        static void Main(string[] args)
        {
            Console.ReadLine()
                 .Split(new[] { ' ',',' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(double.Parse)
                 .Select(AddVat)
                 .ToList()
                 .ForEach(x=> Console.WriteLine($"{x:f2}"));
        }

        static double AddVat(double x) => x + x * 0.2;
    }
}
