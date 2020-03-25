using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._List_Of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var nums = Console.ReadLine()
                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToHashSet();

            Func<HashSet<int>, int, bool> func = IsNumberDevidibleToAllNumsInHashSet;

            for (int i = 1; i <= n; i++)
            {
                if (IsNumberDevidibleToAllNumsInHashSet(nums,i))
                {
                    Console.Write(i+" ");
                }
            }
           
        }

        static bool IsNumberDevidibleToAllNumsInHashSet(HashSet<int> set,int num)
        {
            bool isTrue = true;
            foreach (var item in set)
            {
                if (num % item!=0)
                {
                    isTrue = false;
                }
            }

            return isTrue;
        }
    }
}
