using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine()
                .Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var command = Console.ReadLine().Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (command[0] != "Party!")
            {
                var predicat = Predicate(command.Skip(1).ToList());

                if (command[0] == "Remove")
                {
                    names.RemoveAll(predicat);
                }
                else if (command[0] == "Double")
                {
                    for (int i = 0; i < names.Count; i++)
                    {
                        if (predicat(names[i]))
                        {
                            names.Insert(i+1,names[i]);
                            i++;
                        }
                    }
                }
               


                command = Console.ReadLine().Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            }
            if (names.Count>0)
            {
                Console.Write(string.Join(", ", names) + " are going to the party!");

            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }

        }

        static Predicate<string> Predicate(List<string> list)
        {
            if (list[0] == "StartsWith")
            {
               return x => x.StartsWith(list[1]);
            }
            else if (list[0] == "EndsWith")
            {
                return x => x.EndsWith(list[1]);

            }
            else if (list[0] == "Length")
            {
                return(x => x.Length == int.Parse(list[1]));
            }
            return null;
        }
    }
}
