using System;
using System.Linq;

namespace ThreeupleExercise
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();

            var tuple1 = new Threeuple<string, string,string>(input[0] + " " + input[1], input[2], input[3]);
            Console.WriteLine(tuple1);

             input = Console.ReadLine().Split().ToArray();
            bool isDrund = input[2].ToLower() == "drunk" ? true : false;
            var tuple2 = new Threeuple<string, int,bool>(input[0], int.Parse(input[1]), isDrund);
            Console.WriteLine(tuple2);

             input = Console.ReadLine().Split().ToArray();
            var tuple3 = new Threeuple<string, double, string>(input[0], double.Parse(input[1]),input[2]);


            Console.WriteLine(tuple3);

        }
    }
}
