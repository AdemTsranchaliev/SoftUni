using System;

namespace BookWorm
{
    class Program
    {
        static void Main(string[] args)
        {
            var initial = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());
            var matrix = new char[n,n];
            var pColum = 0;
            var pRow = 0;
            for (int i = 0; i < n; i++)
            {
                var characters = Console.ReadLine().ToCharArray();

                for (int j = 0; j < n; j++)
                {
                    if (characters[j]=='P')
                    {
                        pColum = j;
                        pRow = i;
                    }
                    matrix[i, j] = characters[j];
                }
            }

            var comand = Console.ReadLine();
            while (comand!="end")
            {
                if (comand=="down")
                {
                    if (pRow+1<n)
                    {
                        matrix[pRow, pColum] = '-';
                        pRow++;
                        if (matrix[pRow,pColum]!='-')
                        {
                            initial += matrix[pRow, pColum].ToString();
                        }
                        matrix[pRow, pColum] = 'P';
                    }
                    else
                    {
                        initial = RemoveLastCharacter(initial);
                    }
                }
                else if (comand=="up")
                {
                    if (pRow - 1 >= 0)
                    {
                        matrix[pRow, pColum] = '-';
                        pRow--;
                        if (matrix[pRow, pColum] != '-')
                        {
                            initial += matrix[pRow, pColum].ToString();
                        }
                        matrix[pRow, pColum] = 'P';
                    }
                    else
                    {
                        initial = RemoveLastCharacter(initial);
                    }
                }
                else if (comand=="right")
                {
                    if (pColum + 1 < n)
                    {
                        matrix[pRow, pColum] = '-';
                        pColum++;
                        if (matrix[pRow, pColum] != '-')
                        {
                            initial += matrix[pRow, pColum].ToString();
                        }
                        matrix[pRow, pColum] = 'P';
                    }
                    else
                    {
                        initial = RemoveLastCharacter(initial);
                    }
                }
                else if (comand == "left")
                {
                    if (pColum - 1 >= 0)
                    {
                        matrix[pRow, pColum] = '-';
                        pColum--;
                        if (matrix[pRow, pColum] != '-')
                        {
                            initial += matrix[pRow, pColum].ToString();
                        }
                        matrix[pRow, pColum] = 'P';
                    }
                    else
                    {
                        initial = RemoveLastCharacter(initial);
                    }
                }

                comand = Console.ReadLine();
            }
            Console.WriteLine(initial);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
        
        static string RemoveLastCharacter(string word)
        {
            return word.Substring(0,word.Length-1);
        }
    }
}
