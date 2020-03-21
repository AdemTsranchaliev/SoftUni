using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            var greenLight = int.Parse(Console.ReadLine());
            var freeWindow = int.Parse(Console.ReadLine());
            var queue = new Queue<char>();
            int count = 0;
            bool isCrash = true;
            while (true)
            {
                var command = Console.ReadLine();

                if (command=="green")
                {
                    int charCounter = 0;
                    var lastCar = "";
                    while(charCounter!=greenLight&&queue.Any())
                    {
                        if (queue.Peek()=='\0')
                        {
                            queue.Dequeue();
                            count++;
                            lastCar = "";
                        }
                        else
                        {
                            charCounter++;
                            lastCar += queue.Dequeue().ToString();
                        }           
                    }
                    if (lastCar!="")
                    {
                        var countOfFreeWindow = 0;
                        while (queue.Any()&&queue.Peek()!='\0'&& countOfFreeWindow!=freeWindow)
                        {
                            lastCar += queue.Peek().ToString();
                            queue.Dequeue();
                            countOfFreeWindow++;
                        }
                    }
                    if (queue.Any())
                    {
                        if (queue.Peek()!='\0')
                        {
                            var crackAt = queue.Peek();
                            while (queue.Any()&&queue.Peek()!='\0')
                            {
                                lastCar += queue.Dequeue().ToString();

                            }
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{lastCar} was hit at {crackAt}.");
                            isCrash = false;
                            break;
                        }
                        else
                        {
                            count++;
                            queue.Dequeue();
                        }
                    }
                 
                }
                else if (command=="END")
                {
                    break;
                }
                else
                {
                    foreach (var item in command)
                    {
                        queue.Enqueue(item);
                    }
                    queue.Enqueue('\0');
                }
               
            }
            if (isCrash)
            {

                Console.WriteLine($"Everyone is safe.");
                Console.WriteLine($"{count} total cars passed the crossroads.");
            }

        }
    }
}
