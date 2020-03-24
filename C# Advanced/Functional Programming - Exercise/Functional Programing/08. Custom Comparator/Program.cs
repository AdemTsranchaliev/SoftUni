using System;
using System.Linq;

namespace _08._Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> comparison = (a, b) =>
                {
                    if (a%2!=0&&b%2==0)
                    {
                        return b;
                    }
                    else if(a % 2 == 0 && b % 2 != 0)
                    {
                        return a;
                    }
                    else
                    {
                        return a.CompareTo(b);
                    }
                };

            Comparison<int> comp = new Comparison<int>(comparison);

            var arr=Console.ReadLine()
                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();
            Array.Sort(arr,comp);

            Console.WriteLine(string.Join(" ",arr));
        }

    }
}
