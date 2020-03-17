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
                var input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < input[1]; j++)
                {
                    matrix[i, j] = input2[j];
                }
            }
            int max = int.MinValue;
            var res = new int[9];
            for (int i = 0; i < input[0] - 2; i++)
            {
                for (int j = 0; j < input[1] - 2; j++)
                {
                    int sum = matrix[i, j] + matrix[i + 1, j] + matrix[i, j + 1] + matrix[i + 1, j + 1] + matrix[i + 2, j + 2] + matrix[i, j + 2] + matrix[i + 2, j ] + matrix[i + 1, j + 2] + matrix[i + 2, j + 1];
                    if (sum > max)
                    {
                        res[0] = matrix[i, j];
                        res[2] = matrix[i , j + 1];
                        res[1] = matrix[i , j + 2];
                        res[3] = matrix[i + 1, j];
                        res[4] = matrix[i + 1, j + 1];
                        res[5] = matrix[i + 1, j + 2];
                        res[6] = matrix[i+2 , j ];
                        res[7] = matrix[i + 2, j + 1];
                        res[8] = matrix[i + 2, j + 2];


                        max = sum;
                    }
                }
            }
            Console.WriteLine("Sum = "+max);

            Console.WriteLine($"{res[0]} {res[1]} {res[2]}");
            Console.WriteLine($"{res[3]} {res[4]} {res[5]}");
            Console.WriteLine($"{res[6]} {res[7]} {res[8]}");
        }
    }
}
