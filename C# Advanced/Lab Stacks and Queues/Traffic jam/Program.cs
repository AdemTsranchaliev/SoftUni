using System;
using System.Collections.Generic;

class Program
 {
     static void Main(string[] args)
     {
        int n = int.Parse(Console.ReadLine());
        var queue = new Queue<string>();
        var command = Console.ReadLine();
        var counter = 0;
        while (command!="end")
        {
            if (command=="green")
            {
                int i = 0;
                while (i != n && queue.Count!=0)
                {
                    Console.WriteLine($"{queue.Dequeue()} passed!");
                    counter++;
                    i++;
                }
            }
            else
            {
                queue.Enqueue(command);
            }
            command = Console.ReadLine();
        }

        Console.WriteLine($"{counter} cars passed the crossroads.");
    }
 }

