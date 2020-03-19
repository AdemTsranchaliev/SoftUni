using System;
using System.Linq;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var matrix = new string[input[0], input[1]];
            var word = Console.ReadLine();
            var beginEnd = true;
            int wordIndexer = 0;
            for (int i = 0; i < input[0]; i++)
            {
                if (beginEnd)
                {
                    for (int j = 0; j < input[1]; j++)
                    {
                        if (word.Length==wordIndexer)
                        {
                            wordIndexer = 0;
                        }
                         matrix[i, j] = word[wordIndexer].ToString();

                        wordIndexer++;
                    }
                    beginEnd = false;
                }
                else
                {
                    for (int j = input[1]-1; j >= 0; j--)
                    {
                        if (word.Length== wordIndexer)
                        {
                            wordIndexer = 0;
                        }
                        matrix[i, j] = word[wordIndexer].ToString();

                        wordIndexer++;
                    }
                    beginEnd = true;

                }

            }

            for (int i = 0; i < input[0]; i++)
            {
                for (int j = 0; j < input[1]; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
