using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            var input1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            var input2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            int claimedItems = 0;
            var queue = new Queue<int>(input1);
            var stack = new Stack<int>(input2);


            while (true)
            {
                if (stack.Count <= 0 || queue.Count <= 0)
                {
                    break;
                }
                if ((stack.Peek() + queue.Peek()) % 2 == 0)
                {
                    claimedItems += queue.Dequeue() + stack.Pop();
                }
                else
                {
                    queue.Enqueue(stack.Pop());
                }
            }

            if (stack.Count <= 0)
            {
                Console.WriteLine("Second lootbox is empty");

            }
            else if (queue.Count <= 0)
            {
                Console.WriteLine("First lootbox is empty");

            }
            if (claimedItems >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {claimedItems}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {claimedItems}");
            }
        }
    }
}