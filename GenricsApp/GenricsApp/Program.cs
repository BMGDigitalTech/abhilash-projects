using System;

namespace GenricsApp
{
    class Program
    {
        public class Calculator
        {
            public static bool AreEqual<T>(T value1, T value2)
            {
                return value1.Equals(value2);
            }
        }
        static void Main(string[] args)
        {
            //bool equal = Calculator.AreEqual<int>(10, 20);
            bool equal = Calculator.AreEqual<double>(10.2, 10.2);

            if (equal)
            {
                Console.WriteLine("Equal");
            } else
            {
                Console.WriteLine("Not Equal");
            }

            string str = @"THis is Abhilash's car";

            Console.WriteLine(str);

        }
    }
}
