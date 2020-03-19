using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var matrix = new string[input[0], input[1]];

            for (int i = 0; i < input[0]; i++)
            {
                var input2 = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int j = 0; j < input[1]; j++)
                {
                    matrix[i, j] = input2[j];
                }
            }

            var command = Console.ReadLine();

            while (command.ToLower()!="end")
            {
                var sepCommand = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (sepCommand[0]=="swap"&&sepCommand.Length==5)
                {
                    int fromRow=int.Parse(sepCommand[1]);
                    int fromCol= int.Parse(sepCommand[2]);
                    int toRow= int.Parse(sepCommand[3]);
                    int toCol= int.Parse(sepCommand[4]);

                    if (fromRow>=0&&fromCol>=0&&fromRow<input[0]&&fromCol<input[1]&& toRow >= 0 && toCol >= 0 && toRow < input[0] && toCol < input[1]&&sepCommand.Length==5)
                    {
                        var temp = matrix[fromRow, fromCol];
                        matrix[fromRow, fromCol] = matrix[toRow,toCol];
                        matrix[toRow, toCol] = temp;
                        for (int i = 0; i < input[0] ; i++)
                        {
                            for (int j = 0; j < input[1] ; j++)
                            {
                                Console.Write(matrix[i,j]+" ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                command = Console.ReadLine();
            }
           

        }
    }
}
