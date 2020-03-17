using System;
using System.Linq;

namespace _3._Primary_Diagonal
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
            int sum = 0;

            for (int i = 0; i < input; i++)
            {
               
                    sum += matrix[i, i];
                
            }

            Console.WriteLine(sum);
        }
    }
}
