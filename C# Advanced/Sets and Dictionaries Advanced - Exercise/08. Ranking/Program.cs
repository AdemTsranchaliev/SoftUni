using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            var contests = new Dictionary<string, string>();
            var users = new SortedDictionary<string,Dictionary<string,int>>();

            var input1 = Console.ReadLine().Split(new char[] { ':'},StringSplitOptions.RemoveEmptyEntries);


            while (input1[0]!= "end of contests")
            {
                contests[input1[0]] = input1[1];
                input1 = Console.ReadLine().Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
            }

            var input2 = Console.ReadLine().Split(new char[] { '=','>' }, StringSplitOptions.RemoveEmptyEntries);

            while (input2[0]!= "end of submissions")
            {
                if (contests.ContainsKey(input2[0]))
                {
                    if (contests[input2[0]]==input2[1])
                    {
                        if (!users.ContainsKey(input2[2]))
                        {
                            users[input2[2]] = new Dictionary<string, int>();
                        }
                        if (!users[input2[2]].ContainsKey(input2[0]))
                        {
                            users[input2[2]][input2[0]] = -1;

                        }
                        if (users[input2[2]][input2[0]]<int.Parse(input2[3]))
                        {
                            users[input2[2]][input2[0]] = int.Parse(input2[3]);
                        }

                    }
                }

                input2 = Console.ReadLine().Split(new char[] { '=', '>' }, StringSplitOptions.RemoveEmptyEntries);

            }
            var bestCandidat = users.OrderByDescending(x=>x.Value.Values.Sum()).First();
            Console.WriteLine($"Best candidate is {bestCandidat.Key} with total {bestCandidat.Value.Values.Sum()} points.");
            Console.WriteLine("Ranking:");
            foreach (var (key,value) in users)
            {
                Console.WriteLine($"{key}");
                foreach (var (key2,value2) in value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"#  {key2} -> {value2}");
                }
            }
        }
    }
}
