using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwap
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var list = new List<double>();
            for (int i = 0; i < n; i++)
            {
                var input = double.Parse(Console.ReadLine());
                list.Add(input);
            }
            var compareWith = double.Parse(Console.ReadLine());
            Console.WriteLine(Compare(list,compareWith));
        }
        static void Swap<T>(List<T> list,int from,int to)
        {
            T temp = list[from];
            list[from] = list[to];
            list[to] = temp;
                
        }
        static int Compare<T>(List<T> list,T elementToCompatre) where T:IComparable
        {
            int counter = 0;
            foreach (var item in list)
            {
                if (item.CompareTo(elementToCompatre)>0)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
