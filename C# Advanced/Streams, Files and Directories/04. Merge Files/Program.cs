using System;
using System.IO;

namespace _04._Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            var stream1 = new StreamReader("FileOne.txt");
            var stream2 = new StreamReader("FileTwo.txt");

            using (stream1)
            {
                using (stream2)
                {
                    var txt1 = stream1.ReadLine();
                    var txt2 = stream2.ReadLine();
                    var output = new StreamWriter("Output.txt");
                    using (output)
                    {
                        while (txt2 != null|| txt1 != null)
                        {
                            if (txt1 != null)
                            {
                                output.WriteLine(txt1);
                            }
                            if (txt2 != null)
                            {
                                output.WriteLine(txt2);

                            }

                            txt1 = stream1.ReadLine();
                            txt2 = stream2.ReadLine();
                        }
                    }

                }

            }

        }
    }
}
