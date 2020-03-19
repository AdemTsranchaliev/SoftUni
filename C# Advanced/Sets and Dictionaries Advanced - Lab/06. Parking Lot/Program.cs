using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            var commandCar = Console.ReadLine().Split(new char[] { ' ',',' },StringSplitOptions.RemoveEmptyEntries).ToArray();
            var set = new HashSet<string>();
            while (commandCar[0].ToLower()!="end")
            {
                if (commandCar[0]=="IN")
                {
                    set.Add(commandCar[1]);
                }
                else if (commandCar[0] == "OUT")
                {
                    set.Remove(commandCar[1]);
         
                }
                commandCar = Console.ReadLine().Split(new char[] { ' ', ',' }).ToArray();
            }
            if (set.Count==0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var item in set)
                {
                    Console.WriteLine(item);
                }
            }
            
        }
    }
}
