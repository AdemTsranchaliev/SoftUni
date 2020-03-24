using System;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var command = Console.ReadLine();
            Func<int, int> func=null;

            while (command!="end")
            {
                if (command=="add")
                {
                    func = x => x + 1;
                }
                else if (command=="subtract")
                {
                    func = x => x - 1;
                }
                else if (command=="multiply")
                {
                    func = x => x * 1;
                }

                if (command == "print")
                {
                    Console.WriteLine(string.Join(" ",numbers));
                }
                else
                {
                    numbers = numbers.Select(func).ToList();
                }
                command = Console.ReadLine();
            }
            

        }
    }
}
