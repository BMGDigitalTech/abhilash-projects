using System;

namespace tableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number to output the table");
            string input = Console.ReadLine();
            int num = int.Parse(input);
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + "x" + i + "=" + (num * i));
            }
            Console.Read();
        }
    }
}
