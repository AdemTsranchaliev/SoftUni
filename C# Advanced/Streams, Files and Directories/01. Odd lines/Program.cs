using System;
using System.IO;
using System.Linq;
using System.Text;

namespace _01._Odd_lines
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
                var counter = 0;
                using (streamWriter)
                {
                    while (newLine != null)
                    {
                        if (counter%2==1)
                        {
                            streamWriter.WriteLine(newLine,true);
                            streamWriter.Flush();
                        }
                        newLine = streamReader.ReadLine();
                        counter++;
                    }
                }
           
            }
        }
    }
}
