using System;
using System.Linq;

namespace _7._Knight_Game
{
    class Program
    {


        static int[] FindMostDangerousHourse(char[,] matrix,int input)
        {

            var arr = new int[3];
            int max = -1;

            for (int i = 0; i < input; i++)
            {

                for (int j = 0; j < input; j++)
                {

                    if (matrix[i, j] == 'K')
                    {
                        int removedCount = 0;

                        if (i - 2 >= 0)
                        {
                            if (j - 1 >= 0)
                            {
                                if (matrix[i - 2, j - 1] == 'K')
                                {
                                    removedCount++;
                                }
                            }
                            if (j + 1 < input)
                            {
                                if (matrix[i - 2, j + 1] == 'K')
                                {
                                    removedCount++;
                                }
                            }
                        }
                        if (j - 2 >= 0)
                        {
                            if (i - 1 >= 0)
                            {
                                if (matrix[i - 1, j - 2] == 'K')
                                {
                                    removedCount++;
                                }
                            }
                            if (i + 1 < input)
                            {
                                if (matrix[i + 1, j - 2] == 'K')
                                {
                                    removedCount++;
                                }
                            }
                        }
                        if (i + 2 < input)
                        {
                            if (j - 1 >= 0)
                            {
                                if (matrix[i + 2, j - 1] == 'K')
                                {
                                    removedCount++;
                                }
                            }
                            if (j + 1 < input)
                            {
                                if (matrix[i + 2, j + 1] == 'K')
                                {
                                    removedCount++;
                                }
                            }
                        }
                        if (j + 2 < input)
                        {
                            if (i - 1 >= 0)
                            {
                                if (matrix[i - 1, j + 2] == 'K')
                                {
                                    removedCount++;
                                }
                            }
                            if (i + 1 < input)
                            {
                                if (matrix[i + 1, j + 2] == 'K')
                                {
                                    removedCount++;
                                }
                            }
                        }

                        if (removedCount> max)
                        {
                            max = removedCount;
                            arr[0] = max;
                            arr[1] = i;
                            arr[2] = j;
                        }
                    }
                }
            }

           
            return arr;
        }


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

            var removedCount = 0;
            while (true)
            {
              var arr= FindMostDangerousHourse(matrix,input);
                if (arr[0]<=0)
                {
                    break;
                }
                else
                {
                    removedCount++;
                    matrix[arr[1], arr[2]] = '0';
                }
            }

           
            Console.WriteLine(removedCount);

        }
    }
}
