using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Reverse();
        var stack = new Stack<string>(input);

        while (stack.Count>1)
        {
            var first = int.Parse(stack.Pop());
            var operatior = stack.Pop();
            var second = int.Parse(stack.Pop());
            if (operatior=="-")
            {
                stack.Push((first-second).ToString());
            }
            else
            {
                stack.Push((first + second).ToString());

            }

        }

        Console.WriteLine(stack.Peek());

    }
}

