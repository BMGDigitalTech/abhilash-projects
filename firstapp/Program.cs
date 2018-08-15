using System;

namespace firstapp
{
    class Program
    {
        static void Main(string[] args)
        {
	    string name;
            Console.WriteLine("What is your name?");
	    name = Console.ReadLine();
	    Console.WriteLine($"Hello {name}");
        }
    }
}
