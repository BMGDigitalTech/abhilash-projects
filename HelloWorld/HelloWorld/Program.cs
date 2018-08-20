using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
           
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            string message = "Hello " + name + " How you doing ";
            string capsMessage = message.ToUpper();
            Console.WriteLine($"Hello {name}");
            Console.WriteLine(capsMessage);

            Console.ReadLine();
        }
    }
}
