using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var matrix = new int[input[0], input[1]];

            for (int i = 0; i < input[0]; i++)
            {
                var input2 = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int j = 0; j < input[1]; j++)
                {
                    matrix[i, j] = input2[j];
                }
            }
            int max = int.MinValue;
            var res = new int[9];
            for (int i = 0; i < input[0] - 1; i++)
            {
                for (int j = 0; j < input[1] - 1; j++)
                {
                    int sum = matrix[i, j] + matrix[i + 1, j] + matrix[i, j + 1] + matrix[i + 1, j + 1];
                    if (sum > max)
                    {
                        res[0] = matrix[i, j];
                        res[2] = matrix[i + 1, j];
                        res[1] = matrix[i, j + 1];
                        res[3] = matrix[i + 1, j + 1];
                        max = sum;
                    }
                }
            }
            Console.WriteLine($"{res[0]} {res[1]}");
            Console.WriteLine($"{res[2]} {res[3]}");

            Console.WriteLine(max);
        }
    }
}
