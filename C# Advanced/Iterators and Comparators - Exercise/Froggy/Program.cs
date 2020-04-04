using System;
using System.Linq;

namespace Froggy
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            var frog = new FrogJump(command);

            Console.WriteLine(string.Join(", ",frog));

            
        }
    }
}
