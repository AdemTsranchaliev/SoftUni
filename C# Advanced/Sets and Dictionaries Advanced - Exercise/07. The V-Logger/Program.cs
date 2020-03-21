using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            var userFollowing = new Dictionary<string, SortedSet<string>>();
            var userFollowers = new Dictionary<string, SortedSet<string>>();

            var command = Console.ReadLine().Split(new[] { ' '},StringSplitOptions.RemoveEmptyEntries);

            while (command[0]!= "Statistics")
            {
                if (command[1]=="joined")
                {
                    if (!userFollowing.ContainsKey(command[0]))
                    {
                        userFollowing[command[0]] = new SortedSet<string>();
                        userFollowers[command[0]]= new SortedSet<string>();
                    }
                }
                else if (command[1] == "followed")
                {
                    if (userFollowing.ContainsKey(command[0]))
                    {
                        if (command[0]!=command[2]&&userFollowing.ContainsKey(command[2]))
                        {
                            userFollowing[command[0]].Add(command[2]);
                            userFollowers[command[2]].Add(command[0]);
                        }
                    }
                }


                command = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }
            userFollowers = userFollowers.OrderByDescending(x => x.Value.Count).ThenBy(x=>userFollowing[x.Key].Count).ToDictionary(x=>x.Key,y=>y.Value);
            Console.WriteLine($"The V-Logger has a total of {userFollowing.Keys.Count} vloggers in its logs.");


            int counter = 1;

            foreach (var (key,value) in userFollowers)
            {
                Console.WriteLine($"{counter}. {key} : {value.Count} followers, {userFollowing[key].Count} following");
                if (counter==1)
                {
                    foreach (var item in value)
                    {
                        Console.WriteLine($"*  {item}");
                    }
                }
                counter++;
            }
        }
    }
}
