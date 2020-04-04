using System;

namespace CustomStack
{
    class Program
    {
        static void Main(string[] args)
        {

            var stack = new MyStack<string>();

            var command = Console.ReadLine();

            while (command != "END")
            {

                var sep = command.Split(new char[] { ' ',','},StringSplitOptions.RemoveEmptyEntries);


                if (sep[0] == "Push")
                {
                    for (int i = 1; i < sep.Length; i++)
                    {
                        stack.Push(sep[i]);
                    }
                }
                else if (sep[0] == "Pop")
                {
                    stack.Pop();
                }
                command = Console.ReadLine();
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
