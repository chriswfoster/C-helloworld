using System;

namespace HellWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"\nHello, {name}, the time is {date:t} on {date:d}");
            Console.Write("Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}