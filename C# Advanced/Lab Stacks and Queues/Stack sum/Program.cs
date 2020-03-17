using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Program
 {
     static void Main()
     {
        var arr = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    
        var stack = new Stack<int>();
        for (int i = 0; i < arr.Length; i++)
        {
            stack.Push(arr[i]);
        }

        var command = Console.ReadLine().ToLower();

        while (command != "end")
        {
            var temp = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (temp[0] == "remove")
            {
                if (int.Parse(temp[1])<=stack.Count())
                {
                    int i = 0;
                    while (stack.Count != 0 && i != int.Parse(temp[1]))
                    {
                        stack.Pop();
                        i++;
                    }
                }
          
            }
            else if (temp[0]=="add")
            {
                stack.Push(int.Parse(temp[1]));
                stack.Push(int.Parse(temp[2]));

            }

            command = Console.ReadLine().ToLower();

        }

        Console.WriteLine($"Sum: {stack.Sum()}");

    }
 }

