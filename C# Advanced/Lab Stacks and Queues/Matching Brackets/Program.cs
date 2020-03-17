using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();

        var stack = new Stack<int>();
        int index = 0;
        foreach (var item in input)
        {
            if (item=='(')
            {
                stack.Push(index);
            }
            else if (item==')')
            {
                Console.WriteLine(input.Substring(stack.Peek(),index-stack.Peek()+1));
                stack.Pop();
            }
            index++;
        }
    }
}

