using System;
using System.IO;
using System.Linq;

namespace _06._Folder_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            var files = Directory.GetFiles("../../../TestFolder");
            long sum = 0;
            foreach (var item in files)
            {
                var file = new FileInfo(item);
               sum+= file.Length;
            }

            Console.WriteLine((decimal)(sum/1024.0/1024.0));
        }
      
    }
}
