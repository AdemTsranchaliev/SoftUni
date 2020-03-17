using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var matrix = new int[input, input];

            for (int i = 0; i < input; i++)
            {
                var input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < input; j++)
                {
                    matrix[i, j] = input2[j];
                }
            }
            var command = Console.ReadLine().Split();
            while (command[0]!="END")
            {
                int row = int.Parse(command[1]);
                int cow = int.Parse(command[2]);
                int increaceBy = int.Parse(command[3]);

                if (row>=0&&row<input&&cow>=0&&cow<input)
                {
                    if (command[0]== "Add")
                    {
                        matrix[row, cow] += increaceBy;

                    }
                    else if(command[0] == "Subtract")
                    {
                        matrix[row, cow] -= increaceBy;

                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }
                command = Console.ReadLine().Split();

            }

            for (int i = 0; i < input; i++)
            {
                for (int j = 0; j < input; j++)
                {
                    Console.Write(matrix[i,j]+" ");
                }
                Console.WriteLine();
            }
        
        }
    }
}
