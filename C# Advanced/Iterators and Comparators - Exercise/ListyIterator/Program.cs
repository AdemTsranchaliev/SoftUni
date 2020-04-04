using System;
using System.Collections.Generic;

namespace ListyIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();

            var sep = command.Split();

            var listOfData = new List<string>();

            if (sep[0] == "Create")
            {
                for (int i = 1; i < sep.Length; i++)
                {
                    listOfData.Add(sep[i]);
                }
            }

            var iterator=new ListyIterator<string>(listOfData);

            command = Console.ReadLine();

            while (command!="END")
            {
                if (command=="Move")
                {
                    Console.WriteLine(iterator.Move());
                }
                else if (command=="Print")
                {
                    iterator.Print();
                }
                else if (command=="HasNext")
                {
                    Console.WriteLine(iterator.HasNext());
                }
                else if (command=="PrintAll")
                {
                    foreach (var item in iterator)
                    {
                        Console.Write(item+" ");
                    }
                    Console.WriteLine();
                }
            

                command = Console.ReadLine();
            }
        }
    }
}
