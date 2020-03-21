using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var str = "";
            var stack = new Stack<string>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var command = input.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "1"&&command.Length==2)
                {
                    str += command[1];
                    stack.Push(input);
                }
                else if (command[0] == "2" && command.Length ==2&& (str.Length - int.Parse(command[1]))>=0)
                {
                  
                        stack.Push($"2 {str.Substring(str.Length - int.Parse(command[1]))}");

                        str = str.Substring(0, str.Length - int.Parse(input.Substring(2)));
                 
                  

                }
                else if (command[0] == "3" && command.Length ==2 && int.Parse(command[1]) - 1 < str.Length&& int.Parse(command[1]) - 1>=0)
                {
                    Console.WriteLine(str[int.Parse(command[1]) - 1]);
                }
                else if (command[0] == "4" && command.Length ==1&& stack.Any())
                {
                    
                    var undoCommand = stack.Pop();
                    if (undoCommand[0] == '1')
                    {
                        str = str.Remove(str.IndexOf(undoCommand.Substring(2)));
                    }
                    else if (undoCommand[0] == '2')
                    {
                        str = str + undoCommand.Substring(2);

                    }
                  
                }
            }
        }
    }
}