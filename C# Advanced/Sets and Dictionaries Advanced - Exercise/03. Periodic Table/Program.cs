﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var set = new SortedSet<string>();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int j = 0; j < input.Length; j++)
                {
                    set.Add(input[j]);
                }
            }

            Console.WriteLine(string.Join(" ",set));
        }
    }
}
