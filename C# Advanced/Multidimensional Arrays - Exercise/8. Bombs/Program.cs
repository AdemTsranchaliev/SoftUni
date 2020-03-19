using System;
using System.Linq;

namespace _8._Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var matrix = new int[input, input];

            for (int i = 0; i < input; i++)
            {
                var input2 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < input; j++)
                {
                    matrix[i, j] = input2[j];
                }
            }

            var boms = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i = 0; i < boms.Length; i++)
            {
               var sep= boms[i].Split(new char[] { ' ', ','},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                var row = sep[0];
                var col = sep[1];
                var bombValue = matrix[row, col];
                if (bombValue<=0)
                {
                    continue;
                }
                matrix[row, col] = 0;
                if (row+1<input)
                {
                    if (matrix[row+1,col]>0)
                    {
                        matrix[row + 1, col] -= bombValue;
                    }
                    if (col+1<input)
                    {
                        if (matrix[row + 1, col+1] > 0)
                        {
                            matrix[row + 1, col+1] -= bombValue;
                        }
                    }
                    if (col-1>=0)
                    {
                        if (matrix[row + 1, col-1] > 0)
                        {
                            matrix[row + 1, col-1] -= bombValue;
                        }
                    }
                }
                if (row - 1 >= 0)
                {
                    if (matrix[row - 1, col] > 0)
                    {
                        matrix[row - 1, col] -= bombValue;
                    }
                    if (col + 1 < input)
                    {
                        if (matrix[row - 1, col+1] > 0)
                        {
                            matrix[row - 1, col + 1] -= bombValue;
                        }
                    }
                    if (col - 1 >= 0)
                    {
                        if (matrix[row - 1, col - 1] > 0)
                        {
                            matrix[row - 1, col - 1] -= bombValue;
                        }
                    }
                }
                if (col+1<input)
                {
                    if (matrix[row, col+1] > 0)
                    {
                        matrix[row, col+1] -= bombValue;
                    }
                }
                if (col-1>=0)
                {
                    if (matrix[row , col-1] > 0)
                    {
                        matrix[row , col-1] -= bombValue;
                    }
                }
              
            }

            int cellCount = 0;
            int sum = 0;
            for (int i = 0; i < input; i++)
            {
                for (int j = 0; j < input; j++)
                {
                    if (matrix[i,j]>0)
                    {
                        sum += matrix[i, j];
                        cellCount++;
                    }
                }
            }

            Console.WriteLine($"Alive cells: {cellCount}");
            Console.WriteLine($"Sum: {sum}");

            for (int i = 0; i < input; i++)
            {
                for (int j = 0; j < input; j++)
                {
                    Console.Write(matrix[i, j]+" ");
                }
                Console.WriteLine();
            }

        }
    }
}
