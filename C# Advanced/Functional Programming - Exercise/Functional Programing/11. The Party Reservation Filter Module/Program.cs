using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._The_Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine()
               .Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries)
               .ToList();

            var list = new HashSet<string>();

            var command = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            while (command[0] != "Print")
            {

                if (command[0] == "Remove filter")
                {
                    list.Remove(command[1]+"_"+command[2]);
                }
                else if (command[0] == "Add filter")
                {
                    list.Add(command[1] + "_" + command[2]);
                }



                command = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            }
            foreach (var item in list)
            {
                Predicate<string> predi = Predicate(item);

                names.RemoveAll(predi);
            }

          
                Console.WriteLine(string.Join(" ",names));
            
        }

        static Predicate<string> Predicate(string list)
        {
            var spr = list.Split('_');
            if (spr[0] == "Starts with")
            {
                return x => x.StartsWith(spr[1]);
            }
            else if (spr[0] == "Ends with")
            {
                return x => x.EndsWith(spr[1]);

            }
            else if (spr[0] == "Length")
            {
                return (x => x.Length == int.Parse(spr[1]));
            }
            else if (spr[0] == "Contains")
            {
                return (x => x.Contains(spr[1]));
            }
            return null;
        }

    }
}
