using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse);
            var capacity = int.Parse(Console.ReadLine());
            var stack = new Stack<int>(arr);
            int rack = 1;
            int tempCapacity = 0;
            while (stack.Any())
            {
                if (tempCapacity+stack.Peek()<=capacity)
                {
                    tempCapacity += stack.Pop();
                }
                else
                {
                    rack++;
                    tempCapacity = 0;
                }
            }

            Console.WriteLine(rack);
        }
    }
}
