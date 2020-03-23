using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Filter_By_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, int>();

            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var nameAge = Console.ReadLine().Split(new[] { ' ',','},StringSplitOptions.RemoveEmptyEntries);

                dict[nameAge[0]] = int.Parse(nameAge[1]);
            }
            var youngerOrOlder = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var format = Console.ReadLine();

            Func<int, bool> selectByGivenParam;


            if (youngerOrOlder=="younger")
            {
                selectByGivenParam = x => x < age;
            }
            else
            {
                selectByGivenParam = x => x >= age;
            }

            Action<string,int> formating;


            if (format == "name age")
            {
                formating = (x,y) => Console.WriteLine($"{x} - {y}");
            }
            else if(format=="name")
            {
                formating = (x, y) => Console.WriteLine($"{x}");
            }
            else
            {
                formating = (x, y) => Console.WriteLine($"{y}");
            }

            dict=dict.Where(x => selectByGivenParam(x.Value)).ToDictionary(x=>x.Key,y=>y.Value);

            foreach (var item in dict)
            {
                formating(item.Key, item.Value);
            }
        }
    }
}
