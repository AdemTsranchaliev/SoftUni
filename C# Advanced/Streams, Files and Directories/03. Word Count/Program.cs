using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03._Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            var stream1 = new StreamReader("words.txt");
            var dict = new Dictionary<string, int>();

            using (stream1)
            {
                var words = stream1.ReadToEnd().Split().ToArray();
                for (int i = 0; i < words.Length; i++)
                {
                    dict[words[i]] = 0;
                }
            }


            var stream2 = new StreamReader("text.txt");
            using (stream2)
            {
                var allText = stream2.ReadToEnd().Split(new[] { ' ', ',', '.', '?', '!', '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                foreach (var item in allText)
                {
                    if (dict.ContainsKey(item.ToLower()))
                    {
                        dict[item.ToLower()]++;
                    }
                }
            }
            var stream3 = new StreamWriter("Output.txt");
            using (stream3)
            {
                foreach (var (key,value) in dict)
                {
                    stream3.WriteLine($"{key} -> {value}");
                }
            }

        }
    }
}
