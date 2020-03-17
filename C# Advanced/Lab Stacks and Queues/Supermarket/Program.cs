using System;
using System.Collections.Generic;
using System.Linq;

class Program
 {
     static void Main(string[] args)
     {
        var queue = new Queue<string>();

        var command = Console.ReadLine();

        while (command.ToLower()!="end")
        {

            if (command.ToLower()=="paid")
            {
                while (queue.Any())
                {
                    Console.WriteLine(queue.Dequeue());
                }
            }
            else
            {
                queue.Enqueue(command);
            }

            command = Console.ReadLine();
        }

    
            Console.WriteLine($"{queue.Count} people remaining.");
        
    }
 }

