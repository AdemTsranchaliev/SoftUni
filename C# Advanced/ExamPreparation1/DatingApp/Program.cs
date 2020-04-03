

namespace DatingApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            var input1 = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var input2 = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var males = new Stack<int>(input1);
            var females = new Queue<int>(input2);

            int matches = 0;
            while (true)
            {

                while (males.Count > 0&&(males.Peek() % 25 == 0|| males.Peek()<=0))
                {
                    males.Pop();
                }
                while (females.Count > 0&&(females.Peek() % 25 == 0 || females.Peek() <= 0))
                {
                    females.Dequeue();
                }
                if (males.Count == 0 || females.Count == 0)
                {
                    break;
                }
                int male = males.Peek();
                int female = females.Peek();
                
                if (male==female)
                {
                    males.Pop();
                    females.Dequeue();
                    matches++;
                }
                else
                {
                    females.Dequeue();
                    int val = males.Pop()- 2;
                    males.Push(val);
                }
            }
            Console.WriteLine($"Matches: {matches}");
            if (males.Count==0)
            {
                Console.WriteLine($"Males left: none");
            }
            else
            {
                Console.WriteLine($"Males left: {string.Join(", ",males)}");

            }
            if (females.Count == 0)
            {
                Console.WriteLine($"Females left: none");
            }
            else
            {
                Console.WriteLine($"Females left: {string.Join(", ", females)}");

            }
        }
    }
}
