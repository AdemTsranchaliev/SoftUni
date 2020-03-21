using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var queue = new Queue<int>();
            for (int i = 0; i < n; i++)
            {
                var pomp = Console.ReadLine().Split().Select(int.Parse).ToArray();
                queue.Enqueue(pomp[0]);
                queue.Enqueue(pomp[1]);
            }
            int index = 0;
            while (true)
            {
                var isFinal = true;
                var queue2 = new Queue<int>(queue);
                int capacity = 0;
                while (queue2.Any())
                {
                    capacity += queue2.Dequeue();
                    capacity -= queue2.Dequeue();
                    if (capacity<0)
                    {
                        isFinal = false;
                        break;
                    }
                }
                if (isFinal)
                {
                    break;
                }
                else
                {
                    index++;
                    queue.Enqueue(queue.Dequeue());
                    queue.Enqueue(queue.Dequeue());

                }
            }

            Console.WriteLine(index);
        }
    }
}
