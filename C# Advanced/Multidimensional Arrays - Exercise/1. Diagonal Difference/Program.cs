using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var matrix = new int[input, input];

            for (int i = 0; i < input; i++)
            {
                var input2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < input; j++)
                {
                    matrix[i, j] = input2[j];
                }
            }
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i < input; i++)
            {

                sum1 += matrix[i, i];
                sum2 += matrix[i, input - i - 1];
            }

            Console.WriteLine(Math.Abs(sum1-sum2));
        }
    }
}
