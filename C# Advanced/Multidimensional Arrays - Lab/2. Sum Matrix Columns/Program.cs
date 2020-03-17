using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            var matrix = new int[input[0], input[1]];

            for (int i = 0; i < input[0]; i++)
            {
                var input2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < input[1]; j++)
                {
                    matrix[i, j] = input2[j];
                }
            }
           
            for (int i = 0; i < input[1]; i++)
            {
                int sum = 0;
                for (int j = 0; j < input[0]; j++)
                {
                    sum += matrix[j,i];
                }
                Console.WriteLine(sum);
            }


        }
    }
}
