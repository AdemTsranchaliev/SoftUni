using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse);
        var queue = new Queue<int>(input);

        int queueLenght = queue.Count;
        for (int i = 0; i < queueLenght; i++)
        {
            if (queue.Peek()%2==0)
            {
                queue.Enqueue(queue.Peek());
            }
            queue.Dequeue();
        }

        Console.WriteLine(String.Join(", ", queue));
    }
}

