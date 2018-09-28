using System;

namespace GenericsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = Calculator.AreEqual<int>(5, 5);
            if (flag)
            {
                Console.WriteLine("Are Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
    }

    class Calculator
    {
        public static bool AreEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
}
