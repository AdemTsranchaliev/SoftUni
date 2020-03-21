using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            var cups = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var botles = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var cupsQueue = new Queue<int>(cups);
            var botlesStack = new Stack<int>(botles);
            int currentCupValue = 0;
            int remaining = 0;
            var bottleCount = 0;
            while (cupsQueue.Any()&&botlesStack.Any())
            {
                if (botlesStack.Peek() - cupsQueue.Peek()>=0)
                {
                    remaining += botlesStack.Peek() - cupsQueue.Peek();
                    botlesStack.Pop();
                    cupsQueue.Dequeue();
                    bottleCount++;

                }
                else
                {
                    int tempCup = cupsQueue.Dequeue();
                    while (botlesStack.Any()&& tempCup > 0)
                    {
                        if (tempCup - botlesStack.Peek()>0)
                        {
                            bottleCount++;
                            botlesStack.Pop();
                        }
                        else
                        {
                            bottleCount++;
                            remaining += botlesStack.Peek() - tempCup;
                            botlesStack.Pop();
                        }
                    }
                }
            }
            Console.WriteLine();

        }
    }
}
