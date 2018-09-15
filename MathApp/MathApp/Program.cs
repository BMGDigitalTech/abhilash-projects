using System;

namespace MathApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ceiling: " + Math.Ceiling(15.4));
            Console.WriteLine("Flooring: " + Math.Floor(15.4));

            Console.WriteLine("3 to the power 25 is {0}", Math.Pow(3, 5));
            Console.WriteLine("PI is: " + Math.PI);

            Console.WriteLine("The square root of 25 is {0}", Math.Sqrt(25));
            Console.WriteLine("ALways positive is {0}", Math.Abs(-25));
            Console.WriteLine("cos 1 is: {0}", Math.Cos(1));

            Console.ReadKey();
        }
    }
}
