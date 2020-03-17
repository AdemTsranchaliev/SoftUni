using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split();
        var queue = new Queue<string>(input);
        var n = int.Parse(Console.ReadLine());

        int i = 1;

        while (queue.Count>1)
        {
            if (i==n)
            {
                Console.WriteLine($"Removed {queue.Dequeue()}");
                i = 0;
            }
            else
            {
                queue.Enqueue(queue.Dequeue());
            }
            i++;
        }
        Console.WriteLine($"Last is {queue.Peek()}");
    }
}

