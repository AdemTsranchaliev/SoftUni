using System;
using System.Linq;

namespace TupleNamespace
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var input1 = Console.ReadLine().Split().ToArray();
            var tuple1=new Tuple<string,string>(input1[0]+" "+ input1[1], input1[2]);

            var input2 = Console.ReadLine().Split().ToArray();
            var tuple2 = new Tuple<string, int>(input2[0], int.Parse(input2[1]));

            var input3 = Console.ReadLine().Split().ToArray();
            var tuple3 = new Tuple<int, double>(int.Parse(input3[0]), double.Parse(input3[1]));

            Console.WriteLine(tuple1);
            Console.WriteLine(tuple2);

            Console.WriteLine(tuple3);

        }
    }
}
