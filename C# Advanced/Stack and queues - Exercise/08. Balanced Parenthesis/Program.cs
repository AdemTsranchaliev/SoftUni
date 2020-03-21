using System;
using System.Collections.Generic;

namespace _08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var stack = new Stack<char>();

            var flag = true;
            if (input.Length%2==0)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i]=='{'||input[i]=='('||input[i]=='[')
                    {
                        stack.Push(input[i]);
                    }
                    else if (stack.Peek() + 2 == input[i] || stack.Peek() + 1 == input[i])
                    {
                        stack.Pop();
                    }
                    else
                    {
                        flag = false;
                        break;
                    }
                }
            }
            else
            {
                flag = false;
            }

            if (flag)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
