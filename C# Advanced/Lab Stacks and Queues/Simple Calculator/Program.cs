using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(new[] { ' '},StringSplitOptions.RemoveEmptyEntries).Reverse();
        var stack = new Stack<string>(input);
        int sum = int.Parse(stack.Pop());
        while (stack.Any())
        {
            if (stack.Peek()=="+")
            {
                stack.Pop();
                sum += int.Parse(stack.Pop());
            }
            else if (stack.Peek()=="-")
            {
                stack.Pop();
                sum -= int.Parse(stack.Pop());
            }
        }

        Console.WriteLine(sum);
    }
}

