using System;

namespace ReVolt
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var commandCount= int.Parse(Console.ReadLine());
            var playerRow = 0;
            var playerColum = 0;
            var matrix = new char[n, n];

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().ToCharArray();
                for (int j = 0; j < n; j++)
                {
                    if (input[j]=='f')
                    {
                        playerRow = i;
                        playerColum = j;
                    }
                    matrix[i, j] = input[j];
                }
            }
            var isEnded = false;
            for (int i = 0; i < commandCount; i++)
            {
                var command = Console.ReadLine();

                if (command == "down")
                {
                    matrix[playerRow, playerColum] = '-';
                    playerRow++;

                    if (playerRow >= n)
                    {
                        if (matrix[playerRow - n, playerColum] == 'T')
                        {
                            playerRow--;
                        }
                        else
                        {
                            playerRow -= n;

                        }
                        matrix[playerRow, playerColum] = 'f';
                    }

                    if (matrix[playerRow, playerColum] == 'T')
                    {
                        playerRow--;
                        matrix[playerRow, playerColum] = 'f';
                    }


                    while (matrix[playerRow, playerColum] == 'B')
                    {
                        playerRow++;

                        if (playerRow >= n)
                        {

                            playerRow -= n;


                        }
                    }
                    if (matrix[playerRow, playerColum] == 'F')
                    {
                        isEnded = true;
                        matrix[playerRow, playerColum] = 'f';
                        break;
                    }
                    matrix[playerRow, playerColum] = 'f';

                }
                else if (command == "right")
                {
                    matrix[playerRow, playerColum] = '-';
                    playerColum++;

                    if (playerColum >= n)
                    {
                        if (matrix[playerRow, playerColum - n] == 'T')
                        {
                            playerColum--;
                        }
                        else
                        {
                            playerColum -= n;

                        }
                        matrix[playerRow, playerColum] = 'f';
                    }

                    if (matrix[playerRow, playerColum] == 'T')
                    {
                        playerColum--;
                        matrix[playerRow, playerColum] = 'f';
                    }


                    while (matrix[playerRow, playerColum] == 'B')
                    {
                        playerColum++;

                        if (playerColum >= n)
                        {

                            playerColum -= n;


                        }
                    }
                    if (matrix[playerRow, playerColum] == 'F')
                    {
                        isEnded = true;
                        matrix[playerRow, playerColum] = 'f';
                        break;
                    }
                    matrix[playerRow, playerColum] = 'f';
                }
                else if (command == "left")
                {
                    matrix[playerRow, playerColum] = '-';
                    playerColum--;

                    if (playerColum < 0)
                    {
                        if (matrix[playerRow, playerColum + n] == 'T')
                        {
                            playerColum++;
                        }
                        else
                        {
                            playerColum += n;

                        }
                        matrix[playerRow, playerColum] = 'f';
                    }

                    if (matrix[playerRow, playerColum] == 'T')
                    {
                        playerColum++;
                        matrix[playerRow, playerColum] = 'f';
                    }


                    while (matrix[playerRow, playerColum] == 'B')
                    {
                        playerColum--;

                        if (playerColum < 0)
                        {
                            playerColum += n;
                        }
                    }
                    if (matrix[playerRow, playerColum] == 'F')
                    {
                        isEnded = true;
                        matrix[playerRow, playerColum] = 'f';
                        break;
                    }
                    matrix[playerRow, playerColum] = 'f';
                }
                else if (command == "up")
                {
                    matrix[playerRow, playerColum] = '-';
                    playerRow--;

                    if (playerRow < 0)
                    {
                        if (matrix[playerRow+n, playerColum] == 'T')
                        {
                            playerRow++;
                        }
                        else
                        {
                            playerRow += n;

                        }
                        matrix[playerRow, playerColum] = 'f';
                    }

                    if (matrix[playerRow, playerColum] == 'T')
                    {
                        playerRow++;
                        matrix[playerRow, playerColum] = 'f';
                    }


                    while (matrix[playerRow, playerColum] == 'B')
                    {
                        playerRow--;

                        if (playerRow < 0)
                        {

                            playerRow += n;


                        }
                    }
                    if (matrix[playerRow, playerColum] == 'F')
                    {
                        isEnded = true;
                        matrix[playerRow, playerColum] = 'f';
                        break;
                    }
                    matrix[playerRow, playerColum] = 'f';
                }
            }
            if (isEnded)
            {
                Console.WriteLine("Player won!");
            }
            else
            {
                Console.WriteLine($"Player lost!");
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
