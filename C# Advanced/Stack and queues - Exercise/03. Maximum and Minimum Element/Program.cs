using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split();

                if (command[0]=="1")
                {
                    stack.Push(int.Parse(command[1]));
                }
                else if (command[0]=="2")
                {
                    stack.Pop();
                }
                else if (stack.Count!=0)
                {
                    if (command[0]=="3")
                    {
                        Console.WriteLine(stack.Max());
                    }
                    else
                    {
                        Console.WriteLine(stack.Min());
                    }
                }
                else
                {

                }
            }

            Console.WriteLine(String.Join(", ",stack));
        }
    }
}
