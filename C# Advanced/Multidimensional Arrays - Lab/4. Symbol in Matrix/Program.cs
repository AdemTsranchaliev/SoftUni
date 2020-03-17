using System;

namespace _4._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var matrix = new char[input, input];

            for (int i = 0; i < input; i++)
            {
                var input2 = Console.ReadLine().ToCharArray();
                for (int j = 0; j < input; j++)
                {
                    matrix[i, j] = input2[j];
                }
            }
            var findMe = char.Parse(Console.ReadLine());
            var isFound = true;
            for (int i = 0; i < input; i++)
            {

                for (int j = 0; j < input; j++)
                {
                    if (matrix[i,j]==findMe)
                    {
                        Console.WriteLine($"({i}, {j})");
                        isFound = false;
                        break;
                    }
                }
                if (!isFound)
                {
                    break;
                }
            }
            if (isFound)
            {
                Console.WriteLine($"{findMe} does not occur in the matrix");
            }
            
        }
    }
}
