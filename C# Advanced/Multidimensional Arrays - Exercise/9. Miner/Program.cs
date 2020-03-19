using System;
using System.Linq;

namespace _9._Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var matrix = new char[input, input];
            var startRol = 0;
            var startCol = 0;
            var commands = Console.ReadLine().Split(new char[] { ' '},StringSplitOptions.RemoveEmptyEntries).ToArray();
            var coalsCount = 0;
            for (int i = 0; i < input; i++)
            {
                var input2 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int j = 0; j < input; j++)
                {
                    if (input2[j]=='s')
                    {
                        startCol = j;
                        startRol = i;
                    }
                    if (input2[j] == 'c')
                    {
                        coalsCount++;
                    }
                    matrix[i, j] = input2[j];
                }
            }
            int coals = 0;
            var isReachedEnd = false;
            
            for (int i = 0; i < commands.Length; i++)
            {
                if (commands[i]=="down"&&startRol+1<input)
                {
                    startRol++;
                    if (matrix[startRol,startCol]=='e')
                    {
                        isReachedEnd = true;
                    }
                    else if (matrix[startRol, startCol] == 'c')
                    {
                        matrix[startRol, startCol] = '*';
                        coals++;
                    }
                }
                else if (commands[i]=="up" && startRol - 1 >= 0)
                {
                    startRol--;
                    if (matrix[startRol, startCol] == 'e')
                    {
                        isReachedEnd = true;
                    }
                    else if (matrix[startRol, startCol] == 'c')
                    {
                        matrix[startRol, startCol] = '*';

                        coals++;
                    }
                }
                else if (commands[i]=="right"&&startCol+1<input)
                {
                    startCol++;
                    if (matrix[startRol, startCol] == 'e')
                    {
                        isReachedEnd = true;
                    }
                    else if (matrix[startRol, startCol] == 'c')
                    {
                        matrix[startRol, startCol] = '*';

                        coals++;
                    }
                }
                else if (commands[i]=="left"&&startCol-1>=0)
                {
                    startCol--;
                    if (matrix[startRol, startCol] == 'e')
                    {
                        isReachedEnd = true;
                    }
                    else if (matrix[startRol, startCol] == 'c')
                    {
                        matrix[startRol, startCol] = '*';

                        coals++;
                    }
                }
                if (isReachedEnd)
                {
                    Console.WriteLine($"Game over! ({startRol}, {startCol})");
                    break;
                }
                if (coals==coalsCount)
                {
                    Console.WriteLine($"You collected all coals! ({startRol}, {startCol})");
                    break;
                }
            }
            if (!isReachedEnd&&coals!=coalsCount)
            {
                Console.WriteLine($"{coalsCount-coals} coals left. ({startRol}, {startCol})");
            }

        }
    }
}
