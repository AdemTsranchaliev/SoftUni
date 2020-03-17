using System;
using System.Collections.Generic;

class Program
 {
     static void Main()
     {
        var input = Console.ReadLine();
        var stack = new Stack<string>();

        foreach (var item in input)
        {
            stack.Push(item.ToString());
        }
        while (stack.Count!=0)
        {
            Console.Write(stack.Pop());
        }
    }
 }

