using System;
using System.IO;

namespace _02._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var streamReader = new StreamReader("Input.txt");

            using (streamReader)
            {
                var newLine = streamReader.ReadLine();
                var streamWriter = new StreamWriter("Output.txt");
                var counter = 1;
                using (streamWriter)
                {
                    while (newLine != null)
                    {

                        streamWriter.WriteLine(counter+". "+newLine, true);
                        streamWriter.Flush();
                        newLine = streamReader.ReadLine();
                        counter++;
                    }
                }

            }
        }
    }
}
