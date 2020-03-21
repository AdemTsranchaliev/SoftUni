using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var NSX = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var secondInput = Console.ReadLine().Split().Select(int.Parse);
            var stack = new Queue<int>(secondInput);

            if (NSX[1] <= NSX[0])
            {
                for (int i = 0; i < NSX[1]; i++)
                {
                    stack.Dequeue();
                }
            }
            else
            {
                for (int i = 0; i < NSX[0]; i++)
                {
                    stack.Dequeue();
                }
            }
            if (stack.Contains(NSX[2]))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (stack.Count == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(stack.Min());

                }
            }
        }
    }
}
