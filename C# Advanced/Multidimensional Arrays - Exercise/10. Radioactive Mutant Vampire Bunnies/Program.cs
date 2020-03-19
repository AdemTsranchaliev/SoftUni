using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Radioactive_Mutant_Vampire_Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var matrix = new string[input[0], input[1]];
            var playerStartRol=0;
            var playerStartCol=0;
            var listWithBunyCordinats = new Queue<int>();


            for (int i = 0; i < input[0]; i++)
            {
                var input2 = Console.ReadLine().ToCharArray().Select(x=>x.ToString()).ToArray(); 
                for (int j = 0; j < input[1]; j++)
                {
                    if (input2[j]=="P")
                    {
                        playerStartRol = i;
                        playerStartCol = j;
                    }
                    if (input2[j]=="B")
                    {
                        listWithBunyCordinats.Enqueue(i);
                        listWithBunyCordinats.Enqueue(j);
                       
                    }
                    matrix[i, j] = input2[j];
                }
            }
            var command = Console.ReadLine().ToCharArray();

            for (int i = 0; i < command.Length; i++)
            {
                var isPlayerOut = false;
                var isBunyKilledPlayer = false;
                if (command[i]=='L')
                {
                    if (playerStartCol-1>=0)
                    {
                        matrix[playerStartRol, playerStartCol] = ".";
                        playerStartCol--;
                        if (matrix[playerStartRol, playerStartCol] == "B")
                        {
                            isBunyKilledPlayer = true;
                            matrix[playerStartRol, playerStartCol] = "B";
                        }
                        else
                        {
                            matrix[playerStartRol, playerStartCol] = "P";

                        }


                    }
                    else
                    {
                        isPlayerOut = true;
                    }
                }
                else if(command[i] == 'R')
                {
                    if (playerStartCol + 1 < input[1])
                    {
                        matrix[playerStartRol, playerStartCol] = ".";

                        playerStartCol++;
                        if (matrix[playerStartRol, playerStartCol] == "B")
                        {
                            isBunyKilledPlayer = true;
                            matrix[playerStartRol, playerStartCol] = "B";
                        }
                        else
                        {
                            matrix[playerStartRol, playerStartCol] = "P";

                        }


                    }
                    else
                    {
                        isPlayerOut = true;

                    }
                }
                else if (command[i] == 'U')
                {
                    if (playerStartRol - 1 >= 0)
                    {
                        matrix[playerStartRol, playerStartCol] = ".";

                        playerStartRol--;
                        if (matrix[playerStartRol, playerStartCol] == "B")
                        {
                            isBunyKilledPlayer = true;
                            matrix[playerStartRol, playerStartCol] = "B";
                        }
                        else
                        {
                            matrix[playerStartRol, playerStartCol] = "P";

                        }
                    }
                    else
                    {
                        isPlayerOut = true;

                    }
                }
                else if (command[i] == 'D')
                {
                    if (playerStartRol + 1 < input[0])
                    {
                        matrix[playerStartRol, playerStartCol] = ".";

                        playerStartRol++;
                        if (matrix[playerStartRol, playerStartCol] == "B")
                        {
                            isBunyKilledPlayer = true;
                            matrix[playerStartRol, playerStartCol] = "B";
                        }
                        else
                        {
                            matrix[playerStartRol, playerStartCol] = "P";

                        }
                    }
                    else
                    {
                        isPlayerOut = true;

                    }
                }


                var tempStack = new Queue<int>();


                while (listWithBunyCordinats.Count != 0)
                {
                    var bunyIndexRol = listWithBunyCordinats.Dequeue();
                    var bunyIndexCol = listWithBunyCordinats.Dequeue();
                  
                   

                    if (bunyIndexCol + 1 < input[1])
                    {
                        if (matrix[bunyIndexRol, bunyIndexCol + 1] == "P")
                        {
                            matrix[bunyIndexRol, bunyIndexCol + 1] = "B";
                            isBunyKilledPlayer = true;

                        }
                        if (matrix[bunyIndexRol, bunyIndexCol + 1]!="B")
                        {
                           
                            matrix[bunyIndexRol, bunyIndexCol+1] = "B";
                            tempStack.Enqueue(bunyIndexRol);
                            tempStack.Enqueue(bunyIndexCol);
                        }
                      
                       

                    }
                    if (bunyIndexCol - 1 >= 0)
                    {
                        if (matrix[bunyIndexRol, bunyIndexCol - 1] == "P")
                        {
                            matrix[bunyIndexRol, bunyIndexCol - 1] = "B";
                            isBunyKilledPlayer = true;

                        }
                        if (matrix[bunyIndexRol, bunyIndexCol - 1]!="B")
                        {
                            matrix[bunyIndexRol, bunyIndexCol-1] = "B";
                            tempStack.Enqueue(bunyIndexRol);
                            tempStack.Enqueue(bunyIndexCol);
                        }
                   
                    
                    }
                    if (bunyIndexRol + 1 < input[0])
                    {
                        if (matrix[bunyIndexRol + 1, bunyIndexCol] == "P")
                        {
                            matrix[bunyIndexRol + 1, bunyIndexCol] = "B";
                            isBunyKilledPlayer = true;

                        }
                        if (matrix[bunyIndexRol + 1, bunyIndexCol]!="B")
                        {
                            matrix[bunyIndexRol+1, bunyIndexCol] = "B";
                            tempStack.Enqueue(bunyIndexRol);
                            tempStack.Enqueue(bunyIndexCol);
                        }
                      

                    }
                    if (bunyIndexRol - 1 >= 0)
                    {
                        if (matrix[bunyIndexRol - 1, bunyIndexCol] == "P")
                        {
                            matrix[bunyIndexRol - 1, bunyIndexCol] = "B";
                            isBunyKilledPlayer = true;

                        }
                        if (matrix[bunyIndexRol - 1, bunyIndexCol]!="B")
                        {
                            matrix[bunyIndexRol-1, bunyIndexCol] = "B";
                            tempStack.Enqueue(bunyIndexRol);

                            tempStack.Enqueue(bunyIndexCol);
                        }
                    
                    }
                }
      listWithBunyCordinats = tempStack;
                if (isPlayerOut)
                {
                    for (int p = 0; p < input[0]; p++)
                    {
                        for (int q = 0; q < input[1]; q++)
                        {
                            Console.Write(matrix[p, q]);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine($"won: {playerStartRol} {playerStartCol}");
                    break;
                }
                if (isBunyKilledPlayer)
                {
                    for (int p = 0; p < input[0] ; p++)
                    {
                        for (int q = 0; q < input[1]; q++)
                        {
                            Console.Write(matrix[p,q]);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine($"dead: {playerStartRol} {playerStartCol}");
                    break;
                }
          
            }

           
        }
    }
}
