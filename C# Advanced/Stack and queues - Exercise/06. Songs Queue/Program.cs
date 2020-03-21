using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ");
            var queue = new Queue<string>(input);

            while (queue.Any())
            {
                var command = Console.ReadLine();

                if (command=="Play")
                {
                    queue.Dequeue();
                }
                else if (command=="Show")
                {
                    int count = queue.Count;
                    Console.WriteLine(String.Join(", ",queue));
                    for (int i = 0; i < count; i++)
                    {
                        queue.Enqueue(queue.Dequeue());
                    }
                }
                else
                {
                    var addSong = command.Substring(4);
                    if (queue.Contains(addSong))
                    {
                        Console.WriteLine($"{addSong} is already contained!");
                    }
                    else
                    {
                        queue.Enqueue(addSong);
                    }
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
