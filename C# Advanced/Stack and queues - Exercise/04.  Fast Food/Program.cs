using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.__Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            var foodInREstaurant = int.Parse(Console.ReadLine());
            var clientOrder = Console.ReadLine().Split().Select(int.Parse);
            var queue = new Queue<int>(clientOrder);
            Console.WriteLine(queue.Max());
            while (queue.Any())
            {
                if (foodInREstaurant - queue.Peek() >= 0)
                {
                    foodInREstaurant -= queue.Dequeue();
         
                }
                else
                {
                    break;
                }
            }

            if (queue.Any())
            {
                Console.WriteLine($"Orders left: {string.Join(" ",queue)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
