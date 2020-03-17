using System;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var matrix = new string[input[0], input[1]];

            for (int i = 0; i < input[0]; i++)
            {
                var input2 = Console.ReadLine().Split().ToArray();
                for (int j = 0; j < input[1]; j++)
                {
                    matrix[i, j] = input2[j];
                }
            }
            var count = 0;
            for (int i = 0; i < input[0] - 1; i++)
            {
                for (int j = 0; j < input[1] - 1; j++)
                {
                    if (matrix[i, j]== matrix[i + 1, j] && matrix[i + 1, j]== matrix[i, j + 1]&& matrix[i, j + 1]== matrix[i + 1, j + 1])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
            
        }
    }
}
