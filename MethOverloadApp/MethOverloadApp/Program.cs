using System;

namespace MethOverloadApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(2, 3));
            Console.WriteLine(Add(2.5, 3.5));
            Console.WriteLine(Add("abhilash ", " n"));
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static string Add(string a, string b)
        {
            return a + b;
        }
    }
}
