using System;
using System.Linq;

namespace _01._Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> printing = Console.WriteLine;

            Console.ReadLine()
                .Split()
                .ToList()
                .ForEach(printing);
                
        }
    }
}
