using System;
using System.IO;
using System.Linq;

namespace _06._Folder_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            var stream = new FileStream("sliceMe.txt", FileMode.OpenOrCreate);
            var parts = 4;
            var bufferSize = (int)Math.Ceiling(stream.Length / (double)parts);
            using (stream)
            {
                var arr = new byte[bufferSize];
                var counter = 1;
                var n = stream.Read(arr, 0, bufferSize);
                while (n != 0)
                {
                    var stream2 = new FileStream($"Part-{counter}.txt", FileMode.OpenOrCreate);

                    stream2.Write(arr.Take(n).ToArray());
                    stream2.Flush();
                    stream2.Close();
                    counter++;
                    n = stream.Read(arr, 0, bufferSize);
                }


            }
        }
    }
}
