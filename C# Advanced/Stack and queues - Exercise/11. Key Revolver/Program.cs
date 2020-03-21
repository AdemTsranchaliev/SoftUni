using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            var bulletCost = int.Parse(Console.ReadLine());
            var gunBarrel= int.Parse(Console.ReadLine());
            var bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var bulletsStack = new Stack<int>(bullets);
            var locks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var locksQueue = new Queue<int>(locks);
            var inteligence = int.Parse(Console.ReadLine());
            int countBullets = 0;
            int totalBullets = bulletsStack.Count;
            while (locksQueue.Any()&&bulletsStack.Any())
            {

               
                if (bulletsStack.Peek()<=locksQueue.Peek())
                {
                    Console.WriteLine("Bang!");
                    bulletsStack.Pop();
                    locksQueue.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                    bulletsStack.Pop();
                }
                countBullets++;
                if (countBullets == gunBarrel)
                {
                    countBullets = 0;
                    Console.WriteLine("Reloading!");
                }

            }
            if (!locksQueue.Any())
            {
                Console.WriteLine($"{bulletsStack.Count} bullets left. Earned ${inteligence-bulletCost*Math.Abs(bulletsStack.Count-totalBullets)}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locksQueue.Count}");
            }

        }
    }
}
